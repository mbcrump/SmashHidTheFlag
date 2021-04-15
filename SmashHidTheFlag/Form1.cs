using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashHidTheFlag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCheckUnPw_Click(object sender, EventArgs e)
        {


            if (this.txtUsername.Text == "RaMBo")
            {
                string pwField = EncryptDecrypt(txtPassword.Text, 7);

                if (pwField == "trwbuXtbdubsXwfttphuc")
                {
                    MessageBox.Show(("The flag is :" + EncryptDecrypt("JEDXTJFTO|^HRX@HSXSOBXAKF@X4z", 7)));
                }
                else
                {
                    MessageBox.Show(("Correct Username but WRONG password!"));
                }
            }
            else
            {
                MessageBox.Show(("Incorrect Username! Try Again!"));
            }
        }

        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
    }
}
