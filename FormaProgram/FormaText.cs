using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaProgram
{
    public partial class FormaText : Form
    {
        public FormaText()
        {
            InitializeComponent();
        }

        string name, desc;

        public string Name1 { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }


        private void btnOK_Click(object sender, EventArgs e)
        {
            name = txtBoxProgName.Text;
            desc = txtBoxProgDescription.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
