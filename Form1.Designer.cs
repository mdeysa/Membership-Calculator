
namespace Assignment4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonChildren = new System.Windows.Forms.RadioButton();
            this.radioButtonStudents = new System.Windows.Forms.RadioButton();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTrainer = new System.Windows.Forms.CheckBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.checkBoxKarate = new System.Windows.Forms.CheckBox();
            this.checkBoxZumba = new System.Windows.Forms.CheckBox();
            this.checkBoxYoga = new System.Windows.Forms.CheckBox();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonChildren);
            this.groupBox1.Controls.Add(this.radioButtonStudents);
            this.groupBox1.Controls.Add(this.radioButtonSenior);
            this.groupBox1.Controls.Add(this.radioButtonAdult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Membership Rate";
            // 
            // radioButtonChildren
            // 
            this.radioButtonChildren.AutoSize = true;
            this.radioButtonChildren.Location = new System.Drawing.Point(34, 174);
            this.radioButtonChildren.Name = "radioButtonChildren";
            this.radioButtonChildren.Size = new System.Drawing.Size(133, 19);
            this.radioButtonChildren.TabIndex = 3;
            this.radioButtonChildren.TabStop = true;
            this.radioButtonChildren.Text = "Children $15/month";
            this.radioButtonChildren.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudents
            // 
            this.radioButtonStudents.AutoSize = true;
            this.radioButtonStudents.Location = new System.Drawing.Point(34, 127);
            this.radioButtonStudents.Name = "radioButtonStudents";
            this.radioButtonStudents.Size = new System.Drawing.Size(135, 19);
            this.radioButtonStudents.TabIndex = 2;
            this.radioButtonStudents.TabStop = true;
            this.radioButtonStudents.Text = "Students $25/month";
            this.radioButtonStudents.UseVisualStyleBackColor = true;
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(34, 84);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(191, 19);
            this.radioButtonSenior.TabIndex = 1;
            this.radioButtonSenior.TabStop = true;
            this.radioButtonSenior.Text = "Seniors (ages 65+) $40/month";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.Location = new System.Drawing.Point(34, 39);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(114, 19);
            this.radioButtonAdult.TabIndex = 0;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "Adult $50/month";
            this.radioButtonAdult.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxTrainer);
            this.groupBox2.Controls.Add(this.checkBoxWater);
            this.groupBox2.Controls.Add(this.checkBoxKarate);
            this.groupBox2.Controls.Add(this.checkBoxZumba);
            this.groupBox2.Controls.Add(this.checkBoxYoga);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optional Services";
            // 
            // checkBoxTrainer
            // 
            this.checkBoxTrainer.AutoSize = true;
            this.checkBoxTrainer.Location = new System.Drawing.Point(18, 225);
            this.checkBoxTrainer.Name = "checkBoxTrainer";
            this.checkBoxTrainer.Size = new System.Drawing.Size(148, 19);
            this.checkBoxTrainer.TabIndex = 4;
            this.checkBoxTrainer.Text = "Personal Trainer +$50";
            this.checkBoxTrainer.UseVisualStyleBackColor = true;
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Location = new System.Drawing.Point(18, 177);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(177, 19);
            this.checkBoxWater.TabIndex = 3;
            this.checkBoxWater.Text = "Water Fitness Classes +$25";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // checkBoxKarate
            // 
            this.checkBoxKarate.AutoSize = true;
            this.checkBoxKarate.Location = new System.Drawing.Point(18, 130);
            this.checkBoxKarate.Name = "checkBoxKarate";
            this.checkBoxKarate.Size = new System.Drawing.Size(96, 19);
            this.checkBoxKarate.TabIndex = 2;
            this.checkBoxKarate.Text = "Karate: +$20";
            this.checkBoxKarate.UseVisualStyleBackColor = true;
            // 
            // checkBoxZumba
            // 
            this.checkBoxZumba.AutoSize = true;
            this.checkBoxZumba.Location = new System.Drawing.Point(18, 84);
            this.checkBoxZumba.Name = "checkBoxZumba";
            this.checkBoxZumba.Size = new System.Drawing.Size(148, 19);
            this.checkBoxZumba.TabIndex = 1;
            this.checkBoxZumba.Text = "Zumba Lessons: +$15";
            this.checkBoxZumba.UseVisualStyleBackColor = true;
            // 
            // checkBoxYoga
            // 
            this.checkBoxYoga.AutoSize = true;
            this.checkBoxYoga.Location = new System.Drawing.Point(18, 39);
            this.checkBoxYoga.Name = "checkBoxYoga";
            this.checkBoxYoga.Size = new System.Drawing.Size(143, 19);
            this.checkBoxYoga.TabIndex = 0;
            this.checkBoxYoga.Text = "Yoga Lessons:  +$10 ";
            this.checkBoxYoga.UseVisualStyleBackColor = true;
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(42, 396);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 2;
            this.buttonTotal.Text = "Calculate ";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(346, 396);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(631, 396);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Months for Membership";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonChildren;
        private System.Windows.Forms.RadioButton radioButtonStudents;
        private System.Windows.Forms.RadioButton radioButtonSenior;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.CheckBox checkBoxTrainer;
        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.CheckBox checkBoxKarate;
        private System.Windows.Forms.CheckBox checkBoxZumba;
        private System.Windows.Forms.CheckBox checkBoxYoga;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

