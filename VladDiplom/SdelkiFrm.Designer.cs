namespace VladDiplom
{
    partial class SdelkiFrm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.workerBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Buyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(881, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 54;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(906, 6);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 55;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(931, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 56;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.workBox);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Controls.Add(this.workerBox);
            this.groupBox.Controls.Add(this.findBtn);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(10, 298);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(503, 136);
            this.groupBox.TabIndex = 60;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Фильтрация";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Поиск по гос. номеру";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Поиск по фамилии";
            // 
            // workBox
            // 
            this.workBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.workBox.Location = new System.Drawing.Point(266, 41);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(210, 29);
            this.workBox.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(247, 88);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 33);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Сброс";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // workerBox
            // 
            this.workerBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.workerBox.Location = new System.Drawing.Point(16, 41);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(210, 29);
            this.workerBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(136, 88);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(105, 33);
            this.findBtn.TabIndex = 3;
            this.findBtn.Text = "Поиск";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // docBtn
            // 
            this.docBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.docBtn.ForeColor = System.Drawing.Color.White;
            this.docBtn.Location = new System.Drawing.Point(519, 298);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(136, 70);
            this.docBtn.TabIndex = 57;
            this.docBtn.Text = "Печать документа";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(661, 298);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 58;
            this.addBtn.Text = "Добавить сделку";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buyer,
            this.Phone,
            this.Mark,
            this.Model,
            this.GosNomer,
            this.Year,
            this.Summa,
            this.Seller,
            this.Date});
            this.dataGridView.Location = new System.Drawing.Point(4, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(955, 246);
            this.dataGridView.TabIndex = 59;
            // 
            // Buyer
            // 
            this.Buyer.HeaderText = "Покупатель";
            this.Buyer.Name = "Buyer";
            this.Buyer.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Марка";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // GosNomer
            // 
            this.GosNomer.HeaderText = "Госномер";
            this.GosNomer.Name = "GosNomer";
            this.GosNomer.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год выпуска";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Summa
            // 
            this.Summa.HeaderText = "Сумма";
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Продавец";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Информация о сделках";
            // 
            // SdelkiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SdelkiFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SdelkiFrm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox workerBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label1;
    }
}