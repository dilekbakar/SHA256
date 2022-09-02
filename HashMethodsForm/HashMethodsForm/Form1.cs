using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashMethodsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtPlainText.Text;
            lblEncypt.Text=($"şifrelenmiş metin: {Encrypt.ToSHA256(input)}");
        }

     
    }
}
