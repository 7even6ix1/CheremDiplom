namespace VladDiplom
{
    partial class AddWorkerFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gendLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.patrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.postBox = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "Добавление сотрудника";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(369, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 42;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(147, 540);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 41;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Должность";
            // 
            // gendLbl
            // 
            this.gendLbl.AutoSize = true;
            this.gendLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gendLbl.ForeColor = System.Drawing.Color.White;
            this.gendLbl.Location = new System.Drawing.Point(128, 252);
            this.gendLbl.Name = "gendLbl";
            this.gendLbl.Size = new System.Drawing.Size(48, 26);
            this.gendLbl.TabIndex = 49;
            this.gendLbl.Text = "Пол";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.White;
            this.phoneLbl.Location = new System.Drawing.Point(32, 209);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(147, 26);
            this.phoneLbl.TabIndex = 48;
            this.phoneLbl.Text = "Дата рождения";
            // 
            // patrLbl
            // 
            this.patrLbl.AutoSize = true;
            this.patrLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLbl.ForeColor = System.Drawing.Color.White;
            this.patrLbl.Location = new System.Drawing.Point(88, 162);
            this.patrLbl.Name = "patrLbl";
            this.patrLbl.Size = new System.Drawing.Size(91, 26);
            this.patrLbl.TabIndex = 47;
            this.patrLbl.Text = "Отчество";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(125, 117);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 26);
            this.nameLbl.TabIndex = 46;
            this.nameLbl.Text = "Имя";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.White;
            this.surnameLbl.Location = new System.Drawing.Point(85, 72);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(94, 26);
            this.surnameLbl.TabIndex = 45;
            this.surnameLbl.Text = "Фамилия";
            // 
            // postBox
            // 
            this.postBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.postBox.FormattingEnabled = true;
            this.postBox.Location = new System.Drawing.Point(185, 295);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(262, 34);
            this.postBox.TabIndex = 40;
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(185, 249);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(262, 34);
            this.genderBox.TabIndex = 39;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.dateBox.Location = new System.Drawing.Point(185, 204);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(262, 33);
            this.dateBox.TabIndex = 38;
            // 
            // patronymicBox
            // 
            this.patronymicBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.patronymicBox.Location = new System.Drawing.Point(185, 159);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(262, 33);
            this.patronymicBox.TabIndex = 37;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.nameBox.Location = new System.Drawing.Point(185, 114);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(262, 33);
            this.nameBox.TabIndex = 36;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.surnameBox.Location = new System.Drawing.Point(185, 69);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(262, 33);
            this.surnameBox.TabIndex = 35;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Location = new System.Drawing.Point(394, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 43;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(419, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 44;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Номер телефона";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.phoneBox.Location = new System.Drawing.Point(185, 344);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(262, 33);
            this.phoneBox.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "Адрес";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.addressBox.Location = new System.Drawing.Point(185, 392);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(262, 33);
            this.addressBox.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 57;
            this.label5.Text = "Логин";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.loginBox.Location = new System.Drawing.Point(185, 441);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(262, 33);
            this.loginBox.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 59;
            this.label6.Text = "Пароль";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.passBox.Location = new System.Drawing.Point(185, 489);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(262, 33);
            this.passBox.TabIndex = 58;
            // 
            // AddWorkerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(461, 607);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.patrLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWorkerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorkerFrm";
            this.Load += new System.EventHandler(this.AddWorkerFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gendLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label patrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.ComboBox postBox;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passBox;
    }
}