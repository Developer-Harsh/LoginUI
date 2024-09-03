namespace LoginUI
{
    public partial class Login : Form
    {
        String email = "";
        String pass = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email == "")
            {
                label3.Text = "Please enter your email!";
            }
            else if (pass == "")
            {
                label3.Text = "Please enter your password!";
            }
            else
            {
                label3.Text = "Your data is: " + email + " : " + pass;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }
    }
}
