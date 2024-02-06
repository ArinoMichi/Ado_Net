namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            lstEmpleados = new ListBox();
            label2 = new Label();
            txtSalario = new TextBox();
            btnBuscarEmpleado = new Button();
            label1 = new Label();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarEmpleadoOficio = new Button();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(11, 184);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(231, 184);
            lstEmpleados.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 151);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Empleados";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(11, 52);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(190, 23);
            txtSalario.TabIndex = 7;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.AllowDrop = true;
            btnBuscarEmpleado.Location = new Point(11, 81);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(159, 53);
            btnBuscarEmpleado.TabIndex = 6;
            btnBuscarEmpleado.Text = "Buscar Empleado";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += btnBuscarEmpleado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "Introduzca salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 39);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Introduzca Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(245, 64);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(136, 23);
            txtOficio.TabIndex = 11;
            // 
            // btnBuscarEmpleadoOficio
            // 
            btnBuscarEmpleadoOficio.Location = new Point(241, 101);
            btnBuscarEmpleadoOficio.Name = "btnBuscarEmpleadoOficio";
            btnBuscarEmpleadoOficio.Size = new Size(135, 45);
            btnBuscarEmpleadoOficio.TabIndex = 12;
            btnBuscarEmpleadoOficio.Text = "Buscar Por Oficio";
            btnBuscarEmpleadoOficio.UseVisualStyleBackColor = true;
            btnBuscarEmpleadoOficio.Click += btnBuscarEmpleadoOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarEmpleadoOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscarEmpleado);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label2;
        private TextBox txtSalario;
        private Button btnBuscarEmpleado;
        private Label label1;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarEmpleadoOficio;
    }
}