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
        private static string[] RKey = new string[] { "Ф", "Ы", "В", "А", "Й", "Ц", "У", "К", "Е", "Н", "Г",
            "Ш", "Щ", "З", "Х", "Ъ", "П", "Р", "О", " ", "Л", "Д", "Ж", "Э", "Ё", "Я", "Ч", "С", "М", "И", "Т", "Ь", "Б", "Ю", "." };
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
            // запись клавиш в массив по юникоду
            #region

            for (int i = 1040; i < 1106; i++) // 1072-1103 строчные русские  1040-1071 прописные русские
            {
                butname[i] = Convert.ToChar(i);
                butnamestr[i] = butname[i].ToString();
            }
            // если строка не пустая заполняем текстбокс
            foreach (string st in butnamestr)
            {
                if (st != null)
                {
                    textBox1.Text += "\t";
                    textBox1.Text += st;
                }
            }
            #endregion

            // создание клавиш
            #region
            int y = 100, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 48; k++)
            {
                but[k] = new Button();
                but[k].Text = butnamestr[1072 + k]; // пока русские прописные
                but[k].Name = butnamestr[1072 + k]; // именуем клавиши, потом сделаем обработчик по имени 20-04-2023
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
            // запись клавиш в массив по юникоду
            #region

            for (int i = 1040; i < 1106; i++) // 1072-1103 строчные русские  1040-1071 прописные русские
            {
                butname[i] = Convert.ToChar(i);
                butnamestr[i] = butname[i].ToString();
            }
            // если строка не пустая заполняем текстбокс
            foreach (string st in butnamestr)
            {
                if (st != null)
                {
                    textBox1.Text += "\t";
                    textBox1.Text += st;
                }
            }
            #endregion

            // создание клавиш
            #region
            int y = 100, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 32; k++)
            {
                but[k] = new Button();
                but[k].Text = butnamestr[1040 + k]; // пока русские прописные
                but[k].Name = butnamestr[1040 + k]; // именуем клавиши, потом сделаем обработчик по имени 20-04-2023
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
        // обработчик события нажатия на кнопку мышкой, а дальше надо с клавиатуры 21-04-2023 00-55
        void butt_click(object sender, EventArgs e)
        {
            // MessageBox.Show("вы нажали" + sender);
            textBox2.Text += (((System.Windows.Forms.ButtonBase)sender).Text);

        }
        // функция нажатия клавиши, на клавиатуре надо вручную перебирать и ещё с языком разобраться
        void KeybordKeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar)
            {
                case (char)70: // русская а
                    but[0].PerformClick();
                    but[0].BackColor = Color.Red;
                    break;
                case (char)188:  // русская б
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