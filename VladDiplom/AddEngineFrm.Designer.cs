namespace VladDiplom
{
    partial class AddEngineFrm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gendLbl = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.volumeBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cylindersBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(371, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 75;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Location = new System.Drawing.Point(396, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 73;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(421, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 74;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "Добавление двигателя";
            // 
            // gendLbl
            // 
            this.gendLbl.AutoSize = true;
            this.gendLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gendLbl.ForeColor = System.Drawing.Color.White;
            this.gendLbl.Location = new System.Drawing.Point(126, 70);
            this.gendLbl.Name = "gendLbl";
            this.gendLbl.Size = new System.Drawing.Size(48, 26);
            this.gendLbl.TabIndex = 77;
            this.gendLbl.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(180, 67);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(207, 34);
            this.typeBox.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 79;
            this.label2.Text = "Бензин";
            // 
            // fuelBox
            // 
            this.fuelBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.fuelBox.FormattingEnabled = true;
            this.fuelBox.Location = new System.Drawing.Point(180, 107);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(207, 34);
            this.fuelBox.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 81;
            this.label3.Text = "Объём";
            // 
            // volumeBox
            // 
            this.volumeBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.volumeBox.FormattingEnabled = true;
            this.volumeBox.Location = new System.Drawing.Point(180, 147);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.Size = new System.Drawing.Size(207, 34);
            this.volumeBox.TabIndex = 80;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.nameBox.Location = new System.Drawing.Point(180, 187);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(207, 33);
            this.nameBox.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 82;
            this.label4.Text = "Наименование";
            // 
            // cylindersBox
            // 
            this.cylindersBox.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.cylindersBox.Location = new System.Drawing.Point(180, 226);
            this.cylindersBox.Name = "cylindersBox";
            this.cylindersBox.Size = new System.Drawing.Size(207, 33);
            this.cylindersBox.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 84;
            this.label5.Text = "Цилиндры";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(120, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 47);
            this.button5.TabIndex = 86;
            this.button5.Text = "Добавить двигатель";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddEngineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(461, 358);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cylindersBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelBox);
            this.Controls.Add(this.gendLbl);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEngineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEngineFrm";
            this.Load += new System.EventHandler(this.AddEngineFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gendLbl;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fuelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox volumeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cylindersBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
    }
}