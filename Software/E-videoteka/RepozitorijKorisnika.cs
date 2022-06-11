using System.Linq;

namespace E_videoteka
{
    public class RepozitorijKorisnika
    {
        public void DodajKorisnika(string ime, string prezime, string email, string username, string password)
        {
            using (var context = new PI2247_DBEntities1())
            {
                Korisnik korisnik = new Korisnik
                {
                    ID_Korisnik = 10,
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Username = username,
                    Password = password,
                    Uloga = "Korisnik",
                };
                context.Korisniks.Add(korisnik);
                context.SaveChanges();
            }
        }

        public bool ProvjeriPrijavu(string username, string password)
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Username == username && p.Password == password
                            select p;

                if (query.Any())
                {
                    System.Windows.Forms.MessageBox.Show("Uspjesšno ste ulogirani.");
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Krivo korisničko ime ili lozinka.");
                    return false;
                }
            }
        }

        public bool ProvjeraKorisnik()
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Uloga == "Korisnik"
                            select p;
                if (query.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool ProvjeraAdmina()
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Uloga == "Admin"
                            select p;

                if (query.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool ProvjeraRecenzent()
        {
            using (var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Uloga == "Recenzent"
                            select p;

                if (query.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
