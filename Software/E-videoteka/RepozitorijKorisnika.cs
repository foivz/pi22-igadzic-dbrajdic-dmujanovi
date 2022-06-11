using System.Linq;

namespace E_videoteka
{
    public class RepozitorijKorisnika
    {
        public void DodajKorisnika(string ime, string prezime, string email, string username, string password)
        {
            using (var context = new PI2247_DBEntities2())
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
    }
}
