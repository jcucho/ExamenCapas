namespace Presentacion
{
    partial class frmRegions
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
            btnListar = new Button();
            dgvRegions = new DataGridView();
            RegionId = new DataGridViewTextBoxColumn();
            RegionName = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(37, 19);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(107, 38);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvRegions
            // 
            dgvRegions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegions.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName });
            dgvRegions.Location = new Point(37, 67);
            dgvRegions.Margin = new Padding(4, 5, 4, 5);
            dgvRegions.Name = "dgvRegions";
            dgvRegions.RowHeadersWidth = 62;
            dgvRegions.RowTemplate.Height = 25;
            dgvRegions.Size = new Size(814, 568);
            dgvRegions.TabIndex = 1;
            // 
            // RegionId
            // 
            RegionId.DataPropertyName = "RegionId";
            RegionId.HeaderText = "RegionId";
            RegionId.MinimumWidth = 8;
            RegionId.Name = "RegionId";
            RegionId.Width = 150;
            // 
            // RegionName
            // 
            RegionName.DataPropertyName = "RegionName";
            RegionName.HeaderText = "RegionName";
            RegionName.MinimumWidth = 8;
            RegionName.Name = "RegionName";
            RegionName.Width = 150;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(160, 19);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 40);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmRegions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 750);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvRegions);
            Controls.Add(btnListar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegions";
            Text = "Regions";
            ((System.ComponentModel.ISupportInitialize)dgvRegions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvRegions;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn RegionName;
        private Button btnRegistrar;
    }
}
