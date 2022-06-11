namespace E_videoteka
{
    public class Autentifikator
    {
        public RepozitorijKorisnika repozitorij = new RepozitorijKorisnika();
        public void Registracija(string ime, string prezime, string email, string username, string password, string passwordrep)
        {
            ProvjeriLozinku(password, passwordrep);
            VerificirajRegistraciju(ime, prezime, email, username, password, passwordrep);
            repozitorij.DodajKorisnika(ime, prezime, email, username, password);
        }
        private void ProvjeriLozinku(string password, string passwordrep)
        {
            if (password != passwordrep)
            {
                throw new PasswordMissMatchException("Lozinke nisu iste");
            }
        }

        public void VerificirajRegistraciju(string ime, string prezime, string email, string username, string password, string passwordrep)
        {
            if (ime == "")
            {
                throw new InvalidInputException("Polje Ime ne može biti prazno");
            }
            if (prezime == "")
            {
                throw new InvalidInputException("Polje Prezime ne može biti prazno");
            }
            if (email == "")
            {
                throw new InvalidInputException("Polje E-mail ne može biti prazno");
            }
            if (username == "")
            {
                throw new InvalidInputException("Polje Username ne može biti prazno");
            }
            if (password == "")
            {
                throw new InvalidInputException("Polje Lozinka ne može biti prazno");
            }
            if (passwordrep == "")
            {
                throw new InvalidInputException("Polje Ponovljena lozinka ne može biti prazno");
            }
        }
        public bool ProvjeriPrijavu(string username, string password)
        {
            using (var context = new PI2247_DBEntities2())
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
                    System.Windows.Forms.MessageBox.Show("Krivo korisnicko ime ili lozinka.");
                    return false;
                }
            }
        }

        public void ProvjeraUloge()
        {
            using (var context = new PI2247_DBEntities2())
            {
                var query = from p in context.Korisnik
                            where p.Uloga == "Korisnik"
                            select p;
            }
        }
    }
}
