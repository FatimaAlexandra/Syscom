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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtEmpresa = new TextBox();
            btnAgregarCliente = new Button();
            btnLimpiar = new Button();
            dgvClientes = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 116);
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
            // txtNombre
            // 
            txtNombre.Location = new Point(246, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(248, 232);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(390, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(249, 292);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(390, 27);
            txtEmpresa.TabIndex = 7;
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
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(112, 372);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(769, 200);
            dgvClientes.TabIndex = 10;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
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
            // FormularioClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 712);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dgvClientes);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioClientes";
            Text = "FormularioClientes";
            Load += FormularioClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtEmpresa;
        private Button btnAgregarCliente;
        private Button btnLimpiar;
        private DataGridView dgvClientes;
        private GroupBox groupBox1;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Label label5;
    }
}