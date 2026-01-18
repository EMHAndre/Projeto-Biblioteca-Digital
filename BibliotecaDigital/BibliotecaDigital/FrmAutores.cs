using BibliotecaDigital.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDigital
{
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }
        private void ListarAutores()
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spListarAutores", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAutores.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spAdicionarAutor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Nacionalidade", txtNacionalidade.Text);
                cmd.Parameters.AddWithValue("@AnoNascimento", txtAnoNascimento.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Autor adicionado!");

                ListarAutores();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAutores.CurrentRow.Cells["IdAutor"].Value);

                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spAtualizarAutor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAutor", id);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Nacionalidade", txtNacionalidade.Text);
                    cmd.Parameters.AddWithValue("@AnoNascimento", txtAnoNascimento.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor atualizado!");

                    ListarAutores();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAutores.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvAutores.CurrentRow.Cells["IdAutor"].Value);

                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRemoverAutor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAutor", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor eliminado!");

                    ListarAutores();
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarAutores();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
