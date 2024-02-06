namespace AdoNet
{
    partial class Form10MensajesServidor
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
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            lblMensajesServidor = new Label();
            label4 = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 115);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(36, 61);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(147, 29);
            txtNumero.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 29);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 207);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(41, 248);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(142, 29);
            txtLocalidad.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(36, 292);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(135, 55);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMensajesServidor
            // 
            lblMensajesServidor.AutoSize = true;
            lblMensajesServidor.ForeColor = SystemColors.MenuHighlight;
            lblMensajesServidor.Location = new Point(40, 371);
            lblMensajesServidor.Name = "lblMensajesServidor";
            lblMensajesServidor.Size = new Size(52, 21);
            lblMensajesServidor.TabIndex = 7;
            lblMensajesServidor.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 33);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 8;
            label4.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 21;
            lstDepartamentos.Location = new Point(266, 61);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(315, 340);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form10MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 454);
            Controls.Add(lstDepartamentos);
            Controls.Add(label4);
            Controls.Add(lblMensajesServidor);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form10MensajesServidor";
            Text = "Form10MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private Label lblMensajesServidor;
        private Label label4;
        private ListBox lstDepartamentos;
    }
}