namespace FormaProgram
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
            this.btnRun = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxRun = new System.Windows.Forms.GroupBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TXTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FonttoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionstoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbouttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRun.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(212, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(136, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run program";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blok za pisanje",
            "Bojanje"});
            this.comboBox1.Location = new System.Drawing.Point(6, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Checked = true;
            this.checkBoxShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShow.Location = new System.Drawing.Point(43, 171);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(126, 17);
            this.checkBoxShow.TabIndex = 3;
            this.checkBoxShow.Text = "Show program action";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(6, 56);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(149, 20);
            this.txtBoxName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Program name:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Program description:";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(6, 128);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(149, 87);
            this.txtBoxDescription.TabIndex = 9;
            // 
            // groupBoxRun
            // 
            this.groupBoxRun.Controls.Add(this.comboBox1);
            this.groupBoxRun.Controls.Add(this.btnRun);
            this.groupBoxRun.Location = new System.Drawing.Point(43, 34);
            this.groupBoxRun.Name = "groupBoxRun";
            this.groupBoxRun.Size = new System.Drawing.Size(354, 107);
            this.groupBoxRun.TabIndex = 10;
            this.groupBoxRun.TabStop = false;
            this.groupBoxRun.Text = "Run a program";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.label4);
            this.groupBoxControl.Controls.Add(this.txtBoxDescription);
            this.groupBoxControl.Controls.Add(this.label3);
            this.groupBoxControl.Controls.Add(this.txtBoxName);
            this.groupBoxControl.Controls.Add(this.btnClear);
            this.groupBoxControl.Location = new System.Drawing.Point(43, 217);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(354, 221);
            this.groupBoxControl.TabIndex = 11;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Program control";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TXTtoolStripMenuItem,
            this.toolStripSeparator4,
            this.FonttoolStripMenuItem2,
            this.toolStripSeparator3,
            this.OptionstoolStripMenuItem3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbouttoolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // TXTtoolStripMenuItem
            // 
            this.TXTtoolStripMenuItem.Name = "TXTtoolStripMenuItem";
            this.TXTtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TXTtoolStripMenuItem.Text = "Text";
            this.TXTtoolStripMenuItem.Click += new System.EventHandler(this.TXTtoolStripMenuItem_Click);
            // 
            // FonttoolStripMenuItem2
            // 
            this.FonttoolStripMenuItem2.Name = "FonttoolStripMenuItem2";
            this.FonttoolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.FonttoolStripMenuItem2.Text = "Font";
            // 
            // OptionstoolStripMenuItem3
            // 
            this.OptionstoolStripMenuItem3.Name = "OptionstoolStripMenuItem3";
            this.OptionstoolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.OptionstoolStripMenuItem3.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // AbouttoolStripMenuItem
            // 
            this.AbouttoolStripMenuItem.Name = "AbouttoolStripMenuItem";
            this.AbouttoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AbouttoolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.groupBoxRun);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRun.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxRun;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TXTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FonttoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem OptionstoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbouttoolStripMenuItem;
    }
}

