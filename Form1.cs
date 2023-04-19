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
            Button[] but = new Button[48];

            int y = 50, x = 50;
            int buttonWidth = 80;
            int buttonHeight = 50;

            for (int k = 0; k < 48; k++)
            {
                but[k] = new Button();
                but[k].Text = (k + 1).ToString();
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
        }
    }
}