using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;
using System.Data;
using System.Collections.Generic;
using System;

namespace ZenaTraumacoaching.DAL.DAL
{
    public class ReferentieDAL : Connection, IReferentieContainer
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
            List<ReferentieDTO> referentie = new List<ReferentieDTO>();
            SqlDataReader rdr;
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Referenties";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                referentie.Add(new ReferentieDTO(
                    (int)rdr["ReferentieID"],
                    (int)(rdr["ReferentieCijfer"]),
                    (string)rdr["ReferentieTekst"]
                    )
                );
            }
            rdr.Close();
            cmd.Dispose();
            CloseConnection();
            return referentie;
        }

        public void DeleteReferentieFromDatabase(int referentiepostid)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "DELETE FROM [Referenties] WHERE ReferentieID = @ReferentieID";
            cmd.Parameters.AddWithValue("@ReferentieID", referentiepostid);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void ReferentieUpdate(ReferentieDTO referentie)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "UPDATE [Referenties] SET ReferentieCijfer=@ReferentieCijfer, ReferentieTekst=@ReferentieTekst WHERE ReferentieID = @ReferentieID";
            cmd.Parameters.AddWithValue("@ReferentieID", referentie.ReferentieID);
            cmd.Parameters.AddWithValue("@ReferentieCijfer", referentie.ReferentieCijfer);
            cmd.Parameters.AddWithValue("@ReferentieTekst", referentie.ReferentieTekst);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public ReferentieDTO GetReferentie(int referentiepostid)
        {
            int referentiecijfer = 0;
            string referentietekst = null;
            SqlDataReader rdr;
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT ReferentieCijfer, ReferentieTekst FROM [Referenties] WHERE ReferentieID = @ReferentieID";
            cmd.Parameters.AddWithValue("@ReferentieID", referentiepostid);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                referentiecijfer = (int)rdr["ReferentieCijfer"];
                referentietekst = (string)rdr["ReferentieTekst"];
            }
            rdr.Close();
            cmd.Dispose();
            CloseConnection();
            return new ReferentieDTO(referentiepostid, referentiecijfer, referentietekst);
        }
    }
}
