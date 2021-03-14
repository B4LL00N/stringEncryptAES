using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AEStest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desObj = Aes.Create();
        }
        //global variables
            string cipherData;
            byte[] chipherBytes;
            byte[] plainBytes;
            byte[] plainBytes2;
            byte[] plainKey;

            SymmetricAlgorithm desObj;
        

        private void btENC_Click(object sender, EventArgs e)
        {
         //encryption
            cipherData = tbPlain.Text;
            plainBytes = Encoding.ASCII.GetBytes(cipherData);
            plainKey = Encoding.ASCII.GetBytes("abc1def2ghi3jkl4");
            desObj.Key = plainKey;
            //Choose another mode (CBC, CFB, CTS, ECB, OFB)
            desObj.Mode = CipherMode.CBC;
            desObj.Padding = PaddingMode.Zeros;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, desObj.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(plainBytes, 0, plainBytes.Length);
            cs.Close();
            chipherBytes = ms.ToArray();
            ms.Close();
            tbENC.Text = Encoding.ASCII.GetString(chipherBytes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            var helpForm = new Form2();
            helpForm.Show();
        }

        private void boxChecker_Tick(object sender, EventArgs e)
        {

        }

        private void btDEC_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream(chipherBytes);
            CryptoStream cs1 = new CryptoStream(ms1, desObj.CreateDecryptor(), CryptoStreamMode.Read);
            cs1.Read(chipherBytes, 0, chipherBytes.Length);
            plainBytes2 = ms1.ToArray();
            cs1.Close();
            ms1.Close();

            tbDEC.Text = Encoding.ASCII.GetString(plainBytes2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDEC.Text = "";
            tbENC.Text = "";
            tbPlain.Text = "";
        }
    }
}
