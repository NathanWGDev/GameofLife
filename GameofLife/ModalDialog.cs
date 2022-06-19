using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLife
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }

       public int Number
        {
            get { return (int)numericUpDownNumber.Value; }                        
            set { numericUpDownNumber.Value = value; }
        }
        public int Number2
        {
            get { return (int)numericUpDownNumber2.Value; }
            set { numericUpDownNumber2.Value = value; }
        }
        public int Number3
        {
            get { return (int)numericUpDownNumber3.Value; }
            set { numericUpDownNumber3.Value = value; }
        }

        
    }
}
