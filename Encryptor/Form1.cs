using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algo.SelectedIndex == 0)
            {
                Comborot.Visible = true;
                caesarot.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void enbutton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string temp;
                result.Clear();
                for (int x = 0; x < 26; x++)
                {
                    temp = string.Empty;
                    for (int i = 0; i < Para.Text.Length; i++)
                    {
                        if ((int)Para.Text.ToLower()[i] + x > 122)
                        {
                            temp += (char)(((Para.Text.ToLower()[i] - 122) + 96) + x);
                        }
                        else
                        {
                            temp += (char)(Para.Text.ToLower()[i] + x);
                        }
                    }
                    result.Text += (temp + "\r\n");
                }
            }
            else
            {
                string temp = string.Empty;
                if (Para.Text != string.Empty && algo.Text != string.Empty && Comborot.Text != string.Empty)
                {
                    for (int i = 0; i < Para.Text.Length; i++)
                    {
                        if ((int)Para.Text.ToLower()[i] + int.Parse(Comborot.Text) > 122)
                        {
                            temp += (char)(((Para.Text.ToLower()[i] - 122) + 96) + int.Parse(Comborot.Text));
                        }
                        else
                        {
                            temp += (char)(Para.Text.ToLower()[i] + int.Parse(Comborot.Text));
                        }
                    }
                    result.Text = temp;
                }
            }

        }

        private void debutton_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                WebClient webServer = new WebClient();
    
                string temp;
                result.Clear();
                for (int x = 0; x < 26; x++)
                {
                    temp = string.Empty;
                    for (int i = 0; i < Para.Text.Length; i++)
                    {

                        if ((int)Para.Text[i] < 97)
                        {
                            temp += (char)((int)Para.Text[i] - x);
                            continue;
                        }
                        if ((int)Para.Text[i] - x < 97)
                        {
                            temp += (char)(((Para.Text[i] - 96) + 122) - x);
                        }
                        else
                        {
                            temp += (char)(Para.Text[i] - x);
                        }
                    }

                    bool found = false;
                    foreach(string word in temp.Split(' '))
                    {
                        try
                        {
                            string webResult = webServer.DownloadString(String.Format(@"http://words.bighugelabs.com/api/2/396656aeb4b11b692389f9c752ee4634/{0}/", word));

                            if (webResult.Length > 0)
                            {
                                found = true;
                                break;
                            }
                        }
                        catch
                        {

                        }
                    }

                    if(found)
                    {
                        result.Text += (temp + "\r\n");
                    }
                    

                }
            }
            else
            {
                string temp = string.Empty;
                if (Para.Text != string.Empty && algo.Text != string.Empty && Comborot.Text != string.Empty)
                {
                    for (int i = 0; i < Para.Text.Length; i++)
                    {
                        if ((int)Para.Text[i] < 97)
                        {
                            temp += (char)((int)Para.Text[i] - int.Parse(Comborot.Text));
                            continue;
                        }

                        if ((int)Para.Text[i] - int.Parse(Comborot.Text) < 97)
                        {
                            temp += (char)(((Para.Text[i] - 96) + 122) - int.Parse(Comborot.Text));
                        }
                        else
                        {
                            temp += (char)(Para.Text[i] - int.Parse(Comborot.Text));
                        }
                    }
                    result.Text = temp;
                }
            }
            MessageBox.Show("The Decryption Process was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                caesarot.Enabled = false;
                Comborot.Enabled = false;
            }
            else
            {
                caesarot.Enabled = true;
                Comborot.Enabled = true;
            }
        }
    }
}
