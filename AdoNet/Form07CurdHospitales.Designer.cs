namespace AdoNet
{
    partial class Form07CurdHospitales
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
            lstHospitales = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtNumCamas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 23;
            lstHospitales.Location = new Point(32, 89);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(263, 280);
            lstHospitales.TabIndex = 1;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 36);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 110);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 171);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 4;
            label4.Text = "Direccion";
            // 
            // txtId
            // 
            txtId.Location = new Point(348, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 31);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(352, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(349, 199);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(164, 31);
            txtDireccion.TabIndex = 7;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(128, 255, 128);
            btnInsertar.Location = new Point(562, 110);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 58);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(128, 255, 255);
            btnModificar.Location = new Point(562, 199);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 55);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(562, 285);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 59);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 248);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 329);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 12;
            label6.Text = "Num Camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(351, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(161, 31);
            txtTelefono.TabIndex = 13;
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(348, 362);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(168, 31);
            txtNumCamas.TabIndex = 14;
            // 
            // Form07CurdHospitales
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 500);
            Controls.Add(txtNumCamas);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form07CurdHospitales";
            Text = "Form07CurdHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label5;
        private Label label6;
        private TextBox txtTelefono;
        private TextBox txtNumCamas;
    }
}