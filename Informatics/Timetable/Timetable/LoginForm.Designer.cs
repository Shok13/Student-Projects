namespace Timetable
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.login_Label = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.password_Label = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.showPass_Check = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.wrongPassOrLog = new System.Windows.Forms.Label();
            this.hintForLogin = new System.Windows.Forms.ToolTip(this.components);
            this.hintForPass = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 337);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 329);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.login_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginField, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.password_Label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordField, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.showPass_Check, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.wrongPassOrLog, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(100, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // login_Label
            // 
            this.login_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.login_Label.AutoEllipsis = true;
            this.login_Label.AutoSize = true;
            this.login_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_Label.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Label.ForeColor = System.Drawing.Color.OrangeRed;
            this.login_Label.Location = new System.Drawing.Point(104, 41);
            this.login_Label.Name = "login_Label";
            this.login_Label.Size = new System.Drawing.Size(144, 41);
            this.login_Label.TabIndex = 0;
            this.login_Label.Text = "Login";
            // 
            // loginField
            // 
            this.loginField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginField.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(23, 85);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(306, 31);
            this.loginField.TabIndex = 1;
            this.hintForLogin.SetToolTip(this.loginField, "Login must contain at least 6 characters");
            // 
            // password_Label
            // 
            this.password_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password_Label.AutoSize = true;
            this.password_Label.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Label.ForeColor = System.Drawing.Color.OrangeRed;
            this.password_Label.Location = new System.Drawing.Point(68, 123);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(215, 41);
            this.password_Label.TabIndex = 2;
            this.password_Label.Text = "Password";
            // 
            // passwordField
            // 
            this.passwordField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordField.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(23, 167);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(306, 31);
            this.passwordField.TabIndex = 3;
            this.hintForPass.SetToolTip(this.passwordField, "Password must contain at least 6 characters");
            // 
            // showPass_Check
            // 
            this.showPass_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.showPass_Check.AutoSize = true;
            this.showPass_Check.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass_Check.ForeColor = System.Drawing.Color.OrangeRed;
            this.showPass_Check.Location = new System.Drawing.Point(94, 208);
            this.showPass_Check.Name = "showPass_Check";
            this.showPass_Check.Size = new System.Drawing.Size(164, 35);
            this.showPass_Check.TabIndex = 4;
            this.showPass_Check.Text = "Show Password";
            this.showPass_Check.UseVisualStyleBackColor = true;
            this.showPass_Check.CheckedChanged += new System.EventHandler(this.showPass_Check_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ok_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancel_button, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 249);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 35);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.ForeColor = System.Drawing.Color.Green;
            this.ok_button.Location = new System.Drawing.Point(50, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 29);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.Red;
            this.cancel_button.Location = new System.Drawing.Point(156, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(101, 29);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // wrongPassOrLog
            // 
            this.wrongPassOrLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.wrongPassOrLog.AutoSize = true;
            this.wrongPassOrLog.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongPassOrLog.ForeColor = System.Drawing.Color.Red;
            this.wrongPassOrLog.Location = new System.Drawing.Point(78, 287);
            this.wrongPassOrLog.Name = "wrongPassOrLog";
            this.wrongPassOrLog.Size = new System.Drawing.Size(195, 42);
            this.wrongPassOrLog.TabIndex = 6;
            this.wrongPassOrLog.Text = "Wrong login or password!";
            this.wrongPassOrLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wrongPassOrLog.Visible = false;
            // 
            // hintForLogin
            // 
            this.hintForLogin.AutomaticDelay = 100;
            this.hintForLogin.AutoPopDelay = 5000;
            this.hintForLogin.InitialDelay = 100;
            this.hintForLogin.IsBalloon = true;
            this.hintForLogin.ReshowDelay = 20;
            this.hintForLogin.ToolTipTitle = "Enter your login here";
            // 
            // hintForPass
            // 
            this.hintForPass.AutomaticDelay = 100;
            this.hintForPass.AutoPopDelay = 5000;
            this.hintForPass.InitialDelay = 100;
            this.hintForPass.IsBalloon = true;
            this.hintForPass.ReshowDelay = 20;
            this.hintForPass.ToolTipTitle = "Enter your password here";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label login_Label;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.CheckBox showPass_Check;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ToolTip hintForLogin;
        private System.Windows.Forms.Label wrongPassOrLog;
        private System.Windows.Forms.ToolTip hintForPass;
    }
}

