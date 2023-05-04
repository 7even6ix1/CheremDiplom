namespace VladDiplom
{
    partial class ClientsFrm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Controls.Add(this.clientBox);
            this.groupBox.Controls.Add(this.findBtn);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(18, 289);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(246, 158);
            this.groupBox.TabIndex = 54;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Поиск по фамилии";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(127, 85);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 61);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Сброс фильтрации";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clientBox
            // 
            this.clientBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.clientBox.Location = new System.Drawing.Point(16, 41);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(210, 29);
            this.clientBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(22, 85);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(99, 61);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Поиск клиента";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // docBtn
            // 
            this.docBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.docBtn.ForeColor = System.Drawing.Color.White;
            this.docBtn.Location = new System.Drawing.Point(456, 289);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(136, 70);
            this.docBtn.TabIndex = 46;
            this.docBtn.Text = "Печать документа";
            this.docBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(598, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 70);
            this.button1.TabIndex = 47;
            this.button1.Text = "Добавить автомобиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(740, 289);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "Добавить клиента";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(798, 8);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 49;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname,
            this.GridNameColumn,
            this.Patronymic,
            this.Phone,
            this.Gender,
            this.GosNomer,
            this.Mark,
            this.Model});
            this.dataGridView.Location = new System.Drawing.Point(15, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(861, 240);
            this.dataGridView.TabIndex = 53;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // GridNameColumn
            // 
            this.GridNameColumn.HeaderText = "Имя";
            this.GridNameColumn.Name = "GridNameColumn";
            this.GridNameColumn.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // GosNomer
            // 
            this.GosNomer.HeaderText = "Гос. номер";
            this.GosNomer.Name = "GosNomer";
            this.GosNomer.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Информация о клиентах";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(823, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 50;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(848, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 51;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ClientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
    }
}