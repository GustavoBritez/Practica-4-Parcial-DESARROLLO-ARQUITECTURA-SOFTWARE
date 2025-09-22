using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Practica_4
{
    public class Access
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=LOPO;Integrated Security=True;Trust Server Certificate=True");
        private SqlTransaction transaction;

        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }
        public void Start_TX()
        {
            transaction = conn.BeginTransaction();
        }
        public void Stop_TX()
        {
            transaction.Rollback();
        }
        public void Commit_TX()
        {
            transaction.Commit();
        }

        public void Escribir( string Query , SqlParameter[] sp )
        {
            try
            {
                int resultado;
                Open();
                using ( SqlCommand cmd = new SqlCommand( Query , conn) )
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if ( sp is not null)
                        cmd.Parameters.AddRange( sp );

                    Start_TX();
                    cmd.Transaction = transaction;  
                    resultado = cmd.ExecuteNonQuery();
                    Commit_TX();
                }
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public DataTable Leer( string query, SqlParameter[] sp )
        {
            DataTable dt = new();
            try
            {
                Open();
                using (SqlCommand cmd = new(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if ( sp is not null )
                        cmd.Parameters.AddRange( sp );

                    using ( SqlDataAdapter adapter = new(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            { Close(); }
        }

    }
}
