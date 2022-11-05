namespace AnimalFarm.Pages
{
    partial class AnimalWeightShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalWeightShowForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalWeightDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalWeightModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAnimalWeightSearch = new System.Windows.Forms.TextBox();
            this.ıconbtnAnimalWeightSearch = new FontAwesome.Sharp.IconButton();
            this.materialPictureBox2 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalWeightModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.animalIdDataGridViewTextBoxColumn,
            this.animalCodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.animalWeightDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalWeightModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalCodeDataGridViewTextBoxColumn
            // 
            this.animalCodeDataGridViewTextBoxColumn.DataPropertyName = "AnimalCode";
            this.animalCodeDataGridViewTextBoxColumn.HeaderText = "Hayvan Kodu";
            this.animalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalCodeDataGridViewTextBoxColumn.Name = "animalCodeDataGridViewTextBoxColumn";
            this.animalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalWeight";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hayvan Ağırlığı";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // animalWeightDateDataGridViewTextBoxColumn
            // 
            this.animalWeightDateDataGridViewTextBoxColumn.DataPropertyName = "AnimalWeightDate";
            this.animalWeightDateDataGridViewTextBoxColumn.HeaderText = "Ölçüm Tarihi";
            this.animalWeightDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalWeightDateDataGridViewTextBoxColumn.Name = "animalWeightDateDataGridViewTextBoxColumn";
            this.animalWeightDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalWeightModelBindingSource
            // 
            this.animalWeightModelBindingSource.DataSource = typeof(AnimalFarm.Data.Model.AnimalWeightModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Küpe Numarası:";
            // 
            // tbxAnimalWeightSearch
            // 
            this.tbxAnimalWeightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAnimalWeightSearch.Location = new System.Drawing.Point(226, 46);
            this.tbxAnimalWeightSearch.Name = "tbxAnimalWeightSearch";
            this.tbxAnimalWeightSearch.Size = new System.Drawing.Size(169, 30);
            this.tbxAnimalWeightSearch.TabIndex = 2;
            // 
            // ıconbtnAnimalWeightSearch
            // 
            this.ıconbtnAnimalWeightSearch.FlatAppearance.BorderSize = 0;
            this.ıconbtnAnimalWeightSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconbtnAnimalWeightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconbtnAnimalWeightSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ıconbtnAnimalWeightSearch.IconColor = System.Drawing.Color.Black;
            this.ıconbtnAnimalWeightSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconbtnAnimalWeightSearch.IconSize = 40;
            this.ıconbtnAnimalWeightSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconbtnAnimalWeightSearch.Location = new System.Drawing.Point(430, 30);
            this.ıconbtnAnimalWeightSearch.Name = "ıconbtnAnimalWeightSearch";
            this.ıconbtnAnimalWeightSearch.Size = new System.Drawing.Size(204, 62);
            this.ıconbtnAnimalWeightSearch.TabIndex = 4;
            this.ıconbtnAnimalWeightSearch.Text = "Besi Ara";
            this.ıconbtnAnimalWeightSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconbtnAnimalWeightSearch.UseVisualStyleBackColor = true;
            this.ıconbtnAnimalWeightSearch.Click += new System.EventHandler(this.ıconbtnAnimalWeightSearch_Click);
            // 
            // materialPictureBox2
            // 
            this.materialPictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox2.IconChar = FontAwesome.Sharp.MaterialIcons.WindowClose;
            this.materialPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox2.IconSize = 54;
            this.materialPictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialPictureBox2.Location = new System.Drawing.Point(743, 0);
            this.materialPictureBox2.Name = "materialPictureBox2";
            this.materialPictureBox2.Size = new System.Drawing.Size(59, 54);
            this.materialPictureBox2.TabIndex = 12;
            this.materialPictureBox2.TabStop = false;
            this.materialPictureBox2.Click += new System.EventHandler(this.materialPictureBox2_Click);
            // 
            // AnimalWeightShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialPictureBox2);
            this.Controls.Add(this.ıconbtnAnimalWeightSearch);
            this.Controls.Add(this.tbxAnimalWeightSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalWeightShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BESİ AĞIRLIK RAPORU";
            this.Load += new System.EventHandler(this.AnimalWeightShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalWeightModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAnimalWeightSearch;
        private System.Windows.Forms.BindingSource animalWeightModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalWeightDateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton ıconbtnAnimalWeightSearch;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox2;
    }
}