namespace VladDiplom
{
    partial class AddCarFrm
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
            this.gendLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.patrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.countOwnBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.VINBox = new System.Windows.Forms.TextBox();
            this.gosNomerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sostBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gendLbl
            // 
            this.gendLbl.AutoSize = true;
            this.gendLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gendLbl.ForeColor = System.Drawing.Color.White;
            this.gendLbl.Location = new System.Drawing.Point(151, 243);
            this.gendLbl.Name = "gendLbl";
            this.gendLbl.Size = new System.Drawing.Size(80, 26);
            this.gendLbl.TabIndex = 56;
            this.gendLbl.Text = "Модель";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.White;
            this.phoneLbl.Location = new System.Drawing.Point(9, 199);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(220, 26);
            this.phoneLbl.TabIndex = 55;
            this.phoneLbl.Text = "Количество владельцев";
            // 
            // patrLbl
            // 
            this.patrLbl.AutoSize = true;
            this.patrLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLbl.ForeColor = System.Drawing.Color.White;
            this.patrLbl.Location = new System.Drawing.Point(125, 155);
            this.patrLbl.Name = "patrLbl";
            this.patrLbl.Size = new System.Drawing.Size(104, 26);
            this.patrLbl.TabIndex = 54;
            this.patrLbl.Text = "Стоимость";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(182, 111);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 26);
            this.nameLbl.TabIndex = 53;
            this.nameLbl.Text = "VIN";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.White;
            this.surnameLbl.Location = new System.Drawing.Point(127, 67);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(104, 26);
            this.surnameLbl.TabIndex = 52;
            this.surnameLbl.Text = "Гос. номер";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(132, 538);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(232, 52);
            this.saveBtn.TabIndex = 51;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(237, 240);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(232, 34);
            this.modelBox.TabIndex = 50;
            // 
            // countOwnBox
            // 
            this.countOwnBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOwnBox.Location = new System.Drawing.Point(237, 196);
            this.countOwnBox.Name = "countOwnBox";
            this.countOwnBox.Size = new System.Drawing.Size(232, 33);
            this.countOwnBox.TabIndex = 49;
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costBox.Location = new System.Drawing.Point(237, 152);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(232, 33);
            this.costBox.TabIndex = 48;
            // 
            // VINBox
            // 
            this.VINBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VINBox.Location = new System.Drawing.Point(237, 108);
            this.VINBox.Name = "VINBox";
            this.VINBox.Size = new System.Drawing.Size(232, 33);
            this.VINBox.TabIndex = 47;
            // 
            // gosNomerBox
            // 
            this.gosNomerBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gosNomerBox.Location = new System.Drawing.Point(237, 64);
            this.gosNomerBox.Name = "gosNomerBox";
            this.gosNomerBox.Size = new System.Drawing.Size(232, 33);
            this.gosNomerBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Добавление автомобиля";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(443, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 42;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(468, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(493, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 44;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "Владелец";
            // 
            // ownerBox
            // 
            this.ownerBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerBox.FormattingEnabled = true;
            this.ownerBox.Location = new System.Drawing.Point(237, 285);
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(232, 34);
            this.ownerBox.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Состояние";
            // 
            // sostBox
            // 
            this.sostBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sostBox.FormattingEnabled = true;
            this.sostBox.Location = new System.Drawing.Point(237, 330);
            this.sostBox.Name = "sostBox";
            this.sostBox.Size = new System.Drawing.Size(232, 34);
            this.sostBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(176, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 62;
            this.label4.Text = "Цвет";
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(237, 375);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(232, 34);
            this.colorBox.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(131, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 64;
            this.label5.Text = "Описание";
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descBox.Location = new System.Drawing.Point(237, 420);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(232, 95);
            this.descBox.TabIndex = 63;
            // 
            // AddCarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(533, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sostBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ownerBox);
            this.Controls.Add(this.gendLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.patrLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.countOwnBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.VINBox);
            this.Controls.Add(this.gosNomerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gendLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label patrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.TextBox countOwnBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox VINBox;
        private System.Windows.Forms.TextBox gosNomerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ownerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sostBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descBox;
    }
}