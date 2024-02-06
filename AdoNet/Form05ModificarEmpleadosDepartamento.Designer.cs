namespace AdoNet
{
    partial class Form05ModificarEmpleadosDepartamento
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
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            btnModificarDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 21;
            lstDepartamentos.Location = new Point(36, 61);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(151, 214);
            lstDepartamentos.TabIndex = 1;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 21;
            lstEmpleados.Location = new Point(221, 61);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(172, 214);
            lstEmpleados.TabIndex = 2;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 26);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 26);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 4;
            label3.Text = "Oficio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 5;
            label4.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(443, 70);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(109, 29);
            txtOficio.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(443, 167);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(107, 29);
            txtSalario.TabIndex = 7;
            // 
            // btnModificarDatos
            // 
            btnModificarDatos.Location = new Point(443, 217);
            btnModificarDatos.Name = "btnModificarDatos";
            btnModificarDatos.Size = new Size(139, 58);
            btnModificarDatos.TabIndex = 8;
            btnModificarDatos.Text = "Modificar Datos";
            btnModificarDatos.UseVisualStyleBackColor = true;
            btnModificarDatos.Click += btnModificarDatos_Click;
            // 
            // Form05ModificarEmpleadosDepartamento
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 369);
            Controls.Add(btnModificarDatos);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form05ModificarEmpleadosDepartamento";
            Text = "Form05ModificarEmpleadosDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Button btnModificarDatos;
    }
}