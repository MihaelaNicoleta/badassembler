using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembler
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            showAsmCode("input.asm");
        }
        
        //read asm file and display output
        private void showAsmCode(String fileName) {
            String asmCodeLine;

            StreamReader sr = new StreamReader(fileName);
            while ((asmCodeLine = sr.ReadLine()) != null)
            {
                this.asmCode.Text += "\n" + asmCodeLine;
            }

            sr.Close();
        }
    }
}
