using System.Windows.Forms;
using System;

namespace _WF_keyboard_19_04_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func_russ_big();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}