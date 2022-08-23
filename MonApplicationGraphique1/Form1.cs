namespace MonApplicationGraphique1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {

            }
            else
            {
                MessageBox.Show("Voulez vouskjklldjlk !", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            //{

            //}
        }
    }
}