using Database.Conexoes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public int Inserir(Cargo cargo) 
        {
            var stringConexao = SqlServer.StrConexao();
            var sqlConnection = new SqlConnection(stringConexao);

            sqlConnection.Open();

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

            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome", cargo.NOME);
            cmd.Parameters.AddWithValue("@status", cargo.STATUS);
            cmd.Parameters.AddWithValue("@criadoEm", cargo.CRIADOEM);
            cmd.Parameters.AddWithValue("@criadoPor", cargo.CRIADOPOR);
            cmd.Parameters.AddWithValue("@alteradoEm", cargo.ALTERADOEM);
            cmd.Parameters.AddWithValue("@alteradoPor", cargo.ALTERADOPOR);


            sqlConnection.Close();
        }
    }
}
