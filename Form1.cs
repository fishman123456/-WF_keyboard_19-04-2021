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
        // ������ � �������� ���������
        private static string[] RKey = new string[] {  "�", "�", "�", "�", "�", "�", "�",
            "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "." };
        // ������ � ����������� ���������
        private static string[] EKey = new string[] {  "Q", "W", "E", "R", "T", "Y", "U",
            "I", "O", "P", "[", "]", "A", "S", "D", "F", "G", "H", "J", "K", "L", ";", "'", "Z", "X", "C", "V", "B", "N", "M", ",", ".", "/" };
        // ������ � DEC ��� ������� ��������� / �������� (�� ����� ������� ��� �����)
        private static int[] EKeyNum = new int[] {  81, 87, 69, 82, 84, 89, 85,
            73, 79, 80, 219, 221, 65, 83, 68, 70, 71, 72, 74, 75, 76, 186, 222, 90, 88, 67, 86, 66, 78, 77, 188, 190, 191 };

        public static Button[] ArrBut = new Button[35];
        public Button[] func_russ_big()
        {
            // �������� ������
            #region
            int y = 100, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 33; k++)
            {
                ArrBut[k] = new Button();
                ArrBut[k].Text = RKey[k]; // ���� ������� ���������
                ArrBut[k].Name = RKey[k]; // ������� �������, ����� ������� ���������� �� ����� 20-04-2023
                ArrBut[k].Location = new Point(x, y);
                ArrBut[k].Size = new Size(buttonWidth, buttonHeight);
                ArrBut[k].BackColor = Color.WhiteSmoke;
                this.Controls.Add(ArrBut[k]);
                ArrBut[k].Click += butt_click;

                if ((k + 1) % 12 == 0)
                {
                    x = 50;
                    y += buttonHeight + 2;
                }
                else
                    x += buttonWidth + 2;
            }
            #endregion
            return ArrBut;
        }


        // ������� �� ������ � ����� ������
        void butt_click(object sender, EventArgs e)
        {
            // MessageBox.Show("�� ������" + sender);
            textBox2.Text += (((System.Windows.Forms.ButtonBase)sender).Text);
        }
        // ����������� ������� ������ ����������
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                for (int k = 0; k < 35; k++)
                {

                    if (e.KeyValue == (char)EKeyNum[k])
                    {
                        ArrBut[k].PerformClick();
                        ArrBut[k].BackColor = Color.Red;
                        //MessageBox.Show(e.KeyValue.ToString());
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ������� ������� ���������
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            for (int k = 0; k < 33; k++)
            {
                ArrBut[k].BackColor = Color.WhiteSmoke;
            }
                
            
        }
    }
}