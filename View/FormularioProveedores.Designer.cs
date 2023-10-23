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
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            dgvProveedores = new DataGridView();
            txtEmpresa = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
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
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(107, 392);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.Size = new Size(769, 200);
            dgvProveedores.TabIndex = 20;
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(252, 140);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(390, 27);
            txtEmpresa.TabIndex = 19;
            txtEmpresa.TextChanged += txtEmpresa_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(252, 300);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(390, 27);
            txtTelefono.TabIndex = 18;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(253, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 27);
            txtEmail.TabIndex = 17;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(252, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 27);
            txtNombre.TabIndex = 16;
            txtNombre.TextChanged += txtNombre_TextChanged;
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
            // FormularioProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 685);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dgvProveedores);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioProveedores";
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
        private DataGridView dgvProveedores;
        private TextBox txtEmpresa;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}