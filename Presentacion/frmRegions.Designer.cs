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
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(36, 29);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvRegions
            // 
            dgvRegions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegions.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName });
            dgvRegions.Location = new Point(36, 58);
            dgvRegions.Name = "dgvRegions";
            dgvRegions.RowTemplate.Height = 25;
            dgvRegions.Size = new Size(570, 341);
            dgvRegions.TabIndex = 1;
            // 
            // RegionId
            // 
            RegionId.DataPropertyName = "RegionId";
            RegionId.HeaderText = "RegionId";
            RegionId.Name = "RegionId";
            // 
            // RegionName
            // 
            RegionName.DataPropertyName = "RegionName";
            RegionName.HeaderText = "RegionName";
            RegionName.Name = "RegionName";
            // 
            // frmRegions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(dgvRegions);
            Controls.Add(btnListar);
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
    }
}
