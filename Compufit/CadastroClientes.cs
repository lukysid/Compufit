using System;
using System.Data;
using System.Data.SqlClient;

namespace Compufit
{
    class CadastroClientes
    {
        
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";

        
        public bool Gravar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    INSERT INTO Clientes 
                    (Nome, RG, CPF, DataNascimento, Email, Telefone, Celular, CEP, Endereco, Numero, Cidade, Estado)
                    VALUES 
                    (@Nome, @RG, @CPF, @DataNascimento, @Email, @Telefone, @Celular, @CEP, @Endereco, @Numero, @Cidade, @Estado)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@RG", RG);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Celular", Celular);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@Numero", Numero);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao gravar cliente: {ex.Message}");
                    return false;
                }
            }
        }

        
        public bool Atualizar(int Matricula)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    UPDATE Clientes SET
                        Nome = @Nome, 
                        RG = @RG, 
                        CPF = @CPF, 
                        DataNascimento = @DataNascimento,
                        Email = @Email, 
                        Telefone = @Telefone, 
                        Celular = @Celular,
                        CEP = @CEP, 
                        Endereco = @Endereco, 
                        Numero = @Numero, 
                        Cidade = @Cidade, 
                        Estado = @Estado                        
                    WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@RG", RG);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Celular", Celular);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@Numero", Numero);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao atualizar cliente1: {ex.Message}");
                    return false;
                }
            }
        }

        
        public bool Deletar(int Matricula)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Clientes WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao deletar cliente: {ex.Message}");
                    return false;
                }
            }
        }

        
        public DataTable CarregarDados()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Clientes";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar os dados: {ex.Message}");
            }
        }

        public CadastroClientes PesquisarPorId(int Matricula)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Clientes WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new CadastroClientes
                        {
                            Nome = reader["Nome"].ToString(),
                            RG = reader["RG"].ToString(),
                            CPF = reader["CPF"].ToString(),
                            DataNascimento = reader["DataNascimento"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Celular = reader["Celular"].ToString(),
                            CEP = reader["CEP"].ToString(),
                            Endereco = reader["Endereco"].ToString(),
                            Numero = reader["Numero"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Estado = reader["Estado"].ToString()
                        };
                    }
                    else
                    {
                        return null; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar cliente pelo ID: {ex.Message}");
            }
        }
    }
}
