namespace Syscom.View
{
    partial class FormularioLicitaconesLanzadas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLicitaconesLanzadas));
            dgvLicitaciones = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLicitaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvLicitaciones
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvLicitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLicitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLicitaciones.ColumnHeadersHeight = 25;
            dgvLicitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLicitaciones.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLicitaciones.GridColor = Color.FromArgb(231, 229, 255);
            dgvLicitaciones.Location = new Point(47, 77);
            dgvLicitaciones.Name = "dgvLicitaciones";
            dgvLicitaciones.RowHeadersVisible = false;
            dgvLicitaciones.RowHeadersWidth = 51;
            dgvLicitaciones.RowTemplate.Height = 29;
            dgvLicitaciones.Size = new Size(696, 296);
            dgvLicitaciones.TabIndex = 0;
            dgvLicitaciones.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvLicitaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLicitaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLicitaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLicitaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLicitaciones.ThemeStyle.BackColor = Color.White;
            dgvLicitaciones.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvLicitaciones.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvLicitaciones.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLicitaciones.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvLicitaciones.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvLicitaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLicitaciones.ThemeStyle.HeaderStyle.Height = 25;
            dgvLicitaciones.ThemeStyle.ReadOnly = false;
            dgvLicitaciones.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvLicitaciones.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLicitaciones.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvLicitaciones.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvLicitaciones.ThemeStyle.RowsStyle.Height = 29;
            dgvLicitaciones.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvLicitaciones.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FormularioLicitaconesLanzadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLicitaciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioLicitaconesLanzadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioLicitaconesLanzadas";
            Load += FormularioLicitaconesLanzadas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLicitaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvLicitaciones;
    }
}