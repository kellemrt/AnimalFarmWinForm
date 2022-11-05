namespace AnimalFarm.Pages
{
    partial class AnimalProductivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalProductivityForm));
            this.dataAnimalProductivity = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalProductivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalProductivityModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimalProductivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalProductivityModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAnimalProductivity
            // 
            this.dataAnimalProductivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAnimalProductivity.AutoGenerateColumns = false;
            this.dataAnimalProductivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAnimalProductivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAnimalProductivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIDDataGridViewTextBoxColumn,
            this.animalCodeDataGridViewTextBoxColumn,
            this.animalProductivityDataGridViewTextBoxColumn});
            this.dataAnimalProductivity.DataSource = this.animalProductivityModelBindingSource;
            this.dataAnimalProductivity.Location = new System.Drawing.Point(18, 79);
            this.dataAnimalProductivity.Name = "dataAnimalProductivity";
            this.dataAnimalProductivity.RowHeadersWidth = 51;
            this.dataAnimalProductivity.Size = new System.Drawing.Size(948, 158);
            this.dataAnimalProductivity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BESİ VERİMLİLİĞİ :";
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "Besi ID";
            this.animalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            // 
            // animalCodeDataGridViewTextBoxColumn
            // 
            this.animalCodeDataGridViewTextBoxColumn.DataPropertyName = "AnimalCode";
            this.animalCodeDataGridViewTextBoxColumn.FillWeight = 60F;
            this.animalCodeDataGridViewTextBoxColumn.HeaderText = "Besi Küpe Kodu";
            this.animalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalCodeDataGridViewTextBoxColumn.Name = "animalCodeDataGridViewTextBoxColumn";
            // 
            // animalProductivityDataGridViewTextBoxColumn
            // 
            this.animalProductivityDataGridViewTextBoxColumn.DataPropertyName = "AnimalProductivity";
            this.animalProductivityDataGridViewTextBoxColumn.HeaderText = "Besi Verimliliği";
            this.animalProductivityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalProductivityDataGridViewTextBoxColumn.Name = "animalProductivityDataGridViewTextBoxColumn";
            // 
            // animalProductivityModelBindingSource
            // 
            this.animalProductivityModelBindingSource.DataSource = typeof(AnimalFarm.Data.Model.AnimalProductivityModel);
            // 
            // AnimalProductivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataAnimalProductivity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalProductivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BESİ VERİMLİLİK RAPORU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalProductivityForm_FormClosed);
            this.Load += new System.EventHandler(this.AnimalProductivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnimalProductivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalProductivityModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAnimalProductivity;
        private System.Windows.Forms.BindingSource animalProductivityModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalProductivityDataGridViewTextBoxColumn;
    }
}