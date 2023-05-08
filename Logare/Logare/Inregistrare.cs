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
using BazaDeDateFacade;

namespace Logare{
    public partial class Inregistrare : Form{
        public Inregistrare(){
            InitializeComponent();
            bazaDeDateFacade = new BazaDeDateFacade.BazaDeDateFacade();
        }

        private BazaDeDateFacade.BazaDeDateFacade bazaDeDateFacade;

        // Această metodă deschide fereastra de autentificare atunci când utilizatorul dorește să se întoarcă la acea pagină.
        private void button2_Click(object sender, EventArgs e){
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e){
            //Verifică dacă utilizatorul a completat toate câmpuri
            if (last_name.Text != "" && first_name.Text != "" && mail_address.Text != "" && pass.Text != "" && gen.Text != "" && activity.Text != "" && weight.Text != "" && height.Text != "" && age.Text != ""){
                int checkNumber = bazaDeDateFacade.Check(mail_address.Text);
                if (checkNumber != 1){
                    //Adaugarea informatiilor persoanle in baza de date 
                    bazaDeDateFacade.AddInTable(last_name.Text, first_name.Text, mail_address.Text, pass.Text, gen.Text, activity.Text, weight.Text, height.Text, age.Text);

                    MessageBox.Show("V-ați înregistrat cu succes");
                    //Se face refresh la toate câmpurile 
                    first_name.Text = "";
                    last_name.Text = "";
                    mail_address.Text = "";
                    pass.Text = "";
                    activity.Text = "";
                    weight.Text = "";
                    height.Text = "";
                    age.Text = "";
                }
                else{
                    //Utilizatorul este informat că nu a introdus bine parola sau email-ul
                    MessageBox.Show("Eroare la aduagarea parolei sau a adresei de mail");
                }
            }
            else{
                //Utilizatorul este informat că trebuie să completezr toate câmpurile
                MessageBox.Show("Completati toate campurile");
            }
        } 
        private void gen_SelectedIndexChanged(object sender, EventArgs e){ 
        }
    }
}