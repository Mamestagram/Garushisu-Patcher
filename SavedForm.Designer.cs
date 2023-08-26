namespace garushisu_patcher
{
    partial class SavedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedForm));
            this.lblPreset = new System.Windows.Forms.Label();
            this.textboxPreset = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.BackColor = System.Drawing.Color.Transparent;
            this.lblPreset.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreset.Location = new System.Drawing.Point(12, 31);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(185, 28);
            this.lblPreset.TabIndex = 2;
            this.lblPreset.Text = "Save Your Preset!";
            // 
            // textboxPreset
            // 
            this.textboxPreset.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPreset.Location = new System.Drawing.Point(104, 109);
            this.textboxPreset.Name = "textboxPreset";
            this.textboxPreset.Size = new System.Drawing.Size(195, 29);
            this.textboxPreset.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(163, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Preset name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(168, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SavedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textboxPreset);
            this.Controls.Add(this.lblPreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SavedForm";
            this.Text = "Save Preset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreset;
        public System.Windows.Forms.TextBox textboxPreset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
    }
}