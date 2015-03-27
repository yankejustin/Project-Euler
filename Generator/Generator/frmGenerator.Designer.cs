namespace Generator
{
    partial class frmGenerator
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
            this.btnLoadProblems = new System.Windows.Forms.Button();
            this.trvProblems = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadProblems
            // 
            this.btnLoadProblems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProblems.Location = new System.Drawing.Point(14, 481);
            this.btnLoadProblems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLoadProblems.Name = "btnLoadProblems";
            this.btnLoadProblems.Size = new System.Drawing.Size(752, 46);
            this.btnLoadProblems.TabIndex = 0;
            this.btnLoadProblems.Text = "Retrieve Problems";
            this.btnLoadProblems.UseVisualStyleBackColor = true;
            this.btnLoadProblems.Click += new System.EventHandler(this.btnLoadProblems_Click);
            // 
            // trvProblems
            // 
            this.trvProblems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvProblems.Location = new System.Drawing.Point(14, 95);
            this.trvProblems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trvProblems.Name = "trvProblems";
            this.trvProblems.Size = new System.Drawing.Size(752, 388);
            this.trvProblems.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(331, 34);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(113, 18);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter Results";
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDivider.Location = new System.Drawing.Point(-7, 89);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(794, 2);
            this.lblDivider.TabIndex = 4;
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainEdit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(780, 24);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFileCreate,
            this.mnuMainFileSeparator1,
            this.mnuMainFileSave});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(43, 20);
            this.mnuMainFile.Text = "File";
            // 
            // mnuMainFileCreate
            // 
            this.mnuMainFileCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuItem});
            this.mnuMainFileCreate.Name = "mnuMainFileCreate";
            this.mnuMainFileCreate.Size = new System.Drawing.Size(152, 22);
            this.mnuMainFileCreate.Text = "Create";
            // 
            // mnuMainFileSeparator1
            // 
            this.mnuMainFileSeparator1.Name = "mnuMainFileSeparator1";
            this.mnuMainFileSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuMainFileSave
            // 
            this.mnuMainFileSave.Name = "mnuMainFileSave";
            this.mnuMainFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuMainFileSave.Text = "Save";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // mnuMainEdit
            // 
            this.mnuMainEdit.Name = "mnuMainEdit";
            this.mnuMainEdit.Size = new System.Drawing.Size(45, 20);
            this.mnuMainEdit.Text = "Edit";
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 534);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadProblems);
            this.Controls.Add(this.trvProblems);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(796, 572);
            this.MinimumSize = new System.Drawing.Size(796, 572);
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Euler Problem Retriever";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadProblems;
        private System.Windows.Forms.TreeView trvProblems;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileCreate;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator mnuMainFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuMainEdit;
    }
}

