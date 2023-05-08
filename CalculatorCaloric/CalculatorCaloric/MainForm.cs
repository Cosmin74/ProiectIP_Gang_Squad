using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazadeDate;
using Meals;

namespace CalculatorCaloric
{
 
    public partial class MainForm : Form
    {
        //varaibilă de acces la interfața cu graficul
        private ProgressForm _progressForm;

        //instașiereaclselor din DLL-uri
        private CalculatorDLL.Calculator _calculator;
        private BazadeDate.DB db = new BazadeDate.DB();
        
        //listă cu mesele dintr-o zi
        private List<Meals.Meals> _meals;

        private string _email;
        private string _password;
        public string Email{
            get { return _email; }
            set { _email = value; }
        }
        public string Password{
            get { return _password; }
            set { _password = value; }
        }

        //varaiblilă ce sumează caloriile dintr-o zi 
        private double dayCaloriesSum = 0;
        public MainForm()
        {
            //inițializare interfațe și componete ce vor fi folosite
            InitializeComponent();
            _meals = new List<Meals.Meals>();
            _progressForm = new ProgressForm();
        }


        private void buttonCalculate_Click(object sender, EventArgs e) {
            string gen;
            string activity;
            double weight;
            double height;
            int age;

            //Extragere informații din baza de date
            gen = db.getGender(Email, Password);
            activity = db.getActivity(Email, Password);
            weight = db.getWeight(Email, Password);
            height = db.getHeight(Email, Password);
            age = db.getAge(Email, Password);

            _calculator = new CalculatorDLL.Calculator(gen, activity, weight, height, age);
            //Cazul în care s-a apăsat butonul de pierdere greutate
            if (radioButtonLoseWeight.Checked){            
                textBoxResult.Text = _calculator.loseWeightResults();
                updateTargetCalories();

            }
            //Cazul în care s-a apăsat butonul de crestere greutate
            else if (radioButtonGainWeight.Checked){ 
                textBoxResult.Text = _calculator.gainWeightResults();
                updateTargetCalories();

            }
        }

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string stringCalories = textBoxAddCalories.Text;
                double calories;
                //preluare calorii masa respectivă
                if (!Double.TryParse(stringCalories, out calories))
                {
                    throw new ArgumentException("Invalid input for calories");
                }
                //adăugare la totalul de calorii zilnic
                dayCaloriesSum += calories;
                string mealListResult = "";
                double caloriesTotal = 0;
                //adăugare meniu în listă
                _meals.Add(new Meals.Meals(comboBoxMealType.SelectedItem.ToString(), double.Parse(textBoxAddCalories.Text)));
                foreach (Meals.Meals meal in _meals) {
                    mealListResult += Environment.NewLine + " " + meal.type + ": " + meal.calories + " kcal." + System.Environment.NewLine;
                    caloriesTotal += meal.calories;
                }
                textBoxMealsList.Text = mealListResult;
                textBoxDayCalories.Text = caloriesTotal.ToString();
                //actualizare target
                updateTargetCalories();
            }
            catch (Exception ex)
            {
                //mesaj de atentonare in cazul in care datele nu au fost introduse bine
                MessageBox.Show(ex.Message);
                comboBoxMealType.SelectedIndex = 0;
                textBoxAddCalories.Text = 1.ToString();
            }
        }


        private void textBoxTargetCalories_KeyUp(object sender, KeyEventArgs e){
            try{
                //se actualizează caloriile din trget
                updateTargetCalories();  
            }
            catch (Exception ex){
                //se tratează cazul în care nu au fost bine introduse datele
                MessageBox.Show(ex.Message);
                textBoxTargetCalories.Text = "";
            }   
        }

        private void updateTargetCalories(){
            //verificare dacă există informații în textbox-uri cu calorii actuale și target 
            if (!string.IsNullOrEmpty(textBoxTargetCalories.Text) && !string.IsNullOrEmpty(textBoxDayCalories.Text))
            {
                //verificare dacă targetul a fost atins și afișarea unui mesaj pentru fiecare caz
                if (int.Parse(textBoxDayCalories.Text) >= int.Parse(textBoxTargetCalories.Text))
                {
                    if (radioButtonGainWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target atins!";
                    else if (radioButtonLoseWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target depasit!";
                }
                else
                {
                    //scade caloriile din target când a fost adăugată o nouă
                    textBoxCaloriesToTarget.Text = (int.Parse(textBoxTargetCalories.Text) - int.Parse(textBoxDayCalories.Text)).ToString();
                }
            }
        }

        private void buttonShowProgress_Click(object sender, EventArgs e){
            //apelarea interfeței cu grafice    
            _progressForm.ShowDialog();
        }

        private void AddDayButon_Click(object sender, EventArgs e){
            //adăugare numărului de calorii dintr-o zi 
            _progressForm.caloriesVector.Add(dayCaloriesSum);

            //resetarea tuturor câmpurilor de pe interfață
            dayCaloriesSum = 0;
            textBoxMealsList.Text = "";
            textBoxAddCalories.Text = "";
            textBoxTargetCalories.Text = "";
            textBoxCaloriesToTarget.Text = "";
            textBoxDayCalories.Text = "";
            _meals.Clear();
        }

        private void textBoxAddCalories_TextChanged(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            //_progressForm.caloriesVector.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e){
            //adăugare target zilnic pentru a putea fi afișat pe grafic
            if (textBoxTargetCalories.Text != null){
                string TargetCaloriesString = textBoxTargetCalories.Text;
                double TargetCalories = Convert.ToDouble(TargetCaloriesString);
                _progressForm.caloriesVector.Add(TargetCalories);
            }
        }
    }
}
