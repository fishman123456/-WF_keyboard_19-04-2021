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
            func();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void func()
        {
            // запись клавиш в массив по юникоду
            #region
            Button[] but = new Button[48];
            string[] butnamestr = new string[1500];
            char[] butname = new char[1500];
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
            int y = 50, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;
            for (int k = 0; k < 48; k++)
            {
                but[k] = new Button();
                but[k].Text = butnamestr[1072 + k]; // пока русские прописные
                but[k].Name = butnamestr[1072 +k]; // именуем клавиши, потом сделаем обработчик по имени 20-04-2023
                but[k].Location = new Point(x, y);
                but[k].Size = new Size(buttonWidth, buttonHeight);
                this.Controls.Add(but[k]);
                if ((k + 1) % 12 == 0)
                {
                    x = 50;
                    y += buttonHeight + 2;
                }
                else
                    x += buttonWidth + 2;
            }
            #endregion
        }
    }

}