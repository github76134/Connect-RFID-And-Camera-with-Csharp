using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RFID
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }


        public const int SALT_SIZE = 24; // size in bytes
        public const int HASH_SIZE = 24; // size in bytes
        public const int ITERATIONS = 100000; // number of pbkdf2 iterations

        public static byte[] CreateHash(string input)
        {
            // Generate a salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return pbkdf2.GetBytes(HASH_SIZE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();

            byte[] ma = CreateHash("123456");
            string kk = Encoding.ASCII.GetString(ma);

            byte[]Nhap = CreateHash("123456");
            string manhap = Encoding.ASCII.GetString(Nhap);


            //if(kk == manhap)
                MessageBox.Show(kk + "-"+ manhap);
        }


    }
}
