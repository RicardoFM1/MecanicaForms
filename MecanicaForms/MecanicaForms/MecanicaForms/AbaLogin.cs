using Mecanica.Database;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing.Text;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MecanicaForms
{
    public partial class AbaLogin : Form
    {
        public AbaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = InputEmail.Text.Trim();
            string senha = InputSenha.Text.Trim();

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Necessário preencher email e senha");
                return;
            }
                
                try
            {
              
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"SELECT COUNT(*) FROM usuarios WHERE email = @email AND senha = @senha";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                       



                        if (count > 0)
                        {
                            
                            DialogResult resultado = MessageBox.Show("Login realizado com sucesso!", 
                             "Autenticado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            if (resultado == DialogResult.OK)
                            {
                                Home home = new Home();
                                home.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar o login: " + ex.Message);
            }
        }
    }
}
