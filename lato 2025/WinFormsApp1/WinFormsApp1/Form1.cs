namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private void updateDisplayedColor(int r, int g, int b)
        {
            colorDisplay.BackColor = Color.FromArgb(r, g, b);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void rTrackBar_Scroll(object sender, EventArgs e)
        {
            rDisplay.Text = rTrackBar.Value.ToString();
            updateDisplayedColor(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }
        private void gTrackBar_Scroll(object sender, EventArgs e)
        {
            gDisplay.Text = gTrackBar.Value.ToString();
            updateDisplayedColor(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }
        private void bTrackBar_Scroll(object sender, EventArgs e)
        {
            bDisplay.Text = bTrackBar.Value.ToString();
            updateDisplayedColor(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            smallDisplay.BackColor = Color.FromArgb(rTrackBar.Value, gTrackBar.Value, bTrackBar.Value);
            smallDisplay.Text = $"{rTrackBar.Value}, {gTrackBar.Value}, {bTrackBar.Value}";
        }
    }
}
