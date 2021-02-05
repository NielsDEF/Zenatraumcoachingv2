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
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Referenties](ReferentieCijfer, ReferentieTekst) VALUES(@ReferentieCijfer, @ReferentieTekst)";
                cmd.Parameters.AddWithValue("@ReferentieCijfer", referentie.ReferentieCijfer);
                cmd.Parameters.AddWithValue("@ReferentieTekst", referentie.ReferentieTekst);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("De referentie kan niet in de database worden opgeslagen", ex);
            }
            CloseConnection();
        }

        public List<ReferentieDTO> GetAllReferenties()
        {
            List<ReferentieDTO> referentie = new List<ReferentieDTO>();
            SqlDataReader rdr;
            StartConnection();
            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er zijn geen referenties opgehaald", ex);
            }
            CloseConnection();
            return referentie;
        }

        public void DeleteReferentieFromDatabase(int referentiepostid)
        {
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "DELETE FROM [Referenties] WHERE ReferentieID = @ReferentieID";
                cmd.Parameters.AddWithValue("@ReferentieID", referentiepostid);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er kan niks Verwijderd worden", ex);
            }
            CloseConnection();
        }
        public void ReferentieUpdate(ReferentieDTO referentie)
        {
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "UPDATE [Referenties] SET ReferentieCijfer=@ReferentieCijfer, ReferentieTekst=@ReferentieTekst WHERE ReferentieID = @ReferentieID";
                cmd.Parameters.AddWithValue("@ReferentieID", referentie.ReferentieID);
                cmd.Parameters.AddWithValue("@ReferentieCijfer", referentie.ReferentieCijfer);
                cmd.Parameters.AddWithValue("@ReferentieTekst", referentie.ReferentieTekst);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("De Referentie kan niet Geupdate worden", ex);
            }
            CloseConnection();
        }
        public ReferentieDTO GetReferentie(int referentiepostid)
        {
            int referentiecijfer = 0;
            string referentietekst = null;
            SqlDataReader rdr;
            StartConnection();
            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er is geen Referentie gevonden", ex);
            }
            CloseConnection();
            return new ReferentieDTO(referentiepostid, referentiecijfer, referentietekst);
        }
    }
}
