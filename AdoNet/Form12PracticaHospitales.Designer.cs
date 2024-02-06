namespace AdoNet
{
    partial class Form12PracticaHospitales
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
            cmbHospitales = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            txtSuma = new TextBox();
            txtMedia = new TextBox();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(25, 75);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(166, 29);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 145);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 2;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 227);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Media";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 303);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 4;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 31);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 5;
            label5.Text = "Empleados Hospital";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 21;
            lstEmpleados.Location = new Point(247, 68);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(235, 298);
            lstEmpleados.TabIndex = 6;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(25, 178);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(146, 29);
            txtSuma.TabIndex = 7;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(25, 260);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(146, 29);
            txtMedia.TabIndex = 8;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(26, 349);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(146, 29);
            txtPersonas.TabIndex = 9;
            // 
            // Form12PracticaHospitales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 442);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form12PracticaHospitales";
            Text = "Form12PracticaHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
        private TextBox txtSuma;
        private TextBox txtMedia;
        private TextBox txtPersonas;
    }
}