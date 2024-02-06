using AdoNet.Models;
using AdoNet.Repositories;

namespace AdoNet
{
    public partial class Form06DepartamentosClases : Form
    {
        private RepositoryDepartamentos repo;
        private List<int> idsDepareamentoList;
        public Form06DepartamentosClases()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.idsDepareamentoList = new List<int>();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.idsDepareamentoList.Clear();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.idsDepareamentoList.Add(dept.IdDepartamento);
                this.lstDepartamentos.Items.Add(dept.IdDepartamento + " - " +
                    dept.Nombre + " - " + dept.Localidad);
            }
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NECESITAMOS EL ID DEL DEPARTAMENTO
            int index = this.lstDepartamentos.SelectedIndex;
            if (index != -1)
            {
                int idDept = this.idsDepareamentoList[index];
                Departamento dept = this.repo.FindDepartamento(idDept);
                this.txtId.Text = dept.IdDepartamento.ToString();
                this.txtNombre.Text = dept.Nombre;
                this.txtLocalidad.Text = dept.Localidad;
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;

            int insertados = this.repo.InsertarDepartamento(id, nombre, localidad);
            this.LoadDepartamentos();
            MessageBox.Show("Departamentos insertados: " + insertados);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;

            int modificados = this.repo.ModificarDepartamento(id, nombre, localidad);
            this.LoadDepartamentos();
            MessageBox.Show("Departamentos modificados: " + modificados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;
            if (index != -1)
            {
                int idDepartamento = this.idsDepareamentoList[index];
                int result = this.repo.EliminarDepartamento(idDepartamento);
                this.LoadDepartamentos();
                MessageBox.Show("Departamentos eliminados: " + result);
            }
        }
    }
}
