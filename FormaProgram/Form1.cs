using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Process.Start("notepad.exe");
                    break;

                case 1:
                    Process.Start("mspaint.exe");
                    break;
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                groupBoxControl.Visible = true;
            }
            else
            {
                groupBoxControl.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju" , "Obavještenje" , MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if(messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TXTtoolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormaText form2 = new FormaText();
            if (form2.ShowDialog(Owner) == DialogResult.OK)
            {
                txtBoxProgName.AppendText(form2.Name1);
                txtBoxProgDescription.AppendText(form2.Desc);
            }
        }
    }
}
