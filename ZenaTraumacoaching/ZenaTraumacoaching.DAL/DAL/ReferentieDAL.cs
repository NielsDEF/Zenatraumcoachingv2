using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;
using System.Data;
using System.Collections.Generic;

namespace ZenaTraumacoaching.DAL.DAL
{
    public class ReferentieDAL : Connection, IReferentieContainer, IReferentie
    {
        public ReferentieDAL()
        {

        }
        public void AddReferentieToDatabase(ReferentieDTO referentie)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "INSERT INTO [Referenties](ReferentieCijfer, ReferentieTekst) VALUES(@ReferentieCijfer, @ReferentieTekst)";
            cmd.Parameters.AddWithValue("@ReferentieCijfer", referentie.ReferentieCijfer);
            cmd.Parameters.AddWithValue("@ReferentieTekst", referentie.ReferentieTekst);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public List<ReferentieDTO> GetAllReferenties()
        {
            List<ReferentieDTO> blog = new List<ReferentieDTO>();
            SqlDataReader rdr;
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Referenties";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                blog.Add(new ReferentieDTO(
                    (int)rdr["ReferentieID"],
                    (string)rdr["ReferentieCijfer"],
                    (string)rdr["ReferentieTekst"]
                    )
                );
            }
            rdr.Close();
            cmd.Dispose();
            CloseConnection();
            return blog;
        }

        public void DeleteReferentieFromDatabase(int id)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "DELETE FROM [Referenties] WHERE ReferentieID = @ReferentieID";
            cmd.Parameters.AddWithValue("@BlogID", id);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
