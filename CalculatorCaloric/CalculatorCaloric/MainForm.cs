using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCaloric
{
    public partial class MainForm : Form
    {
        private ProgressForm _progressForm;

        private Calculator _calculator;
        private List<Meals> _meals;
        public MainForm()
        {
            InitializeComponent();
            _calculator = new Calculator("Male", "Active", 65, 180, 25);
            _meals = new List<Meals>();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonLoseWeight.Checked)
            {
                textBoxResult.Text = _calculator.loseWeightResults();
                updateTargetCalories();

            }
            else if (radioButtonGainWeight.Checked)
            {
                textBoxResult.Text = _calculator.gainWeightResults();
                updateTargetCalories();

            }
        }

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string mealListResult = "";
                double caloriesTotal = 0;
                _meals.Add(new Meals(comboBoxMealType.SelectedItem.ToString(), double.Parse(textBoxAddCalories.Text)));
                foreach (Meals meal in _meals)
                {
                    mealListResult += Environment.NewLine + " " + meal.type + ": " + meal.calories + " kcal." + System.Environment.NewLine;
                    caloriesTotal += meal.calories;
                }
                textBoxMealsList.Text = mealListResult;
                textBoxDayCalories.Text = caloriesTotal.ToString();
                updateTargetCalories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comboBoxMealType.SelectedIndex = 0;
                textBoxAddCalories.Text = 1.ToString();
            }
        }

        private void textBoxTargetCalories_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                updateTargetCalories();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxTargetCalories.Text = "";
            }   
        }

        private void updateTargetCalories()
        {
            if (!string.IsNullOrEmpty(textBoxTargetCalories.Text))
            {
                if (int.Parse(textBoxDayCalories.Text) >= int.Parse(textBoxTargetCalories.Text))
                {
                    if (radioButtonGainWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target atins!";
                    else if (radioButtonLoseWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target depasit!";
                }
                else
                {
                    textBoxCaloriesToTarget.Text = (int.Parse(textBoxTargetCalories.Text) - int.Parse(textBoxDayCalories.Text)).ToString();
                }
            }
        }

        private void buttonShowProgress_Click(object sender, EventArgs e)
        {
            _progressForm = new ProgressForm();
            _progressForm.ShowDialog();
        }
    }
}
