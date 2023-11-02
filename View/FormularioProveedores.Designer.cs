namespace Syscom.View
{
    partial class FormularioProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProveedores));
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            dgvProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            txtEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Location = new Point(686, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 275);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Location = new Point(37, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 49);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 192);
            btnModificar.Location = new Point(37, 81);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(129, 49);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.Location = new Point(37, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 49);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Location = new Point(37, 191);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 49);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 119);
            label4.Name = "label4";
            label4.Size = new Size(132, 48);
            label4.TabIndex = 15;
            label4.Text = "NOMBRE DEL\r\nPROVEEDOR";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(135, 301);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 14;
            label3.Text = "Telefono";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 246);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 13;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 188);
            label1.Name = "label1";
            label1.Size = new Size(202, 24);
            label1.TabIndex = 12;
            label1.Text = "PERSONA CONTACTO";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(174, 30);
            label5.Name = "label5";
            label5.Size = new Size(569, 44);
            label5.TabIndex = 22;
            label5.Text = "FORMULARIO DE PROVEEDORES";
            // 
            // dgvProveedores
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.ColumnHeadersHeight = 50;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedores.GridColor = Color.FromArgb(231, 229, 255);
            dgvProveedores.Location = new Point(68, 387);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.Size = new Size(808, 239);
            dgvProveedores.TabIndex = 23;
            dgvProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProveedores.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProveedores.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProveedores.ThemeStyle.BackColor = Color.White;
            dgvProveedores.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvProveedores.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvProveedores.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedores.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProveedores.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProveedores.ThemeStyle.HeaderStyle.Height = 50;
            dgvProveedores.ThemeStyle.ReadOnly = false;
            dgvProveedores.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProveedores.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedores.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProveedores.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProveedores.ThemeStyle.RowsStyle.Height = 29;
            dgvProveedores.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvProveedores.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged_1;
            // 
            // txtEmpresa
            // 
            txtEmpresa.CustomizableEdges = customizableEdges1;
            txtEmpresa.DefaultText = "";
            txtEmpresa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmpresa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmpresa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmpresa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmpresa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.ForeColor = Color.Gray;
            txtEmpresa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmpresa.Location = new Point(253, 118);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PasswordChar = '\0';
            txtEmpresa.PlaceholderText = "";
            txtEmpresa.SelectedText = "";
            txtEmpresa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmpresa.Size = new Size(389, 45);
            txtEmpresa.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.CustomizableEdges = customizableEdges3;
            txtTelefono.DefaultText = "";
            txtTelefono.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefono.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefono.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Location = new Point(251, 312);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PlaceholderText = "";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTelefono.Size = new Size(391, 45);
            txtTelefono.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(253, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(391, 45);
            txtEmail.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.CustomizableEdges = customizableEdges7;
            txtNombre.DefaultText = "";
            txtNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Location = new Point(253, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNombre.Size = new Size(391, 45);
            txtNombre.TabIndex = 24;
            // 
            // FormularioProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 685);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(txtEmpresa);
            Controls.Add(dgvProveedores);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioProveedores";
            Load += txtNombre_TextChanged;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProveedores;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpresa;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
    }
}