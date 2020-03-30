namespace Recruitment
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
            this.fullName = new System.Windows.Forms.TextBox();
            this.fullName_Label = new System.Windows.Forms.Label();
            this.passport = new System.Windows.Forms.TextBox();
            this.passport_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.experience = new System.Windows.Forms.ComboBox();
            this.exp_Label = new System.Windows.Forms.Label();
            this.teachingExp_Label = new System.Windows.Forms.Label();
            this.teachingExp = new System.Windows.Forms.RadioButton();
            this.nonTeachingExp = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataPassport_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialNumber_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ok_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(30, 50);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(300, 23);
            this.fullName.TabIndex = 0;
            this.fullName.TextChanged += new System.EventHandler(this.fullName_TextChanged);
            // 
            // fullName_Label
            // 
            this.fullName_Label.AutoSize = true;
            this.fullName_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_Label.Location = new System.Drawing.Point(18, 11);
            this.fullName_Label.Name = "fullName_Label";
            this.fullName_Label.Size = new System.Drawing.Size(52, 23);
            this.fullName_Label.TabIndex = 1;
            this.fullName_Label.Text = "ФИО";
            // 
            // passport
            // 
            this.passport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passport.Location = new System.Drawing.Point(27, 63);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(300, 23);
            this.passport.TabIndex = 2;
            this.passport.TextChanged += new System.EventHandler(this.passport_TextChanged_1);
            // 
            // passport_Label
            // 
            this.passport_Label.AutoSize = true;
            this.passport_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passport_Label.Location = new System.Drawing.Point(89, 11);
            this.passport_Label.Name = "passport_Label";
            this.passport_Label.Size = new System.Drawing.Size(183, 23);
            this.passport_Label.TabIndex = 3;
            this.passport_Label.Text = "Паспортные данные";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fullName_Label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 80);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // experience
            // 
            this.experience.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experience.ForeColor = System.Drawing.SystemColors.WindowText;
            this.experience.Items.AddRange(new object[] {
            "менее 3 лет",
            "от 3 до 5 лет",
            "от 5 до 10 лет",
            "более 10 лет"});
            this.experience.Location = new System.Drawing.Point(104, 8);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(210, 24);
            this.experience.TabIndex = 5;
            this.experience.SelectedIndexChanged += new System.EventHandler(this.experience_SelectedIndexChanged);
            // 
            // exp_Label
            // 
            this.exp_Label.AutoSize = true;
            this.exp_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_Label.Location = new System.Drawing.Point(15, 8);
            this.exp_Label.Name = "exp_Label";
            this.exp_Label.Size = new System.Drawing.Size(55, 23);
            this.exp_Label.TabIndex = 6;
            this.exp_Label.Text = "Стаж";
            // 
            // teachingExp_Label
            // 
            this.teachingExp_Label.AutoSize = true;
            this.teachingExp_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachingExp_Label.Location = new System.Drawing.Point(15, 55);
            this.teachingExp_Label.Name = "teachingExp_Label";
            this.teachingExp_Label.Size = new System.Drawing.Size(96, 23);
            this.teachingExp_Label.TabIndex = 7;
            this.teachingExp_Label.Text = "Пед. стаж";
            // 
            // teachingExp
            // 
            this.teachingExp.AutoSize = true;
            this.teachingExp.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachingExp.Location = new System.Drawing.Point(188, 55);
            this.teachingExp.Name = "teachingExp";
            this.teachingExp.Size = new System.Drawing.Size(64, 27);
            this.teachingExp.TabIndex = 8;
            this.teachingExp.TabStop = true;
            this.teachingExp.Text = "есть";
            this.teachingExp.UseVisualStyleBackColor = true;
            // 
            // nonTeachingExp
            // 
            this.nonTeachingExp.AutoSize = true;
            this.nonTeachingExp.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonTeachingExp.Location = new System.Drawing.Point(258, 55);
            this.nonTeachingExp.Name = "nonTeachingExp";
            this.nonTeachingExp.Size = new System.Drawing.Size(56, 27);
            this.nonTeachingExp.TabIndex = 9;
            this.nonTeachingExp.TabStop = true;
            this.nonTeachingExp.Text = "нет";
            this.nonTeachingExp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nonTeachingExp);
            this.panel2.Controls.Add(this.teachingExp);
            this.panel2.Controls.Add(this.teachingExp_Label);
            this.panel2.Controls.Add(this.exp_Label);
            this.panel2.Controls.Add(this.experience);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 104);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataPassport_Label
            // 
            this.dataPassport_Label.AutoSize = true;
            this.dataPassport_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPassport_Label.Location = new System.Drawing.Point(25, 89);
            this.dataPassport_Label.Name = "dataPassport_Label";
            this.dataPassport_Label.Size = new System.Drawing.Size(174, 23);
            this.dataPassport_Label.TabIndex = 11;
            this.dataPassport_Label.Text = "Кем и когда выдан";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 23);
            this.textBox1.TabIndex = 12;
            // 
            // serialNumber_Label
            // 
            this.serialNumber_Label.AutoSize = true;
            this.serialNumber_Label.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumber_Label.Location = new System.Drawing.Point(25, 37);
            this.serialNumber_Label.Name = "serialNumber_Label";
            this.serialNumber_Label.Size = new System.Drawing.Size(210, 23);
            this.serialNumber_Label.TabIndex = 13;
            this.serialNumber_Label.Text = "Серия, номер паспорта";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.serialNumber_Label);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.dataPassport_Label);
            this.panel3.Controls.Add(this.passport_Label);
            this.panel3.Controls.Add(this.passport);
            this.panel3.Location = new System.Drawing.Point(427, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 215);
            this.panel3.TabIndex = 14;
            // 
            // ok_Button
            // 
            this.ok_Button.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_Button.Location = new System.Drawing.Point(337, 253);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(95, 27);
            this.ok_Button.TabIndex = 15;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Прием на работу";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label fullName_Label;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.Label passport_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox experience;
        private System.Windows.Forms.Label exp_Label;
        private System.Windows.Forms.Label teachingExp_Label;
        private System.Windows.Forms.RadioButton teachingExp;
        private System.Windows.Forms.RadioButton nonTeachingExp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dataPassport_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label serialNumber_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ok_Button;
    }
}

