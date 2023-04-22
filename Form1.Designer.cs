namespace _WF_keyboard_19_04_2021
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEng = new TextBox();
            textBoxRus = new TextBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonLoadFile = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBoxWords = new TextBox();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEng
            // 
            textBoxEng.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxEng.Location = new Point(13, 344);
            textBoxEng.Multiline = true;
            textBoxEng.Name = "textBoxEng";
            textBoxEng.Size = new Size(1047, 30);
            textBoxEng.TabIndex = 0;
            // 
            // textBoxRus
            // 
            textBoxRus.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxRus.Location = new Point(12, 308);
            textBoxRus.Multiline = true;
            textBoxRus.Name = "textBoxRus";
            textBoxRus.Size = new Size(1047, 30);
            textBoxRus.TabIndex = 1;
            textBoxRus.TextChanged += textBoxRus_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(871, 398);
            button1.Name = "button1";
            button1.Size = new Size(188, 26);
            button1.TabIndex = 2;
            button1.Text = "стереть  ввод пользователя";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.BackColor = Color.FromArgb(128, 255, 128);
            buttonLoadFile.Location = new Point(671, 398);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(186, 26);
            buttonLoadFile.TabIndex = 3;
            buttonLoadFile.Text = "загрузить файл слов";
            buttonLoadFile.UseVisualStyleBackColor = false;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 435);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1074, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(375, 21);
            toolStripStatusLabel1.Text = "для начала нажмите Enter или щелкните по форме";
            // 
            // textBoxWords
            // 
            textBoxWords.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxWords.Location = new Point(12, 12);
            textBoxWords.Name = "textBoxWords";
            textBoxWords.Size = new Size(1047, 26);
            textBoxWords.TabIndex = 5;
            textBoxWords.TextChanged += textBoxWords_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(405, 398);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 461);
            Controls.Add(label1);
            Controls.Add(textBoxWords);
            Controls.Add(statusStrip1);
            Controls.Add(buttonLoadFile);
            Controls.Add(button1);
            Controls.Add(textBoxRus);
            Controls.Add(textBoxEng);
            MaximumSize = new Size(2000, 500);
            MinimumSize = new Size(1090, 500);
            Name = "Form1";
            Text = "U-83";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEng;
        private TextBox textBoxRus;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonLoadFile;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBoxWords;
        private Label label1;
    }
}