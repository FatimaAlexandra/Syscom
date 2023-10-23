namespace Syscom
{
    partial class Form1
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
            lblEstadoConexion = new Label();
            btnCrudClientes = new Button();
            btnProveedores = new Button();
            SuspendLayout();
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Location = new Point(370, 141);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(50, 20);
            lblEstadoConexion.TabIndex = 0;
            lblEstadoConexion.Text = "label1";
            lblEstadoConexion.Click += lblEstadoConexion_Click;
            // 
            // btnCrudClientes
            // 
            btnCrudClientes.Location = new Point(447, 227);
            btnCrudClientes.Name = "btnCrudClientes";
            btnCrudClientes.Size = new Size(168, 29);
            btnCrudClientes.TabIndex = 9;
            btnCrudClientes.Text = "Crud Clientes";
            btnCrudClientes.UseVisualStyleBackColor = true;
            btnCrudClientes.Click += btnCrudClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(183, 227);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(168, 29);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "Crud Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProveedores);
            Controls.Add(btnCrudClientes);
            Controls.Add(lblEstadoConexion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstadoConexion;
        private Button btnCrudClientes;
        private Button btnProveedores;
    }
}