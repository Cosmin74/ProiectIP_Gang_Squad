﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BazadeDate{
    public class DB{

        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\Useres.mdf;Integrated Security=True;Connect Timeout=30");
        public void AddinTable(string last_name, string first_name, string mail_address, string pass, string gen, string activity, string weight, string height, string age){
            try
            {
                //Deschiderea conexiunii la baza de date
                connection.Open();

                //Interogare SQL care introduce datele utilizatorului în baza de date
                SqlCommand comanda = new SqlCommand("insert into [User] (Nume, Prenume, Mail, Parola,Gen,NivelActivitate,Greutate,Inaltime,Varsta) values(@last_name,@first_name,@mail_address,@password,@gender,@activity,@weight,@height,@age)", connection);
                comanda.Parameters.AddWithValue("@last_name", last_name);
                comanda.Parameters.AddWithValue("@first_name", first_name);
                comanda.Parameters.AddWithValue("@mail_address", mail_address);
                comanda.Parameters.AddWithValue("@password", pass);
                comanda.Parameters.AddWithValue("@gender", gen);
                comanda.Parameters.AddWithValue("@activity", activity);
                comanda.Parameters.AddWithValue("@weight", weight);
                comanda.Parameters.AddWithValue("@height", height);
                comanda.Parameters.AddWithValue("@age", age);
                comanda.ExecuteNonQuery();
                //Utilizatorul este autentificat că a fost înregistrat
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
               MessageBox.Show("Eroare la interogare : " + ex.Message);
            }
            finally
            {
                //Închiderea conexiunii la baza de date
                connection.Close();
            }
        }

        public int check(string email){
            int checkNumber = 0;

            try
            {
                //Deschiderea conexiunii la baza de date
                connection.Open();

                //Interogare SQL pentru a verifica dacă utilizatorul e înregistrat în baza de date
                string query = "select count(*) from [User] where [Mail]='" + email + "'";
                SqlCommand comanda = new SqlCommand(query, connection);
                checkNumber = (int)comanda.ExecuteScalar();
            }
            catch (Exception ex){
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la interogare : " + ex.Message);
            }
            finally{
                //Închiderea conexiunii la baza de date
                connection.Close();
            }
            return checkNumber;
        }

        public int Verificare(string email, string pass){
            // Interogare SQL pentru a verifica dacă email-ul și parola sunt în baza de date
            string interogare = "SELECT COUNT(*) FROM [User] where Mail='" + email + "'" + "AND Parola='" + pass + "'";
            int NumarVerificare = 0;
            //Deschiderea conexiunii la baza de date 
            try{
                connection.Open();
            }
            catch (Exception ex){
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }

            try {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                NumarVerificare = (int)comanda.ExecuteScalar();

                //Închiderea onexiunii la baza de date
                try{
                    connection.Close();
                }
                catch (Exception ex){
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex){
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return NumarVerificare;
        }

        public string getGender(string email, string pass)
        {
            MessageBox.Show(email+" "+pass);
            string interogare = "SELECT Gen FROM [User] where Mail='" + email + "'" + "AND Parola='" + pass + "'";
            string gen = "";
            //Deschiderea conexiunii la baza de date 
            try
            {
                connection.Open();
            }
            catch (Exception ex){
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }
            try
            {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                gen = (string)comanda.ExecuteScalar();
                //Închiderea onexiunii la baza de date
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return gen;
        }

        public string getActivity(string email, string pass)
        {
            string interogare = "SELECT NivelActivitate FROM [User] where [Mail]='" + email + "'" + "AND [Parola]='" + pass + "'";
            string nivelActivitate = "";
            //Deschiderea conexiunii la baza de date 
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }
            try
            {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                nivelActivitate = comanda.ExecuteScalar().ToString();
                //Închiderea onexiunii la baza de date
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return nivelActivitate;
        }

        public double getWeight(string email, string pass)
        {
            string interogare = "SELECT Greutate FROM [User] where [Mail]='" + email + "'" + "AND [Parola]='" + pass + "'";
            double greutate = 0;
            //Deschiderea conexiunii la baza de date 
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }
            try
            {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                greutate = (double)comanda.ExecuteScalar();
                //Închiderea onexiunii la baza de date
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return greutate;
        }

        public double getHeight(string email, string pass)
        {
            string interogare = "SELECT Inaltime FROM [User] where [Mail]='" + email + "'" + "AND [Parola]='" + pass + "'";
            double inaltime = 0;
            //Deschiderea conexiunii la baza de date 
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }
            try
            {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                inaltime = (double)comanda.ExecuteScalar();
                //Închiderea onexiunii la baza de date
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return inaltime;
        }

        public int getAge(string email,string pass)
        {
            string interogare = "SELECT Varsta FROM [User] where [Mail]='" + email + "'" + "AND [Parola]='" + pass + "'";
            int varsta = 0;
            //Deschiderea conexiunii la baza de date 
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul deschiderii conexiunii.
                MessageBox.Show("Eroare la deschidere conexiunii : " + ex.Message);
            }
            try
            {
                //Executarea interogării SQL și salvarea rezultatului
                SqlCommand comanda = new SqlCommand(interogare, connection);
                varsta = (int)comanda.ExecuteScalar();
                //Închiderea onexiunii la baza de date
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Se gestionează erorile care pot aparea in timpul inchiderr conexiunii.
                    MessageBox.Show("Eroare la inchiderea conexiunii : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Se gestionează erorile care pot aparea in timpul execuției interogării.
                MessageBox.Show("Eroare la executia : " + ex.Message);
            }
            return varsta;
        }
    }
}
