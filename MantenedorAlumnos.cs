using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCursos
{
    public partial class MantenedorAlumnos : Form
    {
        // Reemplazar por el origen de datos de SQL server
        private List<Alumno> alumnosLista = new List<Alumno>();

        public MantenedorAlumnos()
        {
            InitializeComponent();
            // Opcional - agregando usuarios
            for(int i = 0; i < 10; i++)
                alumnosLista.Add(new Alumno(i,"alumno"+i, 0, 84845000, DateTime.Now, new Curso()));
            // --

            // Encontrar todos los alumnos cuyo ID sea igual o superior a 3
            var alumnosListaFiltrada = alumnosLista.Where(x => x.id >= 3).ToList(); 
            // El alumno cuyo nombre sea alumno5 se despliega
            var alumnosListaFiltradaPorNombre = alumnosListaFiltrada.Where(x => x.nombre == "alumno5").ToList();

            // SQL
            var alumnosListaFiltradaSQL = from alumno in alumnosListaFiltrada
                                          where alumno.id == 6
                                          orderby alumno.nombre
                                          select alumno;
            // Desplegar lista filtrada en el origen de datos de la tabla gridview
            alumnosDataGridView.DataSource = alumnosListaFiltradaSQL.ToList();
            // (Opcional) refrescar tabla gridview
            alumnosDataGridView.Refresh(); 
        }
    }
}
