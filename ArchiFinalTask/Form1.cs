using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiFinalTask
{
    public partial class Form1 : Form
    {
        Assembler assembler;
        public Form1()
        {
            InitializeComponent();
            assembler = new Assembler();
        }

        private void inializeBtn_Click(object sender, EventArgs e)
        {
            PiplineGrid.Rows.Clear();
            MemoryGrid.Rows.Clear();
            uint pcInit = Convert.ToUInt32(PCTxt.Text);
            Helper.Intialize(pcInit);
            for(int i = 0; i < 32; i++)
            {
                string reg = "$" + i;
                MipsGrid.Rows.Add(reg, Helper.regsArr[i].ToString());
            }
            string userCode = UserCodetxt.Text;
            string[] instructions = userCode.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            Helper.Fill_instMem(instructions);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            PiplineGrid.Rows.Clear();
            MemoryGrid.Rows.Clear();
            assembler.Cycle();
            display_IFID();
            display_IDEX();
            display_EXMEM();
            display_MEMWB();
            for (uint i = 0; i < 256; i++)
            {
                MemoryGrid.Rows.Add(i.ToString(), Helper.dataMemory[i]);
            }
        }
        public void display_IFID()
        {
            string[] outputs = Helper.get_IFID().Split(' ');
            PiplineGrid.Rows.Add("IF_ID Adder1output", outputs[0]);
            PiplineGrid.Rows.Add("IF_ID Instruction", outputs[1]);
        }
        public void display_IDEX()
        {
            string idix = Helper.get_IDEX();
            if (idix == "") return;
            string[] outputs = idix.Split(' ');
            PiplineGrid.Rows.Add("ID_EX Execution controlLines", outputs[0]);
            PiplineGrid.Rows.Add("ID_EX Memory controlLines", outputs[1]);
            PiplineGrid.Rows.Add("ID_EX Write-back controlLines", outputs[2]);
            PiplineGrid.Rows.Add("ID_EX ReadData1", outputs[3]);
            PiplineGrid.Rows.Add("ID_EX ReadData2", outputs[4]);
            PiplineGrid.Rows.Add("ID_EX Instr[20-16]", outputs[5]);
            PiplineGrid.Rows.Add("ID_EX Instr[15-11]", outputs[6]);
        }
        public void display_EXMEM()
        {
            string exmem = Helper.get_EXMEM();
            if (exmem == "") return;
            string[] outputs = exmem.Split(' ');
            PiplineGrid.Rows.Add("EX_MEM ALU O/P", outputs[0]);
            PiplineGrid.Rows.Add("EX_MEM ReadData2", outputs[1]);
            PiplineGrid.Rows.Add("EX_MEM RegDist_MUX O/P", outputs[2]);
        }
        public void display_MEMWB()
        {
            string memwb = Helper.get_MEMWB();
            if (memwb == "") return;
            string[] outputs = memwb.Split(' ');
            PiplineGrid.Rows.Add("MEM_WB ReadData", outputs[0]);
            PiplineGrid.Rows.Add("MEM_WB Address", outputs[1]);
            PiplineGrid.Rows.Add("MEM_WB RegDist_MUX O/P", outputs[2]);
        }
    }
}
