namespace AnimalFarm.Pages
{
    partial class AnimalVeccineForm
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
            this.dataGridAnimalVeccine = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veccineDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veccineKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalVeccineListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendarVeccine = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimalCode = new System.Windows.Forms.ComboBox();
            this.tbxVeccineKind = new System.Windows.Forms.TextBox();
            this.btnVeccineSave = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnVeccineDelete = new FontAwesome.Sharp.Material.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalVeccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVeccineListModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAnimalVeccine
            // 
            this.dataGridAnimalVeccine.AllowUserToAddRows = false;
            this.dataGridAnimalVeccine.AllowUserToDeleteRows = false;
            this.dataGridAnimalVeccine.AutoGenerateColumns = false;
            this.dataGridAnimalVeccine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAnimalVeccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnimalVeccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.animalCodeDataGridViewTextBoxColumn,
            this.veccineDateDataGridViewTextBoxColumn,
            this.veccineKindDataGridViewTextBoxColumn});
            this.dataGridAnimalVeccine.DataSource = this.animalVeccineListModelBindingSource;
            this.dataGridAnimalVeccine.Location = new System.Drawing.Point(11, 62);
            this.dataGridAnimalVeccine.MultiSelect = false;
            this.dataGridAnimalVeccine.Name = "dataGridAnimalVeccine";
            this.dataGridAnimalVeccine.ReadOnly = true;
            this.dataGridAnimalVeccine.RowHeadersWidth = 51;
            this.dataGridAnimalVeccine.RowTemplate.Height = 24;
            this.dataGridAnimalVeccine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnimalVeccine.Size = new System.Drawing.Size(696, 415);
            this.dataGridAnimalVeccine.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalCodeDataGridViewTextBoxColumn
            // 
            this.animalCodeDataGridViewTextBoxColumn.DataPropertyName = "AnimalCode";
            this.animalCodeDataGridViewTextBoxColumn.FillWeight = 80F;
            this.animalCodeDataGridViewTextBoxColumn.HeaderText = "Küpe Kodu";
            this.animalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalCodeDataGridViewTextBoxColumn.Name = "animalCodeDataGridViewTextBoxColumn";
            this.animalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veccineDateDataGridViewTextBoxColumn
            // 
            this.veccineDateDataGridViewTextBoxColumn.DataPropertyName = "VeccineDate";
            this.veccineDateDataGridViewTextBoxColumn.HeaderText = "Aşı Tarihi";
            this.veccineDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veccineDateDataGridViewTextBoxColumn.Name = "veccineDateDataGridViewTextBoxColumn";
            this.veccineDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veccineKindDataGridViewTextBoxColumn
            // 
            this.veccineKindDataGridViewTextBoxColumn.DataPropertyName = "VeccineKind";
            this.veccineKindDataGridViewTextBoxColumn.HeaderText = "Aşı Tipi";
            this.veccineKindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veccineKindDataGridViewTextBoxColumn.Name = "veccineKindDataGridViewTextBoxColumn";
            this.veccineKindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalVeccineListModelBindingSource
            // 
            this.animalVeccineListModelBindingSource.DataSource = typeof(AnimalFarm.Data.Model.AnimalVeccineListModel);
            // 
            // monthCalendarVeccine
            // 
            this.monthCalendarVeccine.Location = new System.Drawing.Point(742, 90);
            this.monthCalendarVeccine.MaxSelectionCount = 1;
            this.monthCalendarVeccine.Name = "monthCalendarVeccine";
            this.monthCalendarVeccine.ShowWeekNumbers = true;
            this.monthCalendarVeccine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(739, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Küpe Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(759, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aşı Tipi : ";
            // 
            // cmbAnimalCode
            // 
            this.cmbAnimalCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAnimalCode.FormattingEnabled = true;
            this.cmbAnimalCode.Location = new System.Drawing.Point(841, 316);
            this.cmbAnimalCode.MaxDropDownItems = 15;
            this.cmbAnimalCode.Name = "cmbAnimalCode";
            this.cmbAnimalCode.Size = new System.Drawing.Size(189, 33);
            this.cmbAnimalCode.TabIndex = 3;
            // 
            // tbxVeccineKind
            // 
            this.tbxVeccineKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxVeccineKind.Location = new System.Drawing.Point(841, 358);
            this.tbxVeccineKind.Name = "tbxVeccineKind";
            this.tbxVeccineKind.Size = new System.Drawing.Size(189, 30);
            this.tbxVeccineKind.TabIndex = 4;
            // 
            // btnVeccineSave
            // 
            this.btnVeccineSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeccineSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeccineSave.IconChar = FontAwesome.Sharp.MaterialIcons.CalendarPlus;
            this.btnVeccineSave.IconColor = System.Drawing.Color.Black;
            this.btnVeccineSave.IconSize = 30;
            this.btnVeccineSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeccineSave.Location = new System.Drawing.Point(742, 395);
            this.btnVeccineSave.Name = "btnVeccineSave";
            this.btnVeccineSave.Size = new System.Drawing.Size(288, 36);
            this.btnVeccineSave.TabIndex = 5;
            this.btnVeccineSave.Text = "Kayıt Ekle";
            this.btnVeccineSave.UseVisualStyleBackColor = true;
            this.btnVeccineSave.Click += new System.EventHandler(this.btnVeccineSave_Click);
            // 
            // btnVeccineDelete
            // 
            this.btnVeccineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeccineDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeccineDelete.IconChar = FontAwesome.Sharp.MaterialIcons.CalendarMinus;
            this.btnVeccineDelete.IconColor = System.Drawing.Color.Black;
            this.btnVeccineDelete.IconSize = 30;
            this.btnVeccineDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeccineDelete.Location = new System.Drawing.Point(742, 437);
            this.btnVeccineDelete.Name = "btnVeccineDelete";
            this.btnVeccineDelete.Size = new System.Drawing.Size(288, 36);
            this.btnVeccineDelete.TabIndex = 5;
            this.btnVeccineDelete.Text = "Kayıt Sil";
            this.btnVeccineDelete.UseVisualStyleBackColor = true;
            this.btnVeccineDelete.Click += new System.EventHandler(this.btnVeccineDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Silme işlemi İçin Kayıt Seçiniz..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "AŞI TAKVİMİ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(739, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "*Aşı Tarihi Seçiniz:";
            // 
            // AnimalVeccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVeccineDelete);
            this.Controls.Add(this.btnVeccineSave);
            this.Controls.Add(this.tbxVeccineKind);
            this.Controls.Add(this.cmbAnimalCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarVeccine);
            this.Controls.Add(this.dataGridAnimalVeccine);
            this.Name = "AnimalVeccineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalVeccineForm";
            this.Load += new System.EventHandler(this.AnimalVeccineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalVeccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVeccineListModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAnimalVeccine;
        private System.Windows.Forms.MonthCalendar monthCalendarVeccine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimalCode;
        private System.Windows.Forms.TextBox tbxVeccineKind;
        private FontAwesome.Sharp.Material.MaterialButton btnVeccineSave;
        private FontAwesome.Sharp.Material.MaterialButton btnVeccineDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalVeccineListModelBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veccineDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veccineKindDataGridViewTextBoxColumn;
    }
}