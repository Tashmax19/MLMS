﻿namespace lms4
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEcllipse2 = new lms4.ButtonEcllipse();
            this.buttonEcllipse4 = new lms4.ButtonEcllipse();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.buttonEcllipse2);
            this.groupBox1.Controls.Add(this.buttonEcllipse4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(412, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "reports";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 28);
            this.comboBox2.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 59;
            // 
            // buttonEcllipse2
            // 
            this.buttonEcllipse2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEcllipse2.FlatAppearance.BorderSize = 0;
            this.buttonEcllipse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcllipse2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEcllipse2.Location = new System.Drawing.Point(291, 99);
            this.buttonEcllipse2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEcllipse2.Name = "buttonEcllipse2";
            this.buttonEcllipse2.Size = new System.Drawing.Size(77, 41);
            this.buttonEcllipse2.TabIndex = 53;
            this.buttonEcllipse2.Text = "exit";
            this.buttonEcllipse2.UseVisualStyleBackColor = false;
            // 
            // buttonEcllipse4
            // 
            this.buttonEcllipse4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEcllipse4.FlatAppearance.BorderSize = 0;
            this.buttonEcllipse4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcllipse4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEcllipse4.Location = new System.Drawing.Point(190, 99);
            this.buttonEcllipse4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEcllipse4.Name = "buttonEcllipse4";
            this.buttonEcllipse4.Size = new System.Drawing.Size(84, 41);
            this.buttonEcllipse4.TabIndex = 52;
            this.buttonEcllipse4.Text = "save";
            this.buttonEcllipse4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "select format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "select report of interest";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(438, 183);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private ButtonEcllipse buttonEcllipse2;
        private ButtonEcllipse buttonEcllipse4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}