namespace VladDiplom
{
    partial class AddClientFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.gendLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.patrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.patrBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Добавление клиента";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(343, 18);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(368, 18);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 28;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(393, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 29;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // gendLbl
            // 
            this.gendLbl.AutoSize = true;
            this.gendLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gendLbl.ForeColor = System.Drawing.Color.White;
            this.gendLbl.Location = new System.Drawing.Point(96, 274);
            this.gendLbl.Name = "gendLbl";
            this.gendLbl.Size = new System.Drawing.Size(48, 26);
            this.gendLbl.TabIndex = 41;
            this.gendLbl.Text = "Пол";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.White;
            this.phoneLbl.Location = new System.Drawing.Point(57, 225);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(90, 26);
            this.phoneLbl.TabIndex = 40;
            this.phoneLbl.Text = "Телефон";
            // 
            // patrLbl
            // 
            this.patrLbl.AutoSize = true;
            this.patrLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLbl.ForeColor = System.Drawing.Color.White;
            this.patrLbl.Location = new System.Drawing.Point(56, 176);
            this.patrLbl.Name = "patrLbl";
            this.patrLbl.Size = new System.Drawing.Size(91, 26);
            this.patrLbl.TabIndex = 39;
            this.patrLbl.Text = "Отчество";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(96, 127);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 26);
            this.nameLbl.TabIndex = 38;
            this.nameLbl.Text = "Имя";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.White;
            this.surnameLbl.Location = new System.Drawing.Point(53, 78);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(94, 26);
            this.surnameLbl.TabIndex = 37;
            this.surnameLbl.Text = "Фамилия";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(119, 327);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(194, 52);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Добавить клиента";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(153, 271);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(232, 34);
            this.genderBox.TabIndex = 35;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(153, 222);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(232, 33);
            this.phoneBox.TabIndex = 34;
            // 
            // patrBox
            // 
            this.patrBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrBox.Location = new System.Drawing.Point(153, 173);
            this.patrBox.Name = "patrBox";
            this.patrBox.Size = new System.Drawing.Size(232, 33);
            this.patrBox.TabIndex = 33;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(153, 124);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(232, 33);
            this.nameBox.TabIndex = 32;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(153, 75);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(232, 33);
            this.surnameBox.TabIndex = 31;
            // 
            // AddClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(437, 391);
            this.Controls.Add(this.gendLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.patrLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.patrBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClientFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientFrm";
            this.Load += new System.EventHandler(this.AddClientFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label gendLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label patrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox patrBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
    }
}