namespace AdoNet
{
    partial class Form08EmpleadosOficios
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
            txtSumaSalario = new TextBox();
            txtIncremento = new TextBox();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            btnIncrementar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 32);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 32);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Suma Salarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 134);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Incremento";
            // 
            // txtSumaSalario
            // 
            txtSumaSalario.Location = new Point(476, 72);
            txtSumaSalario.Name = "txtSumaSalario";
            txtSumaSalario.Size = new Size(115, 31);
            txtSumaSalario.TabIndex = 4;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(479, 177);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(114, 31);
            txtIncremento.TabIndex = 5;
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 23;
            lstOficios.Location = new Point(31, 60);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(196, 257);
            lstOficios.TabIndex = 6;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 23;
            lstEmpleados.Location = new Point(265, 60);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(193, 257);
            lstEmpleados.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(481, 237);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(135, 56);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            // 
            // Form08EmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 391);
            Controls.Add(btnIncrementar);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(txtIncremento);
            Controls.Add(txtSumaSalario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form08EmpleadosOficios";
            Text = "Form08EmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSumaSalario;
        private TextBox txtIncremento;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Button btnIncrementar;
    }
}