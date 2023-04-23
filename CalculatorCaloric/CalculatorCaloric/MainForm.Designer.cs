namespace CalculatorCaloric
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLoseWeight = new System.Windows.Forms.RadioButton();
            this.radioButtonGainWeight = new System.Windows.Forms.RadioButton();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.textBoxMealsList = new System.Windows.Forms.TextBox();
            this.buttonShowProgress = new System.Windows.Forms.Button();
            this.groupBoxAddMeal = new System.Windows.Forms.GroupBox();
            this.comboBoxMealType = new System.Windows.Forms.ComboBox();
            this.labelMealType = new System.Windows.Forms.Label();
            this.labelCaloriesCount = new System.Windows.Forms.Label();
            this.textBoxAddCalories = new System.Windows.Forms.TextBox();
            this.groupBoxProgress = new System.Windows.Forms.GroupBox();
            this.labelDayCalories = new System.Windows.Forms.Label();
            this.textBoxDayCalories = new System.Windows.Forms.TextBox();
            this.textBoxCaloriesToTarget = new System.Windows.Forms.TextBox();
            this.labelCaloriesToTarget = new System.Windows.Forms.Label();
            this.groupBoxCalorieCount = new System.Windows.Forms.GroupBox();
            this.textBoxTargetCalories = new System.Windows.Forms.TextBox();
            this.labelTargetCalories = new System.Windows.Forms.Label();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxAddMeal.SuspendLayout();
            this.groupBoxProgress.SuspendLayout();
            this.groupBoxCalorieCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonLoseWeight
            // 
            this.radioButtonLoseWeight.AutoSize = true;
            this.radioButtonLoseWeight.Checked = true;
            this.radioButtonLoseWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLoseWeight.Location = new System.Drawing.Point(32, 31);
            this.radioButtonLoseWeight.Name = "radioButtonLoseWeight";
            this.radioButtonLoseWeight.Size = new System.Drawing.Size(97, 17);
            this.radioButtonLoseWeight.TabIndex = 0;
            this.radioButtonLoseWeight.TabStop = true;
            this.radioButtonLoseWeight.Text = "Pierde greutate";
            this.radioButtonLoseWeight.UseVisualStyleBackColor = true;
            // 
            // radioButtonGainWeight
            // 
            this.radioButtonGainWeight.AutoSize = true;
            this.radioButtonGainWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonGainWeight.Location = new System.Drawing.Point(142, 31);
            this.radioButtonGainWeight.Name = "radioButtonGainWeight";
            this.radioButtonGainWeight.Size = new System.Drawing.Size(110, 17);
            this.radioButtonGainWeight.TabIndex = 1;
            this.radioButtonGainWeight.Text = "Crește în greutate";
            this.radioButtonGainWeight.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.buttonCalculate);
            this.groupBoxResults.Controls.Add(this.textBoxResult);
            this.groupBoxResults.Controls.Add(this.radioButtonGainWeight);
            this.groupBoxResults.Controls.Add(this.radioButtonLoseWeight);
            this.groupBoxResults.Location = new System.Drawing.Point(20, 25);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(274, 375);
            this.groupBoxResults.TabIndex = 2;
            this.groupBoxResults.TabStop = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.Location = new System.Drawing.Point(66, 87);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(151, 25);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculează";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResult.Location = new System.Drawing.Point(32, 130);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(220, 225);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMeal.Location = new System.Drawing.Point(76, 87);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(107, 25);
            this.buttonAddMeal.TabIndex = 3;
            this.buttonAddMeal.Text = "Adaugă masă";
            this.buttonAddMeal.UseVisualStyleBackColor = true;
            this.buttonAddMeal.Click += new System.EventHandler(this.buttonAddMeal_Click);
            // 
            // textBoxMealsList
            // 
            this.textBoxMealsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMealsList.Location = new System.Drawing.Point(20, 130);
            this.textBoxMealsList.Multiline = true;
            this.textBoxMealsList.Name = "textBoxMealsList";
            this.textBoxMealsList.ReadOnly = true;
            this.textBoxMealsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMealsList.Size = new System.Drawing.Size(213, 225);
            this.textBoxMealsList.TabIndex = 4;
            // 
            // buttonShowProgress
            // 
            this.buttonShowProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowProgress.Location = new System.Drawing.Point(25, 28);
            this.buttonShowProgress.Name = "buttonShowProgress";
            this.buttonShowProgress.Size = new System.Drawing.Size(157, 34);
            this.buttonShowProgress.TabIndex = 5;
            this.buttonShowProgress.Text = "Vezi progres";
            this.buttonShowProgress.UseVisualStyleBackColor = true;
            this.buttonShowProgress.Click += new System.EventHandler(this.buttonShowProgress_Click);
            // 
            // groupBoxAddMeal
            // 
            this.groupBoxAddMeal.Controls.Add(this.comboBoxMealType);
            this.groupBoxAddMeal.Controls.Add(this.labelMealType);
            this.groupBoxAddMeal.Controls.Add(this.labelCaloriesCount);
            this.groupBoxAddMeal.Controls.Add(this.textBoxAddCalories);
            this.groupBoxAddMeal.Controls.Add(this.textBoxMealsList);
            this.groupBoxAddMeal.Controls.Add(this.buttonAddMeal);
            this.groupBoxAddMeal.Location = new System.Drawing.Point(310, 25);
            this.groupBoxAddMeal.Name = "groupBoxAddMeal";
            this.groupBoxAddMeal.Size = new System.Drawing.Size(253, 375);
            this.groupBoxAddMeal.TabIndex = 6;
            this.groupBoxAddMeal.TabStop = false;
            // 
            // comboBoxMealType
            // 
            this.comboBoxMealType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMealType.FormattingEnabled = true;
            this.comboBoxMealType.Items.AddRange(new object[] {
            "Mic dejun",
            "Prânz",
            "Cină",
            "Gustare"});
            this.comboBoxMealType.Location = new System.Drawing.Point(92, 27);
            this.comboBoxMealType.Name = "comboBoxMealType";
            this.comboBoxMealType.Size = new System.Drawing.Size(133, 21);
            this.comboBoxMealType.TabIndex = 14;
            // 
            // labelMealType
            // 
            this.labelMealType.AutoSize = true;
            this.labelMealType.Location = new System.Drawing.Point(33, 31);
            this.labelMealType.Name = "labelMealType";
            this.labelMealType.Size = new System.Drawing.Size(53, 13);
            this.labelMealType.TabIndex = 13;
            this.labelMealType.Text = "Tip masă:";
            // 
            // labelCaloriesCount
            // 
            this.labelCaloriesCount.AutoSize = true;
            this.labelCaloriesCount.Location = new System.Drawing.Point(33, 61);
            this.labelCaloriesCount.Name = "labelCaloriesCount";
            this.labelCaloriesCount.Size = new System.Drawing.Size(96, 13);
            this.labelCaloriesCount.TabIndex = 12;
            this.labelCaloriesCount.Text = "Calorii ultima masă:";
            // 
            // textBoxAddCalories
            // 
            this.textBoxAddCalories.Location = new System.Drawing.Point(135, 58);
            this.textBoxAddCalories.Name = "textBoxAddCalories";
            this.textBoxAddCalories.Size = new System.Drawing.Size(90, 20);
            this.textBoxAddCalories.TabIndex = 12;
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.Controls.Add(this.buttonShowProgress);
            this.groupBoxProgress.Location = new System.Drawing.Point(580, 214);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Size = new System.Drawing.Size(211, 81);
            this.groupBoxProgress.TabIndex = 7;
            this.groupBoxProgress.TabStop = false;
            // 
            // labelDayCalories
            // 
            this.labelDayCalories.AutoSize = true;
            this.labelDayCalories.Location = new System.Drawing.Point(6, 35);
            this.labelDayCalories.Name = "labelDayCalories";
            this.labelDayCalories.Size = new System.Drawing.Size(80, 13);
            this.labelDayCalories.TabIndex = 8;
            this.labelDayCalories.Text = "Total calorii azi:";
            // 
            // textBoxDayCalories
            // 
            this.textBoxDayCalories.Location = new System.Drawing.Point(90, 32);
            this.textBoxDayCalories.Name = "textBoxDayCalories";
            this.textBoxDayCalories.ReadOnly = true;
            this.textBoxDayCalories.Size = new System.Drawing.Size(115, 20);
            this.textBoxDayCalories.TabIndex = 9;
            this.textBoxDayCalories.Text = "0";
            // 
            // textBoxCaloriesToTarget
            // 
            this.textBoxCaloriesToTarget.Location = new System.Drawing.Point(114, 107);
            this.textBoxCaloriesToTarget.Name = "textBoxCaloriesToTarget";
            this.textBoxCaloriesToTarget.ReadOnly = true;
            this.textBoxCaloriesToTarget.Size = new System.Drawing.Size(91, 20);
            this.textBoxCaloriesToTarget.TabIndex = 11;
            // 
            // labelCaloriesToTarget
            // 
            this.labelCaloriesToTarget.AutoSize = true;
            this.labelCaloriesToTarget.Location = new System.Drawing.Point(6, 110);
            this.labelCaloriesToTarget.Name = "labelCaloriesToTarget";
            this.labelCaloriesToTarget.Size = new System.Drawing.Size(106, 13);
            this.labelCaloriesToTarget.TabIndex = 10;
            this.labelCaloriesToTarget.Text = "Calorii până la target:";
            // 
            // groupBoxCalorieCount
            // 
            this.groupBoxCalorieCount.Controls.Add(this.textBoxTargetCalories);
            this.groupBoxCalorieCount.Controls.Add(this.labelTargetCalories);
            this.groupBoxCalorieCount.Controls.Add(this.textBoxCaloriesToTarget);
            this.groupBoxCalorieCount.Controls.Add(this.labelCaloriesToTarget);
            this.groupBoxCalorieCount.Controls.Add(this.textBoxDayCalories);
            this.groupBoxCalorieCount.Controls.Add(this.labelDayCalories);
            this.groupBoxCalorieCount.Location = new System.Drawing.Point(580, 25);
            this.groupBoxCalorieCount.Name = "groupBoxCalorieCount";
            this.groupBoxCalorieCount.Size = new System.Drawing.Size(211, 183);
            this.groupBoxCalorieCount.TabIndex = 12;
            this.groupBoxCalorieCount.TabStop = false;
            // 
            // textBoxTargetCalories
            // 
            this.textBoxTargetCalories.Location = new System.Drawing.Point(53, 71);
            this.textBoxTargetCalories.Name = "textBoxTargetCalories";
            this.textBoxTargetCalories.Size = new System.Drawing.Size(115, 20);
            this.textBoxTargetCalories.TabIndex = 13;
            this.textBoxTargetCalories.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTargetCalories_KeyUp);
            // 
            // labelTargetCalories
            // 
            this.labelTargetCalories.AutoSize = true;
            this.labelTargetCalories.Location = new System.Drawing.Point(6, 74);
            this.labelTargetCalories.Name = "labelTargetCalories";
            this.labelTargetCalories.Size = new System.Drawing.Size(41, 13);
            this.labelTargetCalories.TabIndex = 12;
            this.labelTargetCalories.Text = "Target:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 412);
            this.Controls.Add(this.groupBoxCalorieCount);
            this.Controls.Add(this.groupBoxProgress);
            this.Controls.Add(this.groupBoxAddMeal);
            this.Controls.Add(this.groupBoxResults);
            this.Name = "MainForm";
            this.Text = "App";
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxAddMeal.ResumeLayout(false);
            this.groupBoxAddMeal.PerformLayout();
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxCalorieCount.ResumeLayout(false);
            this.groupBoxCalorieCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLoseWeight;
        private System.Windows.Forms.RadioButton radioButtonGainWeight;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.TextBox textBoxMealsList;
        private System.Windows.Forms.Button buttonShowProgress;
        private System.Windows.Forms.GroupBox groupBoxAddMeal;
        private System.Windows.Forms.GroupBox groupBoxProgress;
        private System.Windows.Forms.Label labelDayCalories;
        private System.Windows.Forms.TextBox textBoxDayCalories;
        private System.Windows.Forms.TextBox textBoxCaloriesToTarget;
        private System.Windows.Forms.Label labelCaloriesToTarget;
        private System.Windows.Forms.GroupBox groupBoxCalorieCount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxAddCalories;
        private System.Windows.Forms.Label labelCaloriesCount;
        private System.Windows.Forms.ComboBox comboBoxMealType;
        private System.Windows.Forms.Label labelMealType;
        private System.Windows.Forms.Label labelTargetCalories;
        private System.Windows.Forms.TextBox textBoxTargetCalories;
    }
}

