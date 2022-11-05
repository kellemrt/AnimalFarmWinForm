namespace AnimalFarm
{
    partial class AnimalListAndSaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalListAndSaveForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAnimalList = new System.Windows.Forms.DataGridView();
            this.tbxAniamalNote = new System.Windows.Forms.TextBox();
            this.tbxAnimalWeight = new System.Windows.Forms.TextBox();
            this.tbxAnimalKind = new System.Windows.Forms.TextBox();
            this.tbxAnimalCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWeightShow = new FontAwesome.Sharp.IconButton();
            this.btnDelete1 = new FontAwesome.Sharp.IconButton();
            this.btnUpdate1 = new FontAwesome.Sharp.IconButton();
            this.btnInsert1 = new FontAwesome.Sharp.IconButton();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalListModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(327, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Not :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(64, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ağırlığı :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(79, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cinsi :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Küpe Numarası :";
            // 
            // dataGridAnimalList
            // 
            this.dataGridAnimalList.AllowUserToAddRows = false;
            this.dataGridAnimalList.AllowUserToDeleteRows = false;
            this.dataGridAnimalList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAnimalList.AutoGenerateColumns = false;
            this.dataGridAnimalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnimalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIdDataGridViewTextBoxColumn,
            this.animalCodeDataGridViewTextBoxColumn,
            this.animalKindDataGridViewTextBoxColumn,
            this.animalNoteDataGridViewTextBoxColumn,
            this.animalSaveDateDataGridViewTextBoxColumn});
            this.dataGridAnimalList.DataSource = this.animalListModelBindingSource;
            this.dataGridAnimalList.Location = new System.Drawing.Point(12, 195);
            this.dataGridAnimalList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAnimalList.Name = "dataGridAnimalList";
            this.dataGridAnimalList.ReadOnly = true;
            this.dataGridAnimalList.RowHeadersWidth = 51;
            this.dataGridAnimalList.RowTemplate.Height = 24;
            this.dataGridAnimalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnimalList.Size = new System.Drawing.Size(962, 278);
            this.dataGridAnimalList.TabIndex = 7;
            this.dataGridAnimalList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAnimalList_CellDoubleClick);
            // 
            // tbxAniamalNote
            // 
            this.tbxAniamalNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAniamalNote.Location = new System.Drawing.Point(376, 35);
            this.tbxAniamalNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAniamalNote.Multiline = true;
            this.tbxAniamalNote.Name = "tbxAniamalNote";
            this.tbxAniamalNote.Size = new System.Drawing.Size(120, 99);
            this.tbxAniamalNote.TabIndex = 4;
            // 
            // tbxAnimalWeight
            // 
            this.tbxAnimalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnimalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbxAnimalWeight.Location = new System.Drawing.Point(138, 109);
            this.tbxAnimalWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnimalWeight.Name = "tbxAnimalWeight";
            this.tbxAnimalWeight.Size = new System.Drawing.Size(177, 26);
            this.tbxAnimalWeight.TabIndex = 3;
            // 
            // tbxAnimalKind
            // 
            this.tbxAnimalKind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnimalKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbxAnimalKind.Location = new System.Drawing.Point(138, 75);
            this.tbxAnimalKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnimalKind.Name = "tbxAnimalKind";
            this.tbxAnimalKind.Size = new System.Drawing.Size(177, 26);
            this.tbxAnimalKind.TabIndex = 2;
            // 
            // tbxAnimalCode
            // 
            this.tbxAnimalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnimalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbxAnimalCode.Location = new System.Drawing.Point(138, 38);
            this.tbxAnimalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAnimalCode.Name = "tbxAnimalCode";
            this.tbxAnimalCode.Size = new System.Drawing.Size(177, 26);
            this.tbxAnimalCode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxAniamalNote);
            this.groupBox1.Controls.Add(this.tbxAnimalWeight);
            this.groupBox1.Controls.Add(this.tbxAnimalKind);
            this.groupBox1.Controls.Add(this.tbxAnimalCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvan Bilgileri: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWeightShow);
            this.groupBox2.Controls.Add(this.btnDelete1);
            this.groupBox2.Controls.Add(this.btnUpdate1);
            this.groupBox2.Controls.Add(this.btnInsert1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(589, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 161);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler: ";
            // 
            // btnWeightShow
            // 
            this.btnWeightShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeightShow.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.btnWeightShow.IconColor = System.Drawing.Color.Black;
            this.btnWeightShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWeightShow.IconSize = 25;
            this.btnWeightShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeightShow.Location = new System.Drawing.Point(217, 37);
            this.btnWeightShow.Name = "btnWeightShow";
            this.btnWeightShow.Size = new System.Drawing.Size(156, 37);
            this.btnWeightShow.TabIndex = 9;
            this.btnWeightShow.Text = "Ağırlık Göster";
            this.btnWeightShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWeightShow.UseVisualStyleBackColor = true;
            this.btnWeightShow.Click += new System.EventHandler(this.btnWeightShow_Click_1);
            // 
            // btnDelete1
            // 
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnDelete1.IconColor = System.Drawing.Color.Black;
            this.btnDelete1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete1.IconSize = 25;
            this.btnDelete1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete1.Location = new System.Drawing.Point(217, 96);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(156, 37);
            this.btnDelete1.TabIndex = 9;
            this.btnDelete1.Text = "Kayıt Sil";
            this.btnDelete1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnUpdate1.IconColor = System.Drawing.Color.Black;
            this.btnUpdate1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate1.IconSize = 25;
            this.btnUpdate1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate1.Location = new System.Drawing.Point(18, 96);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(156, 37);
            this.btnUpdate1.TabIndex = 9;
            this.btnUpdate1.Text = "Kayıt Güncelle";
            this.btnUpdate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnInsert1
            // 
            this.btnInsert1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnInsert1.IconColor = System.Drawing.Color.Black;
            this.btnInsert1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsert1.IconSize = 25;
            this.btnInsert1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert1.Location = new System.Drawing.Point(18, 36);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(156, 37);
            this.btnInsert1.TabIndex = 9;
            this.btnInsert1.Text = "Yeni Kayıt";
            this.btnInsert1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert1.UseVisualStyleBackColor = true;
            this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.FillWeight = 55F;
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "Hayvan ID";
            this.animalIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalCodeDataGridViewTextBoxColumn
            // 
            this.animalCodeDataGridViewTextBoxColumn.DataPropertyName = "AnimalCode";
            this.animalCodeDataGridViewTextBoxColumn.HeaderText = "Küpe Numarası";
            this.animalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalCodeDataGridViewTextBoxColumn.Name = "animalCodeDataGridViewTextBoxColumn";
            this.animalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalKindDataGridViewTextBoxColumn
            // 
            this.animalKindDataGridViewTextBoxColumn.DataPropertyName = "AnimalKind";
            this.animalKindDataGridViewTextBoxColumn.HeaderText = "Cinsi";
            this.animalKindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalKindDataGridViewTextBoxColumn.Name = "animalKindDataGridViewTextBoxColumn";
            this.animalKindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalNoteDataGridViewTextBoxColumn
            // 
            this.animalNoteDataGridViewTextBoxColumn.DataPropertyName = "AnimalNote";
            this.animalNoteDataGridViewTextBoxColumn.HeaderText = "Not";
            this.animalNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalNoteDataGridViewTextBoxColumn.Name = "animalNoteDataGridViewTextBoxColumn";
            this.animalNoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalSaveDateDataGridViewTextBoxColumn
            // 
            this.animalSaveDateDataGridViewTextBoxColumn.DataPropertyName = "AnimalSaveDate";
            this.animalSaveDateDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.animalSaveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalSaveDateDataGridViewTextBoxColumn.Name = "animalSaveDateDataGridViewTextBoxColumn";
            this.animalSaveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalListModelBindingSource
            // 
            this.animalListModelBindingSource.DataSource = typeof(AnimalFarm.Data.Model.AnimalListModel);
            // 
            // AnimalListAndSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridAnimalList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnimalListAndSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BESİ İŞLEMLERİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalListAndSaveForm_FormClosed);
            this.Load += new System.EventHandler(this.AnimalListAndSaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalListModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAnimalList;
        private System.Windows.Forms.TextBox tbxAniamalNote;
        private System.Windows.Forms.TextBox tbxAnimalWeight;
        private System.Windows.Forms.TextBox tbxAnimalKind;
        private System.Windows.Forms.TextBox tbxAnimalCode;
        private System.Windows.Forms.BindingSource animalListModelBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalSaveDateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnInsert1;
        private FontAwesome.Sharp.IconButton btnDelete1;
        private FontAwesome.Sharp.IconButton btnUpdate1;
        private FontAwesome.Sharp.IconButton btnWeightShow;
    }
}