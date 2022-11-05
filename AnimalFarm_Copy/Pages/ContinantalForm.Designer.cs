using System.Windows.Shapes;

namespace AnimalFarm
{
    partial class ContinantalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinantalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductAndInventory = new FontAwesome.Sharp.IconButton();
            this.btnAnimalVeccine = new FontAwesome.Sharp.IconButton();
            this.btnAnimalProductivity = new FontAwesome.Sharp.IconButton();
            this.btnAnimalSaveAndList = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialPictureBoxMin = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.materialPictureBoxMaks = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.materialPictureBox2 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnUserSetting = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBoxMaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUserSetting);
            this.panel1.Controls.Add(this.btnProductAndInventory);
            this.panel1.Controls.Add(this.btnAnimalVeccine);
            this.panel1.Controls.Add(this.btnAnimalProductivity);
            this.panel1.Controls.Add(this.btnAnimalSaveAndList);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnProductAndInventory
            // 
            resources.ApplyResources(this.btnProductAndInventory, "btnProductAndInventory");
            this.btnProductAndInventory.FlatAppearance.BorderSize = 0;
            this.btnProductAndInventory.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnProductAndInventory.IconColor = System.Drawing.Color.Black;
            this.btnProductAndInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductAndInventory.Name = "btnProductAndInventory";
            this.btnProductAndInventory.UseVisualStyleBackColor = true;
            this.btnProductAndInventory.Click += new System.EventHandler(this.btnProductAndInventory_Click);
            // 
            // btnAnimalVeccine
            // 
            resources.ApplyResources(this.btnAnimalVeccine, "btnAnimalVeccine");
            this.btnAnimalVeccine.FlatAppearance.BorderSize = 0;
            this.btnAnimalVeccine.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.btnAnimalVeccine.IconColor = System.Drawing.Color.Black;
            this.btnAnimalVeccine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnimalVeccine.Name = "btnAnimalVeccine";
            this.btnAnimalVeccine.UseVisualStyleBackColor = true;
            this.btnAnimalVeccine.Click += new System.EventHandler(this.btnAnimalVeccine_Click);
            // 
            // btnAnimalProductivity
            // 
            resources.ApplyResources(this.btnAnimalProductivity, "btnAnimalProductivity");
            this.btnAnimalProductivity.FlatAppearance.BorderSize = 0;
            this.btnAnimalProductivity.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnAnimalProductivity.IconColor = System.Drawing.Color.Black;
            this.btnAnimalProductivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnimalProductivity.Name = "btnAnimalProductivity";
            this.btnAnimalProductivity.UseVisualStyleBackColor = true;
            this.btnAnimalProductivity.Click += new System.EventHandler(this.btnAnimalProductivity_Click);
            // 
            // btnAnimalSaveAndList
            // 
            resources.ApplyResources(this.btnAnimalSaveAndList, "btnAnimalSaveAndList");
            this.btnAnimalSaveAndList.FlatAppearance.BorderSize = 0;
            this.btnAnimalSaveAndList.IconChar = FontAwesome.Sharp.IconChar.Cow;
            this.btnAnimalSaveAndList.IconColor = System.Drawing.Color.Black;
            this.btnAnimalSaveAndList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnimalSaveAndList.Name = "btnAnimalSaveAndList";
            this.btnAnimalSaveAndList.UseVisualStyleBackColor = true;
            this.btnAnimalSaveAndList.Click += new System.EventHandler(this.btnAnimalSaveAndList_Click);
            // 
            // btnDashboard
            // 
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashboard.IconColor = System.Drawing.Color.Black;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.materialPictureBoxMin);
            this.panel3.Controls.Add(this.materialPictureBoxMaks);
            this.panel3.Controls.Add(this.materialPictureBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // materialPictureBoxMin
            // 
            this.materialPictureBoxMin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialPictureBoxMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBoxMin.IconChar = FontAwesome.Sharp.MaterialIcons.WindowMinimize;
            this.materialPictureBoxMin.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBoxMin.IconSize = 56;
            resources.ApplyResources(this.materialPictureBoxMin, "materialPictureBoxMin");
            this.materialPictureBoxMin.Name = "materialPictureBoxMin";
            this.materialPictureBoxMin.TabStop = false;
            this.materialPictureBoxMin.Click += new System.EventHandler(this.materialPictureBoxMin_Click);
            // 
            // materialPictureBoxMaks
            // 
            this.materialPictureBoxMaks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialPictureBoxMaks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBoxMaks.IconChar = FontAwesome.Sharp.MaterialIcons.WindowMaximize;
            this.materialPictureBoxMaks.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBoxMaks.IconSize = 51;
            resources.ApplyResources(this.materialPictureBoxMaks, "materialPictureBoxMaks");
            this.materialPictureBoxMaks.Name = "materialPictureBoxMaks";
            this.materialPictureBoxMaks.TabStop = false;
            this.materialPictureBoxMaks.Click += new System.EventHandler(this.materialPictureBoxMaks_Click);
            // 
            // materialPictureBox2
            // 
            this.materialPictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox2.IconChar = FontAwesome.Sharp.MaterialIcons.WindowClose;
            this.materialPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox2.IconSize = 51;
            resources.ApplyResources(this.materialPictureBox2, "materialPictureBox2");
            this.materialPictureBox2.Name = "materialPictureBox2";
            this.materialPictureBox2.TabStop = false;
            this.materialPictureBox2.Click += new System.EventHandler(this.materialPictureBox2_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.CausesValidation = false;
            this.panelDesktop.Name = "panelDesktop";
            // 
            // btnUserSetting
            // 
            resources.ApplyResources(this.btnUserSetting, "btnUserSetting");
            this.btnUserSetting.FlatAppearance.BorderSize = 0;
            this.btnUserSetting.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUserSetting.IconColor = System.Drawing.Color.Black;
            this.btnUserSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.UseVisualStyleBackColor = true;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // ContinantalForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContinantalForm";
            this.Load += new System.EventHandler(this.ContinantalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBoxMaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAnimalProductivity;
        private FontAwesome.Sharp.IconButton btnAnimalSaveAndList;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox2;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnAnimalVeccine;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBoxMin;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBoxMaks;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnProductAndInventory;
        private FontAwesome.Sharp.IconButton btnUserSetting;
    }
}