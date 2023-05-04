namespace VladDiplom
{
    partial class MenuFrm
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
            this.workersBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.sdelkiBtn = new System.Windows.Forms.Button();
            this.carsBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.addSpravochnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // workersBtn
            // 
            this.workersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workersBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.workersBtn.ForeColor = System.Drawing.Color.White;
            this.workersBtn.Location = new System.Drawing.Point(34, 50);
            this.workersBtn.Name = "workersBtn";
            this.workersBtn.Size = new System.Drawing.Size(143, 92);
            this.workersBtn.TabIndex = 4;
            this.workersBtn.Text = "Информация о сотрудниках";
            this.workersBtn.UseVisualStyleBackColor = true;
            this.workersBtn.Click += new System.EventHandler(this.workersBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(788, 9);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(813, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(763, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 52;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sdelkiBtn
            // 
            this.sdelkiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sdelkiBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.sdelkiBtn.ForeColor = System.Drawing.Color.White;
            this.sdelkiBtn.Location = new System.Drawing.Point(200, 50);
            this.sdelkiBtn.Name = "sdelkiBtn";
            this.sdelkiBtn.Size = new System.Drawing.Size(143, 92);
            this.sdelkiBtn.TabIndex = 53;
            this.sdelkiBtn.Text = "Информация о сделках";
            this.sdelkiBtn.UseVisualStyleBackColor = true;
            this.sdelkiBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // carsBtn
            // 
            this.carsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carsBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.carsBtn.ForeColor = System.Drawing.Color.White;
            this.carsBtn.Location = new System.Drawing.Point(366, 50);
            this.carsBtn.Name = "carsBtn";
            this.carsBtn.Size = new System.Drawing.Size(143, 92);
            this.carsBtn.TabIndex = 54;
            this.carsBtn.Text = "Информация об автомобилях";
            this.carsBtn.UseVisualStyleBackColor = true;
            this.carsBtn.Click += new System.EventHandler(this.carsBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientsBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.clientsBtn.ForeColor = System.Drawing.Color.White;
            this.clientsBtn.Location = new System.Drawing.Point(532, 50);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(143, 92);
            this.clientsBtn.TabIndex = 55;
            this.clientsBtn.Text = "Информация о клиентах";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // addSpravochnik
            // 
            this.addSpravochnik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSpravochnik.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addSpravochnik.ForeColor = System.Drawing.Color.White;
            this.addSpravochnik.Location = new System.Drawing.Point(698, 50);
            this.addSpravochnik.Name = "addSpravochnik";
            this.addSpravochnik.Size = new System.Drawing.Size(143, 92);
            this.addSpravochnik.TabIndex = 56;
            this.addSpravochnik.Text = "Добавление справочников";
            this.addSpravochnik.UseVisualStyleBackColor = true;
            this.addSpravochnik.Visible = false;
            this.addSpravochnik.Click += new System.EventHandler(this.addSpravochnik_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(857, 162);
            this.Controls.Add(this.addSpravochnik);
            this.Controls.Add(this.clientsBtn);
            this.Controls.Add(this.carsBtn);
            this.Controls.Add(this.sdelkiBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.workersBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFrm";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button workersBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button sdelkiBtn;
        private System.Windows.Forms.Button carsBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button addSpravochnik;
    }
}