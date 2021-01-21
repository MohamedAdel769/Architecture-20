using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArchiFinalTask
{
    public class Assembler
    {
       
        string pcCounter;
        string zeroFlag;
       
        public string ControlUnit(string opCode)
        {
            string regDst = "X", aluOp1 = "X", aluOp0 = "X", aluSrc = "X", branch = "X", memRead = "X", memWrite = "X", regWrite = "X", memToReg = "X";
            string exce, memAccess, wbStage;
            if (opCode == "000000") // R-Type
            {
                regDst = "1"; aluOp1 = "1"; regWrite = "1";
                aluOp0 = "0"; aluSrc = "0"; branch = "0"; memRead = "0"; memWrite = "0"; memToReg = "0";
            }
            else if(opCode == "101011") // I-Type
            {
                aluSrc = "1"; memWrite = "1";
                regDst = "X"; memToReg = "X";
                aluOp0 = "0"; aluOp1 = "0"; branch = "0"; memRead = "0"; regWrite = "0"; 
            }
            exce = regDst + aluOp1 + aluOp0 + aluSrc;
            memAccess = branch + memRead + memWrite;
            wbStage = regWrite + memToReg;

            return exce + "/" +  memAccess + "/" + wbStage;
        }
        public string RegisterFile(string rs, string rt, string rd, string write_data, string regWrite)
        {
            string read_data12 = null;      
            
            if (regWrite == "0")
            {
                uint rs_ind = Convert.ToUInt32(rs, 2);
                uint rt_ind = Convert.ToUInt32(rt, 2);
                read_data12 = Helper.regsArr[rs_ind] + "/" + Helper.regsArr[rt_ind];
                return read_data12;
            }
            else if(regWrite == "1")
            {
                uint rd_ind = Convert.ToUInt32(rd, 2);
                Helper.regsArr[rd_ind] = write_data;
            }
            return null;
        }
        public string DataMemory(string address, string write_data, string memRead, string memWrite)
        {
            uint addr = Convert.ToUInt32(address,2);
            if (memRead == "1")
            {
                return Helper.dataMemory[addr].ToString();
            }
            if(memWrite == "1")
            {
                Helper.dataMemory[addr] = write_data; 
            }
            return null;
        }
        public string ALU(string d1, string d2, string funct, string aluOp)
        {
            uint data1 = Convert.ToUInt32(d1);
            uint data2 = Convert.ToUInt32(d2);
            uint res = 0;
            if (aluOp == "10")
            {
                switch (funct)
                {
                    case "100000":
                        res = data1 + data2;
                        break;
                    case "100010‬":
                        res = data1 - data2;
                        break;
                    case "100100":
                        res = data1 & data2;
                        break;
                    case "100101":
                        res = data1 | data2;
                        break;
                }
            }
            else if(aluOp == "00")
            {
                res = data1 + data2;       
            }
            zeroFlag = (res!=0 ? "0" : "1");
            return res.ToString();
        }
        public string SignExtend(string address)
        {
            string extended = address;
            if (address[0] == '1')
                extended = extended.PadLeft(32, '1');
            else
                extended = extended.PadLeft(32, '0');
            return extended;
        }
        public string Mux(string sel1, string sel2, string selector)
        {
            if (selector == "0")
                return sel1;
            else
                return sel2;
        }
        public void Fetch()
        {
            string instruction = Helper.instructionMem[pcCounter].ToString();
            uint new_pcCounter = Convert.ToUInt32(pcCounter);
            new_pcCounter += 4;
            pcCounter = new_pcCounter.ToString();
            Helper.IF_ID = pcCounter + ":" + instruction;
        }
        public void Decode()
        {
            string[] pipregData = Helper.IF_ID.Split(':');
            string instruction = pipregData[1];
            string opcode = instruction.Substring(0, 6);
            string rs = instruction.Substring(6, 5);
            string rt = instruction.Substring(11, 5);
            string control_lines = ControlUnit(opcode);
            string rd = instruction.Substring(16, 5);
            string readData12, extended;
            if (opcode == "000000")
            {
                string shamt = instruction.Substring(21, 5);
                string funct = instruction.Substring(26, 6);
                readData12 = RegisterFile(rs, rt, "X", "X", "0");
                extended = SignExtend(rd + shamt + funct);
            }
            else
            {
                string address = instruction.Substring(16, 5);
                readData12 = RegisterFile(rs, rt, "X", "X", "0");
                uint offset = Convert.ToUInt32(address,2);
                uint baseAdd = Convert.ToUInt32(Helper.regsArr[Convert.ToUInt32(rs,2)]);
                uint addres = offset + baseAdd;
                extended = Convert.ToString(addres, 2);  
            }
            Helper.ID_EX = control_lines + " " + pcCounter + " " + readData12 + " " + extended + " " + rt + " " + rd;
        }
        public void Execution()
        {
            string[] pipregData = Helper.ID_EX.Split(' ');
            string control_lines = pipregData[0];
            string [] readData = pipregData[2].Split('/');
            string extended = pipregData[3];
            string rt = pipregData[4];
            string rd = pipregData[5];
            string aluSrc = control_lines[3].ToString();
            string regDest = control_lines[0].ToString();
            string aluOp = control_lines.Substring(1, 2);
            string data2 = Mux(readData[1], extended, aluSrc);
            string result=extended;
            if(aluSrc == "0")
            {
                string funct = extended.Substring(26,6);
                result = ALU(readData[0], data2, funct, aluOp);
            }
            string rD = Mux(rt, rd, regDest);

            Helper.EX_MEM = control_lines + " " + result + " " + readData[1] + " " + rD;
        }
        public void DataAccess()
        {
            string[] pipregData = Helper.EX_MEM.Split(' ');
            string control_lines = pipregData[0];
            string result = pipregData[1];
            string readdata2 = pipregData[2];
            string rd = pipregData[3];
            string memWrite = control_lines[7].ToString();
            string memRead = control_lines[6].ToString();
            string readData ;
            if (memWrite=="0" && memRead == "0")
            {
                readData = "X";
            }
            else
            {
                readData = DataMemory(result, readdata2, memRead, memWrite);
            }
            Helper.MEM_WB = control_lines + " " + readData + " " + result + " " + rd;
        }
        public void WriteBack()
        {
            string[] pipregData = Helper.MEM_WB.Split(' ');
            string control_lines = pipregData[0];
            string readData = pipregData[1];
            string result = pipregData[2];
            string rd = pipregData[3];
            string memtoReg = control_lines[10].ToString();
            string regWrite = control_lines[9].ToString();
            string write_data = Mux(result, readData, memtoReg);
            if (regWrite == "1")
            {
                string output = RegisterFile("X", "X", rd, write_data, regWrite);
            }
        }
        public void Cycle()
        {
            if (Helper.writeb.Count != 0)
            {
                pcCounter = Helper.writeb.Dequeue();
                WriteBack();
            }
            if (Helper.daccess.Count != 0)
            {
                pcCounter = Helper.daccess.Dequeue();
                Helper.writeb.Enqueue(pcCounter);
                DataAccess();
            }
            if (Helper.exec.Count != 0)
            {
                pcCounter = Helper.exec.Dequeue();
                Helper.daccess.Enqueue(pcCounter);
                Execution();
            }
            if (Helper.decode.Count != 0)
            {
                pcCounter = Helper.decode.Dequeue();
                Helper.exec.Enqueue(pcCounter);
                Decode();
            }
            if (Helper.fetch.Count != 0)
            {
                pcCounter = Helper.fetch.Dequeue();
                Helper.decode.Enqueue(pcCounter);
                Fetch();
            }
        }
    }
}
