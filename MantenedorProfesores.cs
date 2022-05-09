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
    public partial class MantenedorProfesores : Form
    {
        // Textos constantes
        private static readonly string TXT_AGREGAR = "Agregar";
        private static readonly string TXT_ACTUALIZAR = "Actualizar";
        private static readonly string TXT_ELIMINAR = "Eliminar";
        private static readonly string TXT_LIMPIAR = "Limpiar";
        private static readonly string TXT_CONSULTAR = "Consultar";
        private static readonly string TXT_CANCELAR = "Cancelar";
        private static readonly string TXT_GUARDAR = "Guardar";
        // Labels
        private static readonly string TXT_RUT = "RUT";
        private static readonly string TXT_DIGITO = "-";
        private static readonly string TXT_P_NOMBRE = "Primer nombre";
        private static readonly string TXT_S_NOMBRE = "Segundo nombre";
        private static readonly string TXT_APELLIDOS = "Apellidos";
        private static readonly string TXT_PASS = "Contraseña";

        public MantenedorProfesores()
        {
            InitializeComponent();
            // Modificar el texto de los botones
            this.btnAgregar.Text = TXT_AGREGAR;
            this.btnActualizar.Text = TXT_ACTUALIZAR;
            this.btnEliminar.Text = TXT_ELIMINAR;
            this.btnLimpiar.Text = TXT_LIMPIAR;
            this.btnConsultar.Text = TXT_CONSULTAR;
            this.btnCancelar.Text = TXT_CANCELAR;
            this.btnGuardar.Text = TXT_GUARDAR;
            // Modificar el texto de los labels
            this.lblRut.Text = TXT_RUT;
            this.lblDigito.Text = TXT_DIGITO;
            this.lblPrimerNombre.Text = TXT_P_NOMBRE;
            this.lblSegundoNombre.Text = TXT_S_NOMBRE;
            this.lblApellidos.Text = TXT_APELLIDOS;
            this.lblPass.Text = TXT_PASS;
        }

        private void MantenedorProfesores_Load(object sender, EventArgs e)
        {
            // Llamada al método Fill para rellenar los datos del
            // gridView
            this.profesorTableAdapter.Fill(this.dataSetProfesor.Profesor);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Asigna un texto vacío en la caja de texto
            txtRut.Text = string.Empty;
            txtDigito.Text = string.Empty;
            txtPrimerNombre.Text =string.Empty;
            txtSegundoNombre.Text=string.Empty;
            txtApellidos.Text=string.Empty;
            txtPass.Text=string.Empty;

            // Accede al foco del elemento y posa el cursor encima.
            txtRut.Focus();
        }

        private void btnAgregar_MouseClick(object sender, MouseEventArgs e)
        {
            int rut = -1;
            bool isRut = int.TryParse(txtRut.Text, out rut);
            if (!isRut)
            {
                Console.WriteLine("Rut invalido");
                
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Obtener el rut desde la caja de texto
            int rut = -1;
            bool isRut = int.TryParse(txtRut.Text, out rut);
            // Validar que el rut sea válido
            if(isRut && rut != -1)
            {
                // Seleccionar registro
                // Con LINQ
                this.profesorTableAdapter.GetData().ToList()
                .Where(x => x.id == rut).ToList()
                .ForEach(row =>
                {
                    // Por cada registro (en este caso uno solo)
                    // Se agregan los datos dentro de las cajas de texto.
                    string[] nombreCompleto = row.nombre.Split(' ');
                    txtPrimerNombre.Text = nombreCompleto[0];
                    txtSegundoNombre.Text = nombreCompleto[1];
                    txtApellidos.Text = nombreCompleto[2] + " " + nombreCompleto[3];
                    txtPass.Text = row.pass;
                });
            }
        }
    }
}
