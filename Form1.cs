using System.Windows.Forms;
using System;
using System.Drawing.Text;

namespace _WF_keyboard_19_04_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func_russ_big();

        }
        private static string[] RKey = new string[] { "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�",
            "�", "�", "�", "�", "�", "�", "�", "�", " ", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "." };
        private static string[] EKey = new string[] { "A", "S", "D", "F", "Q", "W", "E", "R", "T", "Y", "U",
            "I", "O", "P", "[", "]", "G", "H", "J", "Space", "K", "L", ";", "'", "`", "Z", "X", "C", "V", "B", "N", "M", ",", ".", "/" };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Button[] but = new Button[48];
        string[] butnamestr = new string[1500];
        char[] butname = new char[1500];
        public Button[] func_russ_small()
        {
            // ������ ������ � ������ �� �������
            #region

            for (int i = 1040; i < 1106; i++) // 1072-1103 �������� �������  1040-1071 ��������� �������
            {
                butname[i] = Convert.ToChar(i);
                butnamestr[i] = butname[i].ToString();
            }
            // ���� ������ �� ������ ��������� ���������
            foreach (string st in butnamestr)
            {
                if (st != null)
                {
                    textBox1.Text += "\t";
                    textBox1.Text += st;
                }
            }
            #endregion

            // �������� ������
            #region
            int y = 100, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 48; k++)
            {
                but[k] = new Button();
                but[k].Text = butnamestr[1072 + k]; // ���� ������� ���������
                but[k].Name = butnamestr[1072 + k]; // ������� �������, ����� ������� ���������� �� ����� 20-04-2023
                but[k].Location = new Point(x, y);
                but[k].Size = new Size(buttonWidth, buttonHeight);
                this.Controls.Add(but[k]);
                but[k].Click += butt_click;
                if ((k + 1) % 12 == 0)
                {
                    x = 50;
                    y += buttonHeight + 2;
                }
                else
                    x += buttonWidth + 2;
            }

            #endregion
            return but;
        }
        public Button[] func_russ_big()
        {
            // ������ ������ � ������ �� �������
            #region

            for (int i = 1040; i < 1106; i++) // 1072-1103 �������� �������  1040-1071 ��������� �������
            {
                butname[i] = Convert.ToChar(i);
                butnamestr[i] = butname[i].ToString();
            }
            // ���� ������ �� ������ ��������� ���������
            foreach (string st in butnamestr)
            {
                if (st != null)
                {
                    textBox1.Text += "\t";
                    textBox1.Text += st;
                }
            }
            #endregion

            // �������� ������
            #region
            int y = 100, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 32; k++)
            {
                but[k] = new Button();
                but[k].Text = butnamestr[1040 + k]; // ���� ������� ���������
                but[k].Name = butnamestr[1040 + k]; // ������� �������, ����� ������� ���������� �� ����� 20-04-2023
                but[k].Location = new Point(x, y);
                but[k].Size = new Size(buttonWidth, buttonHeight);
                this.Controls.Add(but[k]);
                but[k].Click += butt_click;
                
                if ((k + 1) % 12 == 0)
                {
                    x = 50;
                    y += buttonHeight + 2;
                }
                else
                    x += buttonWidth + 2;
            }

            #endregion
            return but;
        }

        private void Form1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // ���������� ������� ������� �� ������ ������, � ������ ���� � ���������� 21-04-2023 00-55
        void butt_click(object sender, EventArgs e)
        {
            // MessageBox.Show("�� ������" + sender);
            textBox2.Text += (((System.Windows.Forms.ButtonBase)sender).Text);

        }
        // ������� ������� �������, �� ���������� ���� ������� ���������� � ��� � ������ �����������
        void KeybordKeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar)
            {
                case (char)70: // ������� �
                    but[0].PerformClick();
                    but[0].BackColor = Color.Red;
                    break;
                case (char)188:  // ������� �
                    but[1].PerformClick();
                    but[0].BackColor = Color.Green;
                    break;
                case (char)52:
                    but[2].PerformClick();
                    break;
                default: 
                    foreach(Control c in this.Controls)
                    {
                        c.BackColor = Color.White;
                    }
                   break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}