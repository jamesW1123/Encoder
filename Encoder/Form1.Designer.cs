﻿namespace Encoder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConvertRNA = new System.Windows.Forms.Button();
            this.btnConvertDNA = new System.Windows.Forms.Button();
            this.btnCompliment = new System.Windows.Forms.Button();
            this.btnFindDNA = new System.Windows.Forms.Button();
            this.btnFindCommon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 130);
            this.panel1.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(419, 130);
            this.txtInput.TabIndex = 0;
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 136);
            this.panel2.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(419, 136);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFindCommon);
            this.panel3.Controls.Add(this.btnFindDNA);
            this.panel3.Controls.Add(this.btnCompliment);
            this.panel3.Controls.Add(this.btnConvertRNA);
            this.panel3.Controls.Add(this.btnConvertDNA);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 79);
            this.panel3.TabIndex = 2;
            // 
            // btnConvertRNA
            // 
            this.btnConvertRNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertRNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvertRNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertRNA.Location = new System.Drawing.Point(81, 14);
            this.btnConvertRNA.Name = "btnConvertRNA";
            this.btnConvertRNA.Size = new System.Drawing.Size(73, 50);
            this.btnConvertRNA.TabIndex = 1;
            this.btnConvertRNA.Text = "Convert RNA";
            this.btnConvertRNA.UseVisualStyleBackColor = true;
            this.btnConvertRNA.Click += new System.EventHandler(this.btnConvertRNA_Click);
            // 
            // btnConvertDNA
            // 
            this.btnConvertDNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertDNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvertDNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDNA.Location = new System.Drawing.Point(10, 14);
            this.btnConvertDNA.Name = "btnConvertDNA";
            this.btnConvertDNA.Size = new System.Drawing.Size(65, 50);
            this.btnConvertDNA.TabIndex = 0;
            this.btnConvertDNA.Text = "Convert DNA";
            this.btnConvertDNA.UseVisualStyleBackColor = true;
            this.btnConvertDNA.Click += new System.EventHandler(this.btnConvertDNA_Click);
            // 
            // btnCompliment
            // 
            this.btnCompliment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompliment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompliment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompliment.Location = new System.Drawing.Point(160, 14);
            this.btnCompliment.Name = "btnCompliment";
            this.btnCompliment.Size = new System.Drawing.Size(98, 50);
            this.btnCompliment.TabIndex = 2;
            this.btnCompliment.Text = "Convert Compliment";
            this.btnCompliment.UseVisualStyleBackColor = true;
            this.btnCompliment.Click += new System.EventHandler(this.btnCompliment_Click);
            // 
            // btnFindDNA
            // 
            this.btnFindDNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindDNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindDNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDNA.Location = new System.Drawing.Point(264, 14);
            this.btnFindDNA.Name = "btnFindDNA";
            this.btnFindDNA.Size = new System.Drawing.Size(65, 50);
            this.btnFindDNA.TabIndex = 3;
            this.btnFindDNA.Text = "Find DNA";
            this.btnFindDNA.UseVisualStyleBackColor = true;
            this.btnFindDNA.Click += new System.EventHandler(this.btnFindDNA_Click);
            // 
            // btnFindCommon
            // 
            this.btnFindCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindCommon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCommon.Location = new System.Drawing.Point(335, 14);
            this.btnFindCommon.Name = "btnFindCommon";
            this.btnFindCommon.Size = new System.Drawing.Size(72, 50);
            this.btnFindCommon.TabIndex = 4;
            this.btnFindCommon.Text = "Find Common";
            this.btnFindCommon.UseVisualStyleBackColor = true;
            this.btnFindCommon.Click += new System.EventHandler(this.btnFindCommon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DNA Encoder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConvertDNA;
        private System.Windows.Forms.Button btnConvertRNA;
        private System.Windows.Forms.Button btnCompliment;
        private System.Windows.Forms.Button btnFindDNA;
        private System.Windows.Forms.Button btnFindCommon;
    }
}

