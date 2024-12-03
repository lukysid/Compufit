using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compufit
{
     class CadastroFuncionarios
    {
        
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Senha { get; set; }

        
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";

        
        public bool Gravar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                    INSERT INTO Funcionarios 
                    (Nome, RG, CPF, DataNascimento, Cargo, Email, Telefone, Celular, CEP, Endereco, Numero, Cidade, Estado, Senha)
                    VALUES 
                    (@Nome, @RG, @CPF, @DataNascimento, @Cargo, @Email, @Telefone, @Celular, @CEP, @Endereco, @Numero, @Cidade, @Estado, @Senha)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@RG", RG);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Cargo", Cargo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Celular", Celular);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@Numero", Numero);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true; 
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Erro ao gravar funcionário: {ex.Message}");
                    return false;
                }
            }
        }

      
        public bool Atualizar(int matricula)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
            UPDATE Funcionarios SET
                Nome = @Nome, 
                RG = @RG, 
                CPF = @CPF, 
                DataNascimento = @DataNascimento,
                Cargo = @Cargo, 
                Email = @Email, 
                Telefone = @Telefone, 
                Celular = @Celular,
                CEP = @CEP, 
                Endereco = @Endereco, 
                Numero = @Numero, 
                Cidade = @Cidade, 
                Estado = @Estado, 
                Senha = @Senha
            WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@RG", RG);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@Cargo", Cargo);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Celular", Celular);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@Endereco", Endereco);
                    cmd.Parameters.AddWithValue("@Numero", Numero);
                    cmd.Parameters.AddWithValue("@Cidade", Cidade);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@Senha", Senha);
                    cmd.Parameters.AddWithValue("@Matricula", matricula);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao atualizar funcionário: {ex.Message}");
                    return false;
                }
            }
        }

        public bool Deletar(int matricula)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Funcionarios WHERE Matricula = @Matricula";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Matricula", matricula);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao deletar funcionário: {ex.Message}");
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
                    string query = "SELECT * FROM Funcionarios";

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
        public bool Autenticar(string nome, string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                SELECT COUNT(*) 
                FROM Funcionarios 
                WHERE Nome = @Nome AND Senha = @Senha";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();

                    
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao autenticar funcionário: {ex.Message}");
                    return false;
                }
            }
        }
    }

}
