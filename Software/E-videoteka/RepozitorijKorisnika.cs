using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ProvjeriPrijavu(string username, string password)
        {
            using(var context = new PI2247_DBEntities1())
            {
                var query = from p in context.Korisniks
                            where p.Username == username && p.Password == password
                            select p;
            }
        }
    }
}
