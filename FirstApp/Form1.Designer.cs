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
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملف1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملف2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعدادات2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDAge = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_add_Click);
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
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // lable
            // 
            resources.ApplyResources(this.lable, "lable");
            this.lable.Name = "lable";
            this.lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // NUDAge
            // 
            this.NUDAge.DecimalPlaces = 2;
            resources.ApplyResources(this.NUDAge, "NUDAge");
            this.NUDAge.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDAge.Name = "NUDAge";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.NUDAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملف1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملف2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعداداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعدادات2ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDAge;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
    }
}

