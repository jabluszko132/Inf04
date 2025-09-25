using System.Drawing;
using zad2.Properties;

namespace zad2
{
    public partial class MyForm : Form
    {
        #region Constructors
        public MyForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Utils

        private bool validateForm()
        {
            return (
                numberInput.TextLength > 0 &&
                nameInput.TextLength > 0 &&
                surnameInput.TextLength > 0
                );
        }

        private string getEyeColor()
        {
            if (blueRadio.Checked)
            {
                return "niebieskie";
            }
            else if (greenRadio.Checked)
            {
                return "zielone";
            }
            else
            {
                return "piwne";
            }
        }

        #endregion

        #region Events

        private void numberInput_Leave(object sender, EventArgs e)
        {
            personImg.Image = (Image?)Properties.Resources.ResourceManager.GetObject(numberInput.Text + "-zdjecie");
            fingerprintImg.Image = (Image?)Properties.Resources.ResourceManager.GetObject(numberInput.Text + "-odcisk");
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                MessageBox.Show($"{nameInput.Text} {surnameInput.Text} kolor oczu {getEyeColor()}");
            }else
            {
                MessageBox.Show("Wprowadü dane");
            }
        }

        #endregion
    }
}
