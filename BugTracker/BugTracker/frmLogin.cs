namespace BugTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }
            
            //Validamos que se haya ingresado un usuario
            if ((txtContrasena.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contrasena.");
                return;
            }

            MessageBox.Show("Usted a ingresado al sistema");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}