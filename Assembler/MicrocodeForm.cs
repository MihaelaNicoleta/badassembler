using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembler
{
    public partial class MicrocodeForm : Form
    {
        public static MicrocodeForm microcodeForm = null;

        public MicrocodeForm()
        {
            microcodeForm = this;
            InitializeComponent();
        }
    }
}
