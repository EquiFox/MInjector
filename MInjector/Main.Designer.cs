namespace MInjector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.processList = new System.Windows.Forms.ComboBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.hideAssemblyLoadCheck = new System.Windows.Forms.CheckBox();
            this.loadAsmBtn = new System.Windows.Forms.Button();
            this.asmPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hideAssemblyCheck = new System.Windows.Forms.CheckBox();
            this.methodTxtBox = new System.Windows.Forms.TextBox();
            this.classTxtBox = new System.Windows.Forms.TextBox();
            this.namespaceTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.injectBtn = new System.Windows.Forms.Button();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.targetGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetGroupBox
            // 
            this.targetGroupBox.Controls.Add(this.refreshBtn);
            this.targetGroupBox.Controls.Add(this.processList);
            this.targetGroupBox.Location = new System.Drawing.Point(12, 15);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Size = new System.Drawing.Size(319, 79);
            this.targetGroupBox.TabIndex = 0;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Target";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(230, 31);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // processList
            // 
            this.processList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(29, 32);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(195, 21);
            this.processList.TabIndex = 0;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.hideAssemblyLoadCheck);
            this.settingsGroupBox.Controls.Add(this.loadAsmBtn);
            this.settingsGroupBox.Controls.Add(this.asmPathTextBox);
            this.settingsGroupBox.Controls.Add(this.label4);
            this.settingsGroupBox.Controls.Add(this.hideAssemblyCheck);
            this.settingsGroupBox.Controls.Add(this.methodTxtBox);
            this.settingsGroupBox.Controls.Add(this.classTxtBox);
            this.settingsGroupBox.Controls.Add(this.namespaceTxtBox);
            this.settingsGroupBox.Controls.Add(this.label3);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Enabled = false;
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 98);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(319, 198);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // hideAssemblyLoadCheck
            // 
            this.hideAssemblyLoadCheck.AutoSize = true;
            this.hideAssemblyLoadCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideAssemblyLoadCheck.Location = new System.Drawing.Point(32, 149);
            this.hideAssemblyLoadCheck.Name = "hideAssemblyLoadCheck";
            this.hideAssemblyLoadCheck.Size = new System.Drawing.Size(255, 17);
            this.hideAssemblyLoadCheck.TabIndex = 6;
            this.hideAssemblyLoadCheck.Text = "Hide from AssemblyLoad Callback (Experimental)";
            this.hideAssemblyLoadCheck.UseVisualStyleBackColor = true;
            // 
            // loadAsmBtn
            // 
            this.loadAsmBtn.Location = new System.Drawing.Point(263, 24);
            this.loadAsmBtn.Name = "loadAsmBtn";
            this.loadAsmBtn.Size = new System.Drawing.Size(26, 23);
            this.loadAsmBtn.TabIndex = 2;
            this.loadAsmBtn.Text = "...";
            this.loadAsmBtn.UseVisualStyleBackColor = true;
            this.loadAsmBtn.Click += new System.EventHandler(this.loadAsmBtn_Click);
            // 
            // asmPathTextBox
            // 
            this.asmPathTextBox.Location = new System.Drawing.Point(118, 25);
            this.asmPathTextBox.Name = "asmPathTextBox";
            this.asmPathTextBox.ReadOnly = true;
            this.asmPathTextBox.Size = new System.Drawing.Size(142, 20);
            this.asmPathTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assembly:";
            // 
            // hideAssemblyCheck
            // 
            this.hideAssemblyCheck.AutoSize = true;
            this.hideAssemblyCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideAssemblyCheck.Location = new System.Drawing.Point(34, 173);
            this.hideAssemblyCheck.Name = "hideAssemblyCheck";
            this.hideAssemblyCheck.Size = new System.Drawing.Size(251, 17);
            this.hideAssemblyCheck.TabIndex = 7;
            this.hideAssemblyCheck.Text = "Hide from GetAssemblies Method (Experimental)";
            this.hideAssemblyCheck.UseVisualStyleBackColor = true;
            // 
            // methodTxtBox
            // 
            this.methodTxtBox.Location = new System.Drawing.Point(118, 113);
            this.methodTxtBox.Name = "methodTxtBox";
            this.methodTxtBox.Size = new System.Drawing.Size(171, 20);
            this.methodTxtBox.TabIndex = 5;
            // 
            // classTxtBox
            // 
            this.classTxtBox.Location = new System.Drawing.Point(118, 85);
            this.classTxtBox.Name = "classTxtBox";
            this.classTxtBox.Size = new System.Drawing.Size(171, 20);
            this.classTxtBox.TabIndex = 4;
            // 
            // namespaceTxtBox
            // 
            this.namespaceTxtBox.Location = new System.Drawing.Point(118, 57);
            this.namespaceTxtBox.Name = "namespaceTxtBox";
            this.namespaceTxtBox.Size = new System.Drawing.Size(171, 20);
            this.namespaceTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namespace: ";
            // 
            // injectBtn
            // 
            this.injectBtn.Enabled = false;
            this.injectBtn.Location = new System.Drawing.Point(12, 302);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(319, 44);
            this.injectBtn.TabIndex = 8;
            this.injectBtn.Text = "Inject !";
            this.injectBtn.UseVisualStyleBackColor = true;
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLbl.ForeColor = System.Drawing.Color.Blue;
            this.aboutLbl.Location = new System.Drawing.Point(302, 4);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(30, 12);
            this.aboutLbl.TabIndex = 9;
            this.aboutLbl.Text = "About";
            this.aboutLbl.Click += new System.EventHandler(this.aboutLbl_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 352);
            this.Controls.Add(this.aboutLbl);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.targetGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MInjector - By EquiFox";
            this.targetGroupBox.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ComboBox processList;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.CheckBox hideAssemblyCheck;
        private System.Windows.Forms.TextBox methodTxtBox;
        private System.Windows.Forms.TextBox classTxtBox;
        private System.Windows.Forms.TextBox namespaceTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.Button loadAsmBtn;
        private System.Windows.Forms.TextBox asmPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hideAssemblyLoadCheck;
        private System.Windows.Forms.Label aboutLbl;
    }
}

