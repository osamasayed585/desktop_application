namespace FirstApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملف1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملف2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعدادات2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.اعداداتToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملف1ToolStripMenuItem,
            this.ملف2ToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            resources.ApplyResources(this.ملفToolStripMenuItem, "ملفToolStripMenuItem");
            // 
            // ملف1ToolStripMenuItem
            // 
            this.ملف1ToolStripMenuItem.Name = "ملف1ToolStripMenuItem";
            resources.ApplyResources(this.ملف1ToolStripMenuItem, "ملف1ToolStripMenuItem");
            // 
            // ملف2ToolStripMenuItem
            // 
            this.ملف2ToolStripMenuItem.Name = "ملف2ToolStripMenuItem";
            resources.ApplyResources(this.ملف2ToolStripMenuItem, "ملف2ToolStripMenuItem");
            // 
            // اعداداتToolStripMenuItem
            // 
            this.اعداداتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعدادات2ToolStripMenuItem});
            this.اعداداتToolStripMenuItem.Name = "اعداداتToolStripMenuItem";
            resources.ApplyResources(this.اعداداتToolStripMenuItem, "اعداداتToolStripMenuItem");
            // 
            // اعدادات2ToolStripMenuItem
            // 
            this.اعدادات2ToolStripMenuItem.Name = "اعدادات2ToolStripMenuItem";
            resources.ApplyResources(this.اعدادات2ToolStripMenuItem, "اعدادات2ToolStripMenuItem");
            // 
            // txtBox1
            // 
            resources.ApplyResources(this.txtBox1, "txtBox1");
            this.txtBox1.Name = "txtBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملف1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملف2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعداداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعدادات2ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label1;
    }
}

