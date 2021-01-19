
namespace GenericHost4Lib01.FormViews
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.palMain = new System.Windows.Forms.Panel();
            this.cboxImplementation = new System.Windows.Forms.ComboBox();
            this.btnGetOnlyDirect = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnGetTiga = new System.Windows.Forms.Button();
            this.btnGetMax = new System.Windows.Forms.Button();
            this.btnGetMebius = new System.Windows.Forms.Button();
            this.btnGetGaia = new System.Windows.Forms.Button();
            this.btnGetDyna = new System.Windows.Forms.Button();
            this.btnGetAgul = new System.Windows.Forms.Button();
            this.btnGetDirect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 21);
            this.toolStripMenuItem1.Text = " 文件";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(48, 21);
            this.toolStripMenuItem2.Text = " 编辑";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem3.Text = "视图";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = " 编程是一门艺术";
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.label1);
            this.palMain.Controls.Add(this.cboxImplementation);
            this.palMain.Controls.Add(this.btnGetOnlyDirect);
            this.palMain.Controls.Add(this.lstDisplay);
            this.palMain.Controls.Add(this.btnGetTiga);
            this.palMain.Controls.Add(this.btnGetMax);
            this.palMain.Controls.Add(this.btnGetMebius);
            this.palMain.Controls.Add(this.btnGetGaia);
            this.palMain.Controls.Add(this.btnGetDyna);
            this.palMain.Controls.Add(this.btnGetAgul);
            this.palMain.Controls.Add(this.btnGetDirect);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(0, 25);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1008, 682);
            this.palMain.TabIndex = 2;
            // 
            // cboxImplementation
            // 
            this.cboxImplementation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxImplementation.FormattingEnabled = true;
            this.cboxImplementation.Items.AddRange(new object[] {
            "Ultraman Agul",
            "Ultraman Dyna",
            "Ultraman Gaia",
            "Ultraman Max",
            "Ultraman Mebius",
            "Ultraman Tiga"});
            this.cboxImplementation.Location = new System.Drawing.Point(52, 99);
            this.cboxImplementation.Name = "cboxImplementation";
            this.cboxImplementation.Size = new System.Drawing.Size(180, 25);
            this.cboxImplementation.TabIndex = 5;
            // 
            // btnGetOnlyDirect
            // 
            this.btnGetOnlyDirect.Location = new System.Drawing.Point(52, 130);
            this.btnGetOnlyDirect.Name = "btnGetOnlyDirect";
            this.btnGetOnlyDirect.Size = new System.Drawing.Size(180, 32);
            this.btnGetOnlyDirect.TabIndex = 4;
            this.btnGetOnlyDirect.Text = "Get selected objects only";
            this.btnGetOnlyDirect.UseVisualStyleBackColor = true;
            this.btnGetOnlyDirect.Click += new System.EventHandler(this.btnGetOnly_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 17;
            this.lstDisplay.Location = new System.Drawing.Point(4, 300);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(1000, 378);
            this.lstDisplay.TabIndex = 2;
            // 
            // btnGetTiga
            // 
            this.btnGetTiga.Location = new System.Drawing.Point(604, 156);
            this.btnGetTiga.Name = "btnGetTiga";
            this.btnGetTiga.Size = new System.Drawing.Size(180, 32);
            this.btnGetTiga.TabIndex = 1;
            this.btnGetTiga.Text = "Get IUltramanTiga";
            this.btnGetTiga.UseVisualStyleBackColor = true;
            this.btnGetTiga.Click += new System.EventHandler(this.btnGetTiga_Click);
            // 
            // btnGetMax
            // 
            this.btnGetMax.Location = new System.Drawing.Point(604, 34);
            this.btnGetMax.Name = "btnGetMax";
            this.btnGetMax.Size = new System.Drawing.Size(180, 32);
            this.btnGetMax.TabIndex = 1;
            this.btnGetMax.Text = "Get IUltramanMax";
            this.btnGetMax.UseVisualStyleBackColor = true;
            this.btnGetMax.Click += new System.EventHandler(this.btnGetMax_Click);
            // 
            // btnGetMebius
            // 
            this.btnGetMebius.Location = new System.Drawing.Point(604, 95);
            this.btnGetMebius.Name = "btnGetMebius";
            this.btnGetMebius.Size = new System.Drawing.Size(180, 32);
            this.btnGetMebius.TabIndex = 1;
            this.btnGetMebius.Text = "Get IUltramanMebius";
            this.btnGetMebius.UseVisualStyleBackColor = true;
            this.btnGetMebius.Click += new System.EventHandler(this.btnGetMebius_Click);
            // 
            // btnGetGaia
            // 
            this.btnGetGaia.Location = new System.Drawing.Point(360, 156);
            this.btnGetGaia.Name = "btnGetGaia";
            this.btnGetGaia.Size = new System.Drawing.Size(180, 32);
            this.btnGetGaia.TabIndex = 1;
            this.btnGetGaia.Text = "Get IUltramanGaia";
            this.btnGetGaia.UseVisualStyleBackColor = true;
            this.btnGetGaia.Click += new System.EventHandler(this.btnGetGaia_Click);
            // 
            // btnGetDyna
            // 
            this.btnGetDyna.Location = new System.Drawing.Point(360, 95);
            this.btnGetDyna.Name = "btnGetDyna";
            this.btnGetDyna.Size = new System.Drawing.Size(180, 32);
            this.btnGetDyna.TabIndex = 1;
            this.btnGetDyna.Text = "Get IUltramanDyna";
            this.btnGetDyna.UseVisualStyleBackColor = true;
            this.btnGetDyna.Click += new System.EventHandler(this.btnGetDyna_Click);
            // 
            // btnGetAgul
            // 
            this.btnGetAgul.Location = new System.Drawing.Point(360, 34);
            this.btnGetAgul.Name = "btnGetAgul";
            this.btnGetAgul.Size = new System.Drawing.Size(180, 32);
            this.btnGetAgul.TabIndex = 1;
            this.btnGetAgul.Text = "Get IUltramanAgul";
            this.btnGetAgul.UseVisualStyleBackColor = true;
            this.btnGetAgul.Click += new System.EventHandler(this.btnGetAgul_Click);
            // 
            // btnGetDirect
            // 
            this.btnGetDirect.Location = new System.Drawing.Point(52, 34);
            this.btnGetDirect.Name = "btnGetDirect";
            this.btnGetDirect.Size = new System.Drawing.Size(180, 32);
            this.btnGetDirect.TabIndex = 0;
            this.btnGetDirect.Text = "Get IUltraman";
            this.btnGetDirect.UseVisualStyleBackColor = true;
            this.btnGetDirect.Click += new System.EventHandler(this.btnGetDirect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "试试浏览器访问： http://localhost:5000 或 http://localhost:5001 或 https://localhost:5002";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btnGetDirect;
        private System.Windows.Forms.Button btnGetAgul;
        private System.Windows.Forms.Button btnGetMax;
        private System.Windows.Forms.Button btnGetGaia;
        private System.Windows.Forms.Button btnGetDyna;
        private System.Windows.Forms.Button btnGetTiga;
        private System.Windows.Forms.Button btnGetMebius;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cboxImplementation;
        private System.Windows.Forms.Button btnGetOnlyDirect;
        private System.Windows.Forms.Label label1;
    }
}