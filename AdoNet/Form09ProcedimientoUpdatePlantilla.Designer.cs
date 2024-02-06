namespace AdoNet
{
    partial class Form09ProcedimientoUpdatePlantilla
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
            lstPlantilla = new ListBox();
            cmbHospitales = new ComboBox();
            btnModificarSalario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 21;
            lstPlantilla.Location = new Point(38, 175);
            lstPlantilla.Margin = new Padding(4, 4, 4, 4);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(334, 235);
            lstPlantilla.TabIndex = 2;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(38, 67);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(178, 29);
            cmbHospitales.TabIndex = 3;
            // 
            // btnModificarSalario
            // 
            btnModificarSalario.Location = new Point(266, 67);
            btnModificarSalario.Name = "btnModificarSalario";
            btnModificarSalario.Size = new Size(115, 60);
            btnModificarSalario.TabIndex = 4;
            btnModificarSalario.Text = "Modificar Salarios";
            btnModificarSalario.UseVisualStyleBackColor = true;
            btnModificarSalario.Click += btnModificarSalario_Click;
            // 
            // Form09ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 458);
            Controls.Add(btnModificarSalario);
            Controls.Add(cmbHospitales);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form09ProcedimientoUpdatePlantilla";
            Text = "Form09ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstPlantilla;
        private ComboBox cmbHospitales;
        private Button btnModificarSalario;
    }
}