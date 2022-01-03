namespace LoginESenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
        }

        private void mudarTexto(object sender, EventArgs e)
        {
            btnEntrar.Enabled = txtUsuario.Text != "" && txtSenha.Text != "" ? true : false;

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!btnEntrar.Enabled) return;
            MessageBox.Show("Entrou,fera!");
        }
    }
}