namespace VladDiplom
{
    partial class AuthorisationFrm
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
            this.seePassBtn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seePassBtn
            // 
            this.seePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seePassBtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seePassBtn.ForeColor = System.Drawing.Color.Black;
            this.seePassBtn.Location = new System.Drawing.Point(392, 131);
            this.seePassBtn.Name = "seePassBtn";
            this.seePassBtn.Size = new System.Drawing.Size(32, 33);
            this.seePassBtn.TabIndex = 15;
            this.seePassBtn.Text = "👓";
            this.seePassBtn.UseVisualStyleBackColor = true;
            this.seePassBtn.Click += new System.EventHandler(this.seePassBtn_Click);
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.errorBox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorBox.ForeColor = System.Drawing.Color.Black;
            this.errorBox.Location = new System.Drawing.Point(57, 251);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(380, 20);
            this.errorBox.TabIndex = 19;
            this.errorBox.Text = "Ошибка, проверьте правильность введённых данных";
            this.errorBox.Visible = false;
            // 
            // enterBtn
            // 
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.Location = new System.Drawing.Point(151, 192);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(183, 47);
            this.enterBtn.TabIndex = 16;
            this.enterBtn.Text = "Войти в систему";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Location = new System.Drawing.Point(435, 9);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 17;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(460, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.ForeColor = System.Drawing.Color.Black;
            this.passBox.Location = new System.Drawing.Point(197, 131);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(190, 33);
            this.passBox.TabIndex = 13;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.Black;
            this.loginBox.Location = new System.Drawing.Point(197, 61);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(190, 33);
            this.loginBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Авторизация";
            // 
            // AuthorisationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(500, 286);
            this.Controls.Add(this.seePassBtn);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorisationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorisationFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seePassBtn;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}