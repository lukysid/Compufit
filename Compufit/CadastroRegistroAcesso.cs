using System;
using System.Data;
using System.Data.SqlClient;

namespace Compufit
{
    public class CadastroRegistroAcesso
    {
        
        public int Matricula { get; set; }
        public string Tipo { get; set; } 
        public DateTime DataHora { get; set; }

        
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";

        
        public bool Gravar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    INSERT INTO RegistroAcesso (Matricula, Tipo, DataHora)
                    VALUES (@Matricula, @Tipo, @DataHora)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);
                    cmd.Parameters.AddWithValue("@Tipo", Tipo);
                    cmd.Parameters.AddWithValue("@DataHora", DataHora);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao gravar movimentação: {ex.Message}");
                    return false;
                }
            }
        }


        
        public DataTable PesquisarPorMatricula(int matricula)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM RegistroAcesso WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricula", matricula);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    adapter.Fill(dataTable);

                    return dataTable; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar movimentação: {ex.Message}");
            }
        }
    }
}