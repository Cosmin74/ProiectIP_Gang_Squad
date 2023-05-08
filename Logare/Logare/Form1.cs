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
using CalculatorCaloric;
using BazaDeDateFacade;

namespace Logare{
    public partial class Form1 : Form{
        public Form1(){
            //inițializare baza de date și interfață
            InitializeComponent();
            bazaDeDateFacade = new BazaDeDateFacade.BazaDeDateFacade();
        }
        //Instațiere a clasei pentru baza de date
        private BazaDeDateFacade.BazaDeDateFacade bazaDeDateFacade;
        
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
                int verifica = bazaDeDateFacade.Verifica(email.Text,pass.Text);
                    if (verifica != 1){
                        //Atenționează utilizatorul că nu a introdus bine parola sau adresa de mail
                        MessageBox.Show("Eroare la introducerea adresei de mail sau a parolei");
                    }
                    else{
                    // Dacă interogarea a returnat 1 autentificarea e reușită și se face refresh asupra câmpurilor.
                    MainForm mainForm = new MainForm();
                    mainForm.Email = email.Text;
                    mainForm.Password = pass.Text;
                    mainForm.Show();
                    Visible = false;
                    //email.Text = "";
                    //pass.Text = "";
                    }
              
            }
            else{
                
                //Dacă nu sunt completate ambele câmpuri, utilizatorul este avertizat să le completeze pe toate.
                MessageBox.Show("Completati toate campurile");
            }
        }

        private void button2_Click(object sender, EventArgs e){
            //buton pentru afișarea helper-ului
            System.Diagnostics.Process.Start("Helper.chm");
        }

        private void button3_Click(object sender, EventArgs e){
            //buton despre
            MessageBox.Show("Aplicație pentru contorizarea numărului de calorii consumate,pentru cei care vor să piardă în greutate sau să crească");
        }
    }
}
