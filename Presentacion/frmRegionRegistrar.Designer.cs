﻿namespace Presentacion
{
    partial class frmRegionRegistrar
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
            label1 = new Label();
            txtRegionName = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre Region:";
            // 
            // txtRegionName
            // 
            txtRegionName.Location = new Point(230, 32);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(272, 31);
            txtRegionName.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(526, 32);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmRegionRegistrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 104);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(txtRegionName);
            Name = "frmRegionRegistrar";
            Text = "frmRegionRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRegionName;
        private Button btnRegistrar;
    }
}