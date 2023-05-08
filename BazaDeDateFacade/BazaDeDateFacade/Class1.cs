using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazadeDate;

namespace BazaDeDateFacade
{
    public class BazaDeDateFacade
    {
        //variabilă pentru a folosi funcțiile din DLL-ul bazei de date
        private DB db;

        public BazaDeDateFacade()
        {
            //instașierea clasei pentru baza de date
            db = new DB();
        }

        public int Check(string mailAddress)
        {
            //verificarea mail
            return db.check(mailAddress);
        }

        public void AddInTable(string lastName, string firstName, string mailAddress, string password, string gender, string activity, string weight, string height, string age)
        {
            //introducerea datelor noului utilizator în baza de date
            db.AddinTable(lastName, firstName, mailAddress, password, gender, activity, weight, height, age);
        }

        public int Verifica(string mailAddress, string password)
        {
            //verificare dacă utilizatorul este înregistrat în baza de date
            return db.Verificare(mailAddress, password);
        }
    }
}
