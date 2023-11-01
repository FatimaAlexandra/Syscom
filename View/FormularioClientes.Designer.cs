namespace Syscom.View
{
    partial class FormularioClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarCliente = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            label5 = new Label();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmpresa = new Guna.UI2.WinForms.Guna2TextBox();
            dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            cmbUsuarios = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 112);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 176);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 232);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(112, 292);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 3;
            label4.Text = "Empresa";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregarCliente.Location = new Point(37, 26);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(129, 49);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
            btnLimpiar.Location = new Point(37, 191);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 49);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminarCliente);
            groupBox1.Controls.Add(btnModificarCliente);
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Location = new Point(691, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 275);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminarCliente.Location = new Point(37, 136);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(129, 49);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.FromArgb(255, 255, 192);
            btnModificarCliente.Location = new Point(37, 81);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(129, 49);
            btnModificarCliente.TabIndex = 10;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(246, 9);
            label5.Name = "label5";
            label5.Size = new Size(483, 44);
            label5.TabIndex = 12;
            label5.Text = "FORMULARIO DE CLIENTES";
            // 
            // txtNombre
            // 
            txtNombre.CustomizableEdges = customizableEdges1;
            txtNombre.DefaultText = "";
            txtNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Location = new Point(248, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNombre.Size = new Size(391, 45);
            txtNombre.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(248, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(391, 45);
            txtEmail.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.CustomizableEdges = customizableEdges5;
            txtTelefono.DefaultText = "";
            txtTelefono.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTelefono.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTelefono.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Location = new Point(246, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PlaceholderText = "";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTelefono.Size = new Size(391, 45);
            txtTelefono.TabIndex = 15;
            // 
            // txtEmpresa
            // 
            txtEmpresa.CustomizableEdges = customizableEdges7;
            txtEmpresa.DefaultText = "";
            txtEmpresa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmpresa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmpresa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmpresa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmpresa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.ForeColor = Color.Gray;
            txtEmpresa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmpresa.Location = new Point(248, 287);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PasswordChar = '\0';
            txtEmpresa.PlaceholderText = "";
            txtEmpresa.SelectedText = "";
            txtEmpresa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEmpresa.Size = new Size(391, 45);
            txtEmpresa.TabIndex = 16;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 50;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.GridColor = Color.FromArgb(231, 229, 255);
            dgvClientes.Location = new Point(79, 409);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(769, 188);
            dgvClientes.TabIndex = 17;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClientes.ThemeStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvClientes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvClientes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClientes.ThemeStyle.HeaderStyle.Height = 50;
            dgvClientes.ThemeStyle.ReadOnly = false;
            dgvClientes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClientes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvClientes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvClientes.ThemeStyle.RowsStyle.Height = 29;
            dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged_1;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.BackColor = Color.Transparent;
            cmbUsuarios.CustomizableEdges = customizableEdges9;
            cmbUsuarios.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbUsuarios.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUsuarios.ForeColor = Color.FromArgb(68, 88, 112);
            cmbUsuarios.ItemHeight = 30;
            cmbUsuarios.Location = new Point(248, 355);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbUsuarios.Size = new Size(389, 36);
            cmbUsuarios.TabIndex = 18;
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 367);
            label6.Name = "label6";
            label6.Size = new Size(183, 24);
            label6.TabIndex = 19;
            label6.Text = "Asignar Usuario";
            // 
            // FormularioClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 712);
            Controls.Add(label6);
            Controls.Add(cmbUsuarios);
            Controls.Add(dgvClientes);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioClientes";
            Text = "FormularioProveedores";
            Load += FormularioClientes_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarCliente;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpresa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsuarios;
        private Label label6;
    }
}