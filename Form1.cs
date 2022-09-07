namespace _3._9_Objekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbly_Click(object sender, EventArgs e)
        {

        }

        private void btnFlytta_Click(object sender, EventArgs e)
        {
            int xKor = int.Parse(tbxX.Text);
            int yKor = int.Parse(tbxY.Text);

            Point newPosition = new Point(xKor, yKor);
            btnFlytta.Location= newPosition;
        }

        private void tbxX_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(tbxX);
        }

        private void tbxY_TextChanged_1(object sender, EventArgs e)
        {
            ValidateInput(tbxY);
        }

        private void ValidateInput(TextBox txtBoxToValidate)
        {
            try
            {
                // Convert the text to a Double and determine if it is a negative number.
                if (int.Parse(txtBoxToValidate.Text) < 0)
                {
                    // If the number is negative, display it in Red.
                    txtBoxToValidate.Text = String.Empty;
                }
                else
                {
                    // If the number is not negative, display it in Black.
                    txtBoxToValidate.ForeColor = Color.Black;
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                txtBoxToValidate.Text = String.Empty;
            }

        }
    }
}