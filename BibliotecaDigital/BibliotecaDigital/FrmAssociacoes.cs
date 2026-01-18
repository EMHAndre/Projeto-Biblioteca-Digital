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
using System.IO;

namespace BibliotecaDigital
{
    public partial class FrmAssociacoes : Form
    {
        public FrmAssociacoes()
        {
            InitializeComponent();
        }

        // ====================== MÉTODOS ======================
        private void CarregarLivros()
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdLivro, Titulo FROM Livro", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbLivros.DisplayMember = "Titulo";
                cmbLivros.ValueMember = "IdLivro";
                cmbLivros.DataSource = dt;
            }
        }

        private void CarregarAutores()
        {
            using (SqlConnection con = Conexao.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdAutor, Nome FROM Autor", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbAutores.DisplayMember = "Nome";
                cmbAutores.ValueMember = "IdAutor";
                cmbAutores.DataSource = dt;
            }
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            if (cmbLivros.SelectedValue != null && cmbAutores.SelectedValue != null)
            {
                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spAssociarLivroAutor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLivro", cmbLivros.SelectedValue);
                    cmd.Parameters.AddWithValue("@IdAutor", cmbAutores.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Associação criada!");

                    File.AppendAllText(
                    @"Ficheiros\associacoes.txt",
                    $"{cmbLivros.Text};{cmbAutores.Text}{Environment.NewLine}"
);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cmbLivros.SelectedValue != null && cmbAutores.SelectedValue != null)
            {
                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRemoverLivroAutor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLivro", cmbLivros.SelectedValue);
                    cmd.Parameters.AddWithValue("@IdAutor", cmbAutores.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Associação removida!");
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbAutores.SelectedValue != null)
            {
                using (SqlConnection con = Conexao.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("spListarLivrosPorAutor", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAutor", cmbAutores.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAssociacoes.DataSource = dt;
                }
            }
        }

        private void dgvAssociacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
