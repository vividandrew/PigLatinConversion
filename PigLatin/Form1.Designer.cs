﻿namespace PigLatin
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(504, 188);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 250);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(504, 188);
            this.txtOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - P" +
    "IG LATIN - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - -";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(523, 132);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 69);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert to Pig Latin";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "PigLatin Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
    }
}

