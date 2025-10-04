namespace WinFormsApp1
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
            colorDisplay = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            bTrackBar = new TrackBar();
            gTrackBar = new TrackBar();
            rDisplay = new Label();
            gDisplay = new Label();
            bDisplay = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rTrackBar = new TrackBar();
            downloadBtn = new Button();
            smallDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)colorDisplay).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rTrackBar).BeginInit();
            SuspendLayout();
            // 
            // colorDisplay
            // 
            colorDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            colorDisplay.BackColor = Color.White;
            colorDisplay.Location = new Point(12, 12);
            colorDisplay.Name = "colorDisplay";
            colorDisplay.Size = new Size(776, 84);
            colorDisplay.TabIndex = 0;
            colorDisplay.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 1;
            label1.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(bTrackBar, 1, 2);
            tableLayoutPanel1.Controls.Add(gTrackBar, 1, 1);
            tableLayoutPanel1.Controls.Add(rDisplay, 2, 0);
            tableLayoutPanel1.Controls.Add(gDisplay, 2, 1);
            tableLayoutPanel1.Controls.Add(bDisplay, 2, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(rTrackBar, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 142);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(776, 177);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // bTrackBar
            // 
            bTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bTrackBar.Location = new Point(41, 125);
            bTrackBar.Maximum = 255;
            bTrackBar.Name = "bTrackBar";
            bTrackBar.Size = new Size(692, 45);
            bTrackBar.TabIndex = 8;
            bTrackBar.Value = 255;
            bTrackBar.Scroll += bTrackBar_Scroll;
            // 
            // gTrackBar
            // 
            gTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gTrackBar.Location = new Point(41, 66);
            gTrackBar.Maximum = 255;
            gTrackBar.Name = "gTrackBar";
            gTrackBar.Size = new Size(692, 45);
            gTrackBar.TabIndex = 7;
            gTrackBar.Value = 255;
            gTrackBar.Scroll += gTrackBar_Scroll;
            // 
            // rDisplay
            // 
            rDisplay.AutoSize = true;
            rDisplay.Dock = DockStyle.Fill;
            rDisplay.Location = new Point(739, 0);
            rDisplay.Name = "rDisplay";
            rDisplay.Size = new Size(34, 59);
            rDisplay.TabIndex = 0;
            rDisplay.Text = "255";
            rDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gDisplay
            // 
            gDisplay.AutoSize = true;
            gDisplay.Dock = DockStyle.Fill;
            gDisplay.Location = new Point(739, 59);
            gDisplay.Name = "gDisplay";
            gDisplay.Size = new Size(34, 59);
            gDisplay.TabIndex = 1;
            gDisplay.Text = "255";
            gDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bDisplay
            // 
            bDisplay.AutoSize = true;
            bDisplay.Dock = DockStyle.Fill;
            bDisplay.Location = new Point(739, 118);
            bDisplay.Name = "bDisplay";
            bDisplay.Size = new Size(34, 59);
            bDisplay.TabIndex = 2;
            bDisplay.Text = "255";
            bDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 59);
            label5.TabIndex = 3;
            label5.Text = "R";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 59);
            label6.Name = "label6";
            label6.Size = new Size(32, 59);
            label6.TabIndex = 4;
            label6.Text = "G";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 118);
            label7.Name = "label7";
            label7.Size = new Size(32, 59);
            label7.TabIndex = 5;
            label7.Text = "B";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rTrackBar
            // 
            rTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rTrackBar.Location = new Point(41, 7);
            rTrackBar.Maximum = 255;
            rTrackBar.Name = "rTrackBar";
            rTrackBar.Size = new Size(692, 45);
            rTrackBar.TabIndex = 6;
            rTrackBar.Value = 255;
            rTrackBar.Scroll += rTrackBar_Scroll;
            // 
            // downloadBtn
            // 
            downloadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloadBtn.BackColor = Color.Peru;
            downloadBtn.Location = new Point(280, 334);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(240, 40);
            downloadBtn.TabIndex = 3;
            downloadBtn.Text = "Pobierz";
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // smallDisplay
            // 
            smallDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            smallDisplay.BackColor = Color.White;
            smallDisplay.Location = new Point(280, 377);
            smallDisplay.Name = "smallDisplay";
            smallDisplay.Size = new Size(240, 40);
            smallDisplay.TabIndex = 4;
            smallDisplay.Text = "255, 255, 255";
            smallDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(smallDisplay);
            Controls.Add(downloadBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(colorDisplay);
            Name = "Form1";
            Text = "Wzornik kolorów RGB. Wykonał: 00000000000";
            ((System.ComponentModel.ISupportInitialize)colorDisplay).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox colorDisplay;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label rDisplay;
        private Label gDisplay;
        private Label bDisplay;
        private Label label5;
        private Label label6;
        private Label label7;
        private TrackBar bTrackBar;
        private TrackBar gTrackBar;
        private TrackBar rTrackBar;
        private Button downloadBtn;
        private Label smallDisplay;
    }
}
