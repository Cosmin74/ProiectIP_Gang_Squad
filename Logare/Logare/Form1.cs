using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BazadeDate;

namespace Logare{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        //Instațiere a clasei pentru baza de date
        public BazadeDate.DB db = new BazadeDate.DB();
        
        //Metodă de creare unei noi interfețe atunci când utilizatorul apasa pe linkul "aici"
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            
            //Crearea unei noi interfețe atunci când utilizatorul apasa pe linkul "aici"
            Inregistrare f2 = new Inregistrare();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e){
            
            //Verifică dacă utilizatorul a completat ambele câmpuri
            if (email.Text != "" && pass.Text != "") {
                int verifica = db.Verificare(email.Text,pass.Text);
                    if (verifica != 1){
                        //Atenționează utilizatorul că nu a introdus bine parola sau adresa de mail
                        MessageBox.Show("Eroare la introducerea adresei de mail sau a parolei");
                    }
                    else{
                        // Dacă interogarea a returnat 1 autentificarea e reușită și se face refresh asupra câmpurilor.
                        MessageBox.Show("V-ati autentificat cu succes");
                        email.Text = "";
                        pass.Text = "";
                    }
              
            }
            else{
                
                //Dacă nu sunt completate ambele câmpuri, utilizatorul este avertizat să le completeze pe toate.
                MessageBox.Show("Completati toate campurile");
            }
        }
    }
}
