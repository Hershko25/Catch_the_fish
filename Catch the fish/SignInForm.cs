using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw002
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.CheckIfExsist(int.Parse(IDInputText.Text)) == true)
            {
                    TheGame frm = new TheGame();
                    frm.MdiParent = Form1.ActiveForm;
                    frm.Show();
                    Close();
            }
            else
            {
                MessageBox.Show("There is no such a player, please sign in");
                SignUpForm frm = new SignUpForm();
                frm.MdiParent = Form1.ActiveForm;
                frm.Show();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
