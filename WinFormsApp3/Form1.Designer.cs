﻿namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNoidung = new TextBox();
            button1 = new Button();
            treeView1 = new TreeView();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtFileCount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 92);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "select path";
            label1.Click += label1_Click;
            // 
            // txtNoidung
            // 
            txtNoidung.Location = new Point(460, 85);
            txtNoidung.Name = "txtNoidung";
            txtNoidung.Size = new Size(186, 27);
            txtNoidung.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(652, 83);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 52);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(289, 261);
            treeView1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileCount
            // 
            txtFileCount.Location = new Point(463, 144);
            txtFileCount.Name = "txtFileCount";
            txtFileCount.Size = new Size(183, 27);
            txtFileCount.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFileCount);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Controls.Add(txtNoidung);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNoidung;
        private Button button1;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtFileCount;
    }
}
