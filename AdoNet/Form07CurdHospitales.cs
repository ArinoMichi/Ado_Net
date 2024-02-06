using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form07CurdHospitales : Form
    {
        private RepositoryHospitales repo;
        List<Hospital> hospitales;
        public Form07CurdHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.hospitales = new List<Hospital>();
            this.LoadHospitales();

        }

        private void LoadHospitales()
        {

            this.lstHospitales.Items.Clear();
            this.hospitales = this.repo.GetHospitales();
            foreach (Hospital ho in hospitales)
            {
                this.lstHospitales.Items.Add(ho.Nombre);
            }
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            if (index != -1)
            {
                Hospital hospAux = this.hospitales[index];
                this.txtId.Text = hospAux.Id.ToString();
                this.txtNombre.Text = hospAux.Nombre;
                this.txtDireccion.Text = hospAux.Direccion;
                this.txtTelefono.Text = hospAux.Telefono;
                this.txtNumCamas.Text = hospAux.NumCamas.ToString();
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtNumCamas.Text);
            int filasInsertadas = this.repo.InsertHospital(id, nombre, direccion, telefono, camas);

            this.LoadHospitales();
            MessageBox.Show("Filas añadidas: " + filasInsertadas);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtNumCamas.Text);
            int filasModificadas = this.repo.ModificarHospital(id,nombre,direccion,telefono, camas);

            this.LoadHospitales();
            MessageBox.Show("Filas modificadas:" + filasModificadas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            
            if (index != -1)
            {
                int codHos = this.hospitales[index].Id;
                int filasBorradas= this.repo.DeleteHospital(codHos);

                this.LoadHospitales();
                MessageBox.Show("Filas borradas: " +  filasBorradas);
            }
        }
    }
}
