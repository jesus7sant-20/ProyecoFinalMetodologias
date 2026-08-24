namespace ProyectoFinalMetodologias
{
    public partial class Login : Form
    {
        //Instanciamos la clase cLogicaLogin para poder usar sus metodos
        cLogicaLogin login = new cLogicaLogin(); 

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                //mostramos mensaje de advertencia si hay campos vacíos
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //detenemos la ejecución del método si hay campos vacíos
            }

            //Ahora tomamos los datos de los campos Instanciando la clase de modelo de login
            cModeloLogin datos = new cModeloLogin();
            datos.Username = txtUsername.Text;
            datos.Password = txtPassword.Text;

            string rol = login.ValidarAcceso(datos); //llamamos al metodo ValidarLogin de la clase cLogicaLogin y le pasamos los datos del modelo

            //Validamos el rol del usuarios
            if (rol != "")
            {
                //Instanciamos la ventana principal
                DashBoard ventana = new DashBoard(rol, this);
                //Escondemos el login
                this.Hide();
                //Mostramos la ventana Principal
                ventana.Show();
            }

        }
    }
}
