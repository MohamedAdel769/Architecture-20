using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArchiFinalTask
{
    public static class Helper
    {
        public static string[] regsArr;
        public static Hashtable dataMemory;
        public static Hashtable instructionMem;
        public static uint pcReg = 1000;
        public static string IF_ID;
        public static string ID_EX;
        public static string EX_MEM;
        public static string MEM_WB;
        public static Queue<string> fetch, decode, exec, daccess, writeb;

        public static void Intialize(uint pcInit)
        {
            regsArr = new string[32];
            instructionMem = new Hashtable();
            dataMemory = new Hashtable(256);
            fetch = new Queue<string>();
            decode = new Queue<string>();
            exec = new Queue<string>();
            daccess = new Queue<string>();
            writeb = new Queue<string>();
            IF_ID = null;
            ID_EX = null;
            EX_MEM = null;
            MEM_WB = null;
            regsArr[0] = "0";
            for (uint i = 1; i < 32; i++)
            {
                regsArr[i] = (i + 100).ToString();
            }
            for (uint i = 0; i < 256; i++)
            {
                dataMemory[i] = "99";
            }
            pcReg = pcInit;
        }
        public static void Fill_instMem(string[] instructions)
        {
            foreach (string line in instructions)
            {
                string[] instructionParts = line.Split(':');
                string pcCounter = instructionParts[0];
                string instruction = instructionParts[1].Trim();
                instruction = instruction.Replace(" ", "");
                instructionMem.Add(pcCounter, instruction);
                fetch.Enqueue(pcCounter);
            }
        }

        public static string get_IFID()
        {
            string output = "";
            string[] pipregData = IF_ID.Split(':');
            output += pipregData[0]; 
            output += " ";
            output += pipregData[1];
            return output;
        }
        public static string get_IDEX()
        {
            string output = "";
            if (ID_EX == null) return output;
            string[] pipregData = ID_EX.Split(' ');
            string []control_lines = pipregData[0].Split('/');
            string[] readData = pipregData[2].Split('/');
            string extended = pipregData[3];
            string rt = pipregData[4];
            string rd = pipregData[5];
            output += control_lines[0];
            output += " ";
            output += control_lines[1];
            output += " ";
            output += control_lines[2];
            output += " ";
            output += readData[0];
            output += " ";
            output += readData[1];
            output += " ";
            output += Convert.ToUInt32(rt, 2);
            output += " ";
            output += Convert.ToUInt32(rd, 2);
            return output;
        }
        public static string get_EXMEM()
        {
            string output = "";
            if (EX_MEM == null) return output;
            string[] pipregData = EX_MEM.Split(' ');
            string result = pipregData[1];
            string readdata2 = pipregData[2];
            string rd = pipregData[3];
            output += result;
            output += " ";
            output += readdata2;
            output += " ";
            output += Convert.ToUInt32(rd, 2);
            return output;
        }
        public static string get_MEMWB()
        {
            string output = "";
            if (MEM_WB == null) return output;
            string[] pipregData = Helper.MEM_WB.Split(' ');
            string readData = pipregData[1];
            string result = pipregData[2];
            string rd = pipregData[3];
            output += readData;
            output += " ";
            output += result;
            output += " ";
            output += Convert.ToUInt32(rd, 2);
            return output;
        }
    }
}
