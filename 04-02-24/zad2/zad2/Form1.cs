namespace zad2


{
    public partial class Form1 : Form
    {
        List<Album> albums;
        Album? CurrentAlbum;
        int current;
        public void UpdateSong()
        {
            artist.Text = albums[current].artist;
            album.Text = albums[current].album;
            songsNumber.Text = albums[current].songsNumber.ToString();
            year.Text = albums[current].year.ToString();
            downloads.Text = albums[current].downloadNumber.ToString();
        }

        public Form1()
        {
            albums = new List<Album>();
            current = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            albums.AddRange(Album.ReadAll("C:\\Users\\jnowa\\source\\repos\\zad2\\zad2\\Resources\\Data.txt"));
            current = 0;
            UpdateSong();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                --current;
            }
            else
            {
                current = albums.Count - 1;
            }
            UpdateSong();
        }

        private void next_Click(object sender, EventArgs e)
        {

            if (current < albums.Count - 1)
            {
                ++current;
            }
            else
            {
                current = 0;
            }
            UpdateSong();
        }

        private void downloadbtn_Click(object sender, EventArgs e)
        {
            albums[current].downloadNumber += 1;
            downloads.Text = albums[current].downloadNumber.ToString();
        }
    }
}
