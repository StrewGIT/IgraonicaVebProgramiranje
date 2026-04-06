using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IgraonicaVebProgramiranje_StefanAndrejevic
{
    public class Konekcija
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["veza"].ConnectionString;

        private int ExecuteNonQueryWithReturn(string spName, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return (int)returnParameter.Value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in " + spName + ": " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        // --- KORISNIK ---

        public int ProveraKorisnika(string email, string lozinka)
        {
            SqlParameter[] p = {
            new SqlParameter("@email", email),
            new SqlParameter("@lozinka", lozinka)
        };
            return ExecuteNonQueryWithReturn("Provera_Korisnika", p);
        }

        public int UnosKorisnika(string ime, string email, string lozinka)
        {
            SqlParameter[] p = {
            new SqlParameter("@ime", ime),
            new SqlParameter("@email", email),
            new SqlParameter("@lozinka", lozinka)
        };
            return ExecuteNonQueryWithReturn("Unos_Korisnika", p);
        }

        public int BrisanjeKorisnika(string email)
        {
            SqlParameter[] p = { new SqlParameter("@email", email) };
            return ExecuteNonQueryWithReturn("Brisanje_Korisnika", p);
        }

        public int IzmenaKorisnika(string email, string lozinka)
        {
            SqlParameter[] p = {
            new SqlParameter("@email", email),
            new SqlParameter("@lozinka", lozinka)
        };
            return ExecuteNonQueryWithReturn("Izmena_Korisnika", p);
        }

        // --- TIP MESTA ---

        public int UnosTipaMesta(string naziv, int cena)
        {
            SqlParameter[] p = {
            new SqlParameter("@naziv", naziv),
            new SqlParameter("@cena", cena)
        };
            return ExecuteNonQueryWithReturn("Unos_TipaMesta", p);
        }

        public int BrisanjeTipaMesta(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            return ExecuteNonQueryWithReturn("Brisanje_TipaMesta", p);
        }

        public int IzmenaTipaMesta(int id, int cena)
        {
            SqlParameter[] p = {
            new SqlParameter("@id", id),
            new SqlParameter("@cena", cena)
        };
            return ExecuteNonQueryWithReturn("Izmena_TipaMesta", p);
        }

        // --- MESTO ---

        public int UnosMesta(int tip)
        {
            SqlParameter[] p = { new SqlParameter("@tip", tip) };
            return ExecuteNonQueryWithReturn("Unos_Mesta", p);
        }

        public int BrisanjeMesta(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            return ExecuteNonQueryWithReturn("Brisanje_Mesta", p);
        }

        // --- RADNI DAN ---

        public int UnosRadnogDana(DateTime datum, TimeSpan pocetak, TimeSpan kraj, TimeSpan duzina)
        {
            SqlParameter[] p = {
            new SqlParameter("@datum", SqlDbType.Date) { Value = datum },
            new SqlParameter("@pocetak", SqlDbType.Time) { Value = pocetak },
            new SqlParameter("@kraj", SqlDbType.Time) { Value = kraj },
            new SqlParameter("@duzina", SqlDbType.Time) { Value = duzina }
        };
            return ExecuteNonQueryWithReturn("Unos_RadnogDana", p);
        }

        public int BrisanjeRadnogDana(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            return ExecuteNonQueryWithReturn("Brisanje_RadnogDana", p);
        }

        public int IzmenaRadnogDana(int id, TimeSpan pocetak, TimeSpan kraj, TimeSpan duzina)
        {
            SqlParameter[] p = {
            new SqlParameter("@id", id),
            new SqlParameter("@pocetak", SqlDbType.Time) { Value = pocetak },
            new SqlParameter("@kraj", SqlDbType.Time) { Value = kraj },
            new SqlParameter("@duzina", SqlDbType.Time) { Value = duzina }
        };
            return ExecuteNonQueryWithReturn("Izmena_RadnogDana", p);
        }

        // --- REZERVACIJA ---

        public int GenerisiTermineZaMesto(int radniDanId, int mestoId)
        {
            SqlParameter[] p = {
            new SqlParameter("@radni_dan_id", radniDanId),
            new SqlParameter("@mesto_id", mestoId)
        };
            return ExecuteNonQueryWithReturn("generisi_termine_za_dan", p);
        }

        public int UnosRezervacije(int korisnikId, int radniDanId, TimeSpan pocetak, TimeSpan kraj, int mestoId)
        {
            SqlParameter[] p = {
            new SqlParameter("@korisnik", korisnikId),
            new SqlParameter("@radnidan", radniDanId),
            new SqlParameter("@pocetak", SqlDbType.Time) { Value = pocetak },
            new SqlParameter("@kraj", SqlDbType.Time) { Value = kraj },
            new SqlParameter("@mesto", mestoId)
        };
            return ExecuteNonQueryWithReturn("Unos_Rezervacije", p);
        }

        public int IzmenaRezervacije(int id, int korisnikId, int radniDanId, TimeSpan pocetak, TimeSpan kraj, int mestoId)
        {
            SqlParameter[] p = {
            new SqlParameter("@id", id),
            new SqlParameter("@korisnik", korisnikId),
            new SqlParameter("@radnidan", radniDanId),
            new SqlParameter("@pocetak", SqlDbType.Time) { Value = pocetak },
            new SqlParameter("@kraj", SqlDbType.Time) { Value = kraj },
            new SqlParameter("@mesto", mestoId)
        };
            return ExecuteNonQueryWithReturn("Izmena_Rezervacije", p);
        }

        public int BrisanjeRezervacije(int id)
        {
            SqlParameter[] p = { new SqlParameter("@id", id) };
            return ExecuteNonQueryWithReturn("Brisanje_Rezervacije", p);
        }
    }
}