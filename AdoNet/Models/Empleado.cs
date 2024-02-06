using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    internal class Empleado
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Oficio { get; set; }
        public int Director { get; set; }
        public DateTime dateTime { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }
        public int DeptNo { get; set; }

        public Empleado(int empNo, string name, string oficio, int director, DateTime dateTime, int salario, int comision, int deptNo)
        {
            EmpNo = empNo;
            Name = name;
            Oficio = oficio;
            Director = director;
            this.dateTime = dateTime;
            Salario = salario;
            Comision = comision;
            DeptNo = deptNo;
        }
    }
}
