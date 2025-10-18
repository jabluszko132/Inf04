using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public static string CaesarCypher(string txt, int key)
        {
            string res = "";
            int optimisedKey = key % 26;
            foreach (char c in txt)
            {
                if (c == ' ')
                {
                    res += ' ';
                }
                else if (c + optimisedKey < 'a')
                {
                    res += (char)('z' + 1 + optimisedKey + c - 'a');
                }
                else if (c + optimisedKey > 'z')
                {
                    res += (char)('a' - 1 + optimisedKey + c - 'z');
                }
                else
                {
                    res += (char)(c + optimisedKey);
                }
            }
            return res;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cypherBtn_Click(object sender, RoutedEventArgs e)
        {
            string keyStr = keyIn.Text, txt = txtIn.Text;

            if (keyStr == "" || txt == "")
            {
                MessageBox.Show("Proszę wprowadzić wszystkie wartości");
                return;
            }

            int key = int.TryParse(keyStr, out int x) ? int.Parse(keyStr) : 0;

            cypherRes.Content = CaesarCypher(txt, key);
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new();
            if (dialog.ShowDialog() ?? false)
            {
                File.WriteAllText(dialog.FileName, cypherRes.Content.ToString());
            }
        }
    }
}