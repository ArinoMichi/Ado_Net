namespace AdoNet
{
    partial class Form11ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstEmpleados = new ListBox();
            label5 = new Label();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(26, 60);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(150, 29);
            cmbDepartamentos.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(29, 98);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(148, 35);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 145);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Suma ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 206);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Media";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 269);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 5;
            label4.Text = "Personas";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 21;
            lstEmpleados.Location = new Point(243, 60);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(204, 256);
            lstEmpleados.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 28);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 7;
            label5.Text = "Empleados";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(26, 174);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(136, 29);
            txtSuma.TabIndex = 8;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(26, 230);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(138, 29);
            txtMedia.TabIndex = 9;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(29, 305);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(128, 29);
            txtPersonas.TabIndex = 10;
            // 
            // Form11ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 346);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(label5);
            Controls.Add(lstEmpleados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form11ParametrosSalida";
            Text = "Form11ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstEmpleados;
        private Label label5;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
    }
}