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
    public partial class Form1 : Form
    {
        static User[] UsersList = new User[1];
        static int pointer = 0;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static bool CheckIfExsist(int IDInput)
        {
            for (int i = 0; i < pointer; i++)
            {
                if (UsersList[i].ID == IDInput)
                {
                    return true;
                }
            }
            return false;

        }
public static void MakeNewUser(int IDinput , string Nameinput)
        {
            UsersList[pointer] = new User(IDinput, Nameinput);
            ADDarr(ref UsersList);
            pointer++;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void ADDarr(ref User[] ListInput)
        {
            User[] UsersList2 = new User[ListInput.Length + 1];
            for (int i = 0; i < UsersList.Length; i++)
            {
                UsersList2[i] = UsersList[i];
            }
            ListInput = UsersList2;

        }


    }
}
