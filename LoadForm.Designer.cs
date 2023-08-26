namespace garushisu_patcher
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPreset
            // 
            this.cmbPreset.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(145, 119);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(121, 31);
            this.cmbPreset.TabIndex = 0;
            this.cmbPreset.Text = "Presets";
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.BackColor = System.Drawing.Color.Transparent;
            this.lblPreset.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreset.Location = new System.Drawing.Point(12, 28);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(191, 28);
            this.lblPreset.TabIndex = 1;
            this.lblPreset.Text = "Load Your Preset!";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(163, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Preset name";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(13, 166);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Delete";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.cmbPreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadForm";
            this.Text = "Load Preset";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
    }
}