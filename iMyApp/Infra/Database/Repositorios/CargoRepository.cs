using Database.Conexoes;
using Negocio.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Database.Repositorios
{
    /// <summary>
    /// <c>CargoRepository</c> - Executa comandos SQL (CRUD) na tabela de [dbo].[cargo]
    /// <example>Exemplo:
    ///     var repositorio = new CargoRepository();
    /// </example>
    /// </summary>
    public class CargoRepository
    {
        /// <summary>
        /// Insere um novo registro na tabela Cargo
        /// <example>Exemplo:
        /// <code>
        ///     var cargorepositorio = new CargoRepository();
        ///     var cargo = new cargo ("Nome", "Status");
        ///     var resultado = cargoRepositorio.Inserir(cargo);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="cargo">Entidade ->Cargo</param>
        /// <returns>true ou false</returns>
        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
                            ([Nome]
                            ,[Status]
                            ,[CriadoEm]
                            ,[CriadoPor]
                            ,[AlteradoEm]
                            ,[AlteradoPor])
                        VALUES
                            (@nome, 
                            @status, 
                            @criadoEm, 
                            @criadoPor, 
                            @alteradoEm, 
                            @alteradoPor)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }


            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public bool Atualizar(Cargo cargo)
        {

            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Nome", cargo.Nome);                                        

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(int cargoId)
        {

            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObterTodos()
        {

            try
            {
                var sql = @"SELECT * from cargo";

                SqlDataAdapter dataAdapter = null;
                var dataTable = new DataTable();
                try
                {
                    using (var connection = new SqlConnection(SqlServer.StrConexao()))
                    {
                        var cmd = connection.CreateCommand();
                        
                        cmd.CommandText = sql;

                        dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
