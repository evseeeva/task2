using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task2window
{
    public partial class CaesarCipherForm : Form
    {
        static string alfphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        static string lowAlfphabet = alfphabet.ToLower();
        string text = File.ReadAllText("input.txt");
        public CaesarCipherForm()
        {
            InitializeComponent();
            CenterToScreen();
            initialTextBox.Text = text;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int key = 0;
            if (!passwordInput.Text.Equals("") && !keyInput.Text.Equals(""))
            {
                string inputPassword = passwordInput.Text;
                 key = Convert.ToInt32(keyInput.Text);
                string password = "qwer12";
               
                if (password.Equals(inputPassword)) flag = true;
                else
                {
                     MessageBox.Show("Неверный пароль");
                }
            }
            else MessageBox.Show("Данные не введены");
            if (flag)
            {
                  text = initialTextBox.Text;
                  string encodedText = encode(text, key);
                  File.WriteAllText("input.txt", text);
                  encodedTextBox.Text = encodedText;
                  File.WriteAllText("output.txt", encodedText);
               
            }
        }
        private string encode(string text, int key)
        {
            int n = alfphabet.Length;
            string encodedText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int newIndex;

                if (alfphabet.IndexOf(c) >= 0)
                {
                    newIndex = (alfphabet.IndexOf(c) + key) % n;
                    encodedText += alfphabet[newIndex];
                }
                else if (lowAlfphabet.IndexOf(c) >= 0)
                {
                    newIndex = (lowAlfphabet.IndexOf(c) + key) % n;
                    encodedText += lowAlfphabet[newIndex];
                }
                else encodedText += c;

            }
            return encodedText;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
