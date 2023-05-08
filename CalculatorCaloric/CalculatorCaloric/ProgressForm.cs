using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace CalculatorCaloric
{
    public partial class ProgressForm : Form
    {
        //control foslosit pentru afișarea graficului
        private PictureBox pictureBox;

        //vector ce ține minte numărul zilnic de calorii
        public List<double> caloriesVector = new List<double>();
        public ProgressForm(){
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox == null)
                {
                    //inițializare control picture box pentru grafic
                    pictureBox = new PictureBox();
                    pictureBox.Width = 800;
                    pictureBox.Height = 500;
                    pictureBox.Location = new Point(0, 0);
                    pictureBox.BackColor = Color.White;
                    Controls.Add(pictureBox);
                }

                using (Graphics graphics = pictureBox.CreateGraphics())
                {
                    graphics.Clear(Color.White);

                    //setarea coodonatelor pentru grafic
                    int xStart = 50;
                    int yStart = pictureBox.Height - 50;

                    int xMax = pictureBox.Width - 50;
                    int yMax = 50;

                    //desenarea axelor
                    Pen axisPen = new Pen(Color.Black, 2);
                    graphics.DrawLine(axisPen, xStart, yStart, xMax, yStart);
                    graphics.DrawLine(axisPen, xStart, yStart, xStart, yMax);

                    int pointRadius = 5;

                    //setare culoare puncte și drepte 
                    Brush pointBrush = new SolidBrush(Color.Blue);
                    for (int i = 0; i < caloriesVector.Count; i++)
                    {
                        float x = xStart + (float)(((caloriesVector[i] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                        float y = yStart - (float)(((double)i / (double)(caloriesVector.Count - 1)) * (yStart - yMax));

                        graphics.FillEllipse(pointBrush, x - pointRadius, y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                        if (i > 0)
                        {
                            float xPrev = xStart + (float)(((caloriesVector[i - 1] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                            float yPrev = yStart - (float)(((double)(i - 1) / (double)(caloriesVector.Count - 1)) * (yStart - yMax));
                            Pen linePen = new Pen(Color.Blue, 2);
                            graphics.DrawLine(linePen, xPrev, yPrev, x, y);
                        }
                    }

                    //setare pentru afișarea valori pe axe
                    int numTicks = 5;
                    double xIncrement = (caloriesVector.Max() - caloriesVector.Min()) / numTicks;
                    double xTickValue = caloriesVector.Min();
                    Font font = new Font("Arial", 10);
                    Brush textBrush = new SolidBrush(Color.Green);

                    //desenare valori pe axa ox
                    for (int i = 0; i <= numTicks; i++)
                    {
                        int x = xStart + (int)((xTickValue - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min()) * (xMax - xStart));
                        if (x >= xStart && x <= xMax)
                        {
                            graphics.DrawLine(axisPen, x, yStart, x, yStart + 5);
                        }
                        graphics.DrawString(xTickValue.ToString("N2"), font, textBrush, x - 25, yStart + 10);
                        xTickValue += xIncrement;
                    }
                }
            }
            catch (Exception ex)
            {
                //tratarea în caz care nu funcționează desenarea bine
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}