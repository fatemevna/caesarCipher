using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher2
{   
    public partial class Form1 : Form
    {
        int key = 3;
        public static char cipher(char ch,int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
        public Form1()
        {
            InitializeComponent();
            cbChoice.Items.Add("Encode");
            cbChoice.Items.Add("Decode");
            cbChoice.SelectedIndex = 0;

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0) 
            {
                tbEncrypted.Text = Encipher(tbDecrypted.Text, key);
                 
            }
            else
            {
                tbEncrypted.Text = Decipher(tbDecrypted.Text, key);
            }
        }
    }
}
