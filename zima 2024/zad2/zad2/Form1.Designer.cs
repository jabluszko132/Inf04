namespace zad2
{
    partial class MyForm
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            eyeColor = new GroupBox();
            brownRadio = new RadioButton();
            greenRadio = new RadioButton();
            blueRadio = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numberInput = new TextBox();
            nameInput = new TextBox();
            surnameInput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            personImg = new PictureBox();
            fingerprintImg = new PictureBox();
            okBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            eyeColor.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintImg).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 385;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(eyeColor, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(385, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // eyeColor
            // 
            eyeColor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eyeColor.Controls.Add(brownRadio);
            eyeColor.Controls.Add(greenRadio);
            eyeColor.Controls.Add(blueRadio);
            eyeColor.Location = new Point(3, 259);
            eyeColor.Name = "eyeColor";
            eyeColor.Padding = new Padding(20);
            eyeColor.Size = new Size(379, 157);
            eyeColor.TabIndex = 1;
            eyeColor.TabStop = false;
            eyeColor.Text = "Kolor oczu";
            // 
            // brownRadio
            // 
            brownRadio.AutoSize = true;
            brownRadio.Dock = DockStyle.Top;
            brownRadio.Location = new Point(20, 74);
            brownRadio.Margin = new Padding(10);
            brownRadio.Name = "brownRadio";
            brownRadio.Size = new Size(339, 19);
            brownRadio.TabIndex = 2;
            brownRadio.Text = "piwne";
            brownRadio.UseVisualStyleBackColor = true;
            // 
            // greenRadio
            // 
            greenRadio.AutoSize = true;
            greenRadio.Dock = DockStyle.Top;
            greenRadio.Location = new Point(20, 55);
            greenRadio.Margin = new Padding(10);
            greenRadio.Name = "greenRadio";
            greenRadio.Size = new Size(339, 19);
            greenRadio.TabIndex = 1;
            greenRadio.Text = "zielone";
            greenRadio.UseVisualStyleBackColor = true;
            // 
            // blueRadio
            // 
            blueRadio.AutoSize = true;
            blueRadio.Checked = true;
            blueRadio.Dock = DockStyle.Top;
            blueRadio.Location = new Point(20, 36);
            blueRadio.Margin = new Padding(10);
            blueRadio.Name = "blueRadio";
            blueRadio.Size = new Size(339, 19);
            blueRadio.TabIndex = 0;
            blueRadio.TabStop = true;
            blueRadio.Text = "niebieskie";
            blueRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(numberInput, 1, 0);
            tableLayoutPanel3.Controls.Add(nameInput, 1, 1);
            tableLayoutPanel3.Controls.Add(surnameInput, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(379, 219);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(53, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Numer";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(60, 100);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Imię";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(47, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Nazwisko";
            // 
            // numberInput
            // 
            numberInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numberInput.BackColor = Color.Azure;
            numberInput.Location = new Point(154, 24);
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(222, 23);
            numberInput.TabIndex = 3;
            numberInput.Leave += numberInput_Leave;
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameInput.BackColor = Color.Azure;
            nameInput.Location = new Point(154, 96);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(222, 23);
            nameInput.TabIndex = 4;
            // 
            // surnameInput
            // 
            surnameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameInput.BackColor = Color.Azure;
            surnameInput.Location = new Point(154, 170);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(222, 23);
            surnameInput.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(personImg, 0, 0);
            tableLayoutPanel2.Controls.Add(fingerprintImg, 1, 0);
            tableLayoutPanel2.Controls.Add(okBtn, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(411, 450);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // personImg
            // 
            personImg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            personImg.Image = Properties.Resources._000_zdjecie;
            personImg.Location = new Point(3, 65);
            personImg.Name = "personImg";
            personImg.Size = new Size(199, 230);
            personImg.SizeMode = PictureBoxSizeMode.StretchImage;
            personImg.TabIndex = 0;
            personImg.TabStop = false;
            // 
            // fingerprintImg
            // 
            fingerprintImg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fingerprintImg.Image = Properties.Resources._000_odcisk;
            fingerprintImg.Location = new Point(208, 65);
            fingerprintImg.Name = "fingerprintImg";
            fingerprintImg.Size = new Size(200, 230);
            fingerprintImg.SizeMode = PictureBoxSizeMode.StretchImage;
            fingerprintImg.TabIndex = 1;
            fingerprintImg.TabStop = false;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            okBtn.BackColor = Color.Azure;
            tableLayoutPanel2.SetColumnSpan(okBtn, 2);
            okBtn.Location = new Point(50, 393);
            okBtn.Margin = new Padding(50, 0, 50, 0);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(311, 23);
            okBtn.TabIndex = 2;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += okBtn_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MyForm";
            Text = "Wprowadzenie danych do paszportu. Wykonał 000000000000";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            eyeColor.ResumeLayout(false);
            eyeColor.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)personImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox eyeColor;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numberInput;
        private TextBox nameInput;
        private TextBox surnameInput;
        private RadioButton brownRadio;
        private RadioButton greenRadio;
        private RadioButton blueRadio;
        private PictureBox personImg;
        private PictureBox fingerprintImg;
        private Button okBtn;
    }
}
