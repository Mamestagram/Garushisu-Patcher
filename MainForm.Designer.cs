namespace garushisu_patcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOsuPath = new System.Windows.Forms.Label();
            this.textboxOsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textboxAkatsukiPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Kristen ITC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleName.Location = new System.Drawing.Point(16, 61);
            this.titleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(487, 68);
            this.titleName.TabIndex = 0;
            this.titleName.Text = "Garushisu Patcher";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClose});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(46, 26);
            this.MenuFile.Text = "File";
            // 
            // MenuClose
            // 
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(128, 26);
            this.MenuClose.Text = "Close";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(21, 176);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 35);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // textboxAddress
            // 
            this.textboxAddress.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAddress.Location = new System.Drawing.Point(28, 229);
            this.textboxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(259, 35);
            this.textboxAddress.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(515, 341);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOsuPath
            // 
            this.lblOsuPath.AutoSize = true;
            this.lblOsuPath.BackColor = System.Drawing.Color.Transparent;
            this.lblOsuPath.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsuPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOsuPath.Location = new System.Drawing.Point(21, 289);
            this.lblOsuPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOsuPath.Name = "lblOsuPath";
            this.lblOsuPath.Size = new System.Drawing.Size(140, 35);
            this.lblOsuPath.TabIndex = 5;
            this.lblOsuPath.Text = "osu!Folder";
            // 
            // textboxOsu
            // 
            this.textboxOsu.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxOsu.Location = new System.Drawing.Point(28, 341);
            this.textboxOsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxOsu.Name = "textboxOsu";
            this.textboxOsu.Size = new System.Drawing.Size(259, 35);
            this.textboxOsu.TabIndex = 6;
            this.textboxOsu.Click += new System.EventHandler(this.textboxOsu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(395, 180);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(250, 32);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Use Akatsuki Patcher";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textboxAkatsukiPath
            // 
            this.textboxAkatsukiPath.Enabled = false;
            this.textboxAkatsukiPath.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAkatsukiPath.Location = new System.Drawing.Point(395, 229);
            this.textboxAkatsukiPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxAkatsukiPath.Name = "textboxAkatsukiPath";
            this.textboxAkatsukiPath.Size = new System.Drawing.Size(259, 35);
            this.textboxAkatsukiPath.TabIndex = 9;
            this.textboxAkatsukiPath.Click += new System.EventHandler(this.textboxAkatsukiPath_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(395, 341);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 29);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSettings.Location = new System.Drawing.Point(388, 289);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(115, 35);
            this.lblSettings.TabIndex = 11;
            this.lblSettings.Text = "Settings";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(300, 436);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(239, 80);
            this.btnLaunch.TabIndex = 12;
            this.btnLaunch.Text = "Launch osu!";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 551);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textboxAkatsukiPath);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxOsu);
            this.Controls.Add(this.lblOsuPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Garushisu Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOsuPath;
        public System.Windows.Forms.TextBox textboxOsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox textboxAkatsukiPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnLaunch;
    }
}

