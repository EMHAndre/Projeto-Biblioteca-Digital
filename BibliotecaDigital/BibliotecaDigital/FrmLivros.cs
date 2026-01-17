using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BibliotecaDigital.DAL;

namespace BibliotecaDigital.Forms
{
    public partial class FrmLivros : Form
    {
        public FrmLivros()
        {
            InitializeComponent();
            ListarLivros(); // mostra os livros ao abrir
        }

        // ====================== MÉTODOS ======================
        private void ListarLivros()
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spListarLivros", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLivros.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spAdicionarLivro", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@AnoPublicacao", txtAno.Text);
                cmd.Parameters.AddWithValue("@Editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro adicionado com sucesso!");

                ListarLivros();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLivros.CurrentRow.Cells["IdLivro"].Value);

                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spAtualizarLivro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLivro", id);
                    cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@AnoPublicacao", txtAno.Text);
                    cmd.Parameters.AddWithValue("@Editora", txtEditora.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Livro atualizado com sucesso!");

                    ListarLivros();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvLivros.CurrentRow.Cells["IdLivro"].Value);

                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRemoverLivro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLivro", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Livro eliminado com sucesso!");

                    ListarLivros();
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarLivros();
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

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

