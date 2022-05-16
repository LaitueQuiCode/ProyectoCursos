using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoCursos
{
    public partial class MantenedorProfesores : Form
    {
        // Estructura de profesor
        private struct Profesor
        {
            public int id;
            public string pass, nombre;
        }
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
        // Método que retorna un profesor en caso que exista, sino, retorna default.
        private DataSetProfesor.ProfesorRow ConsultarProfesor(int rut)
        {
            // Seleccionar registro
            // Con LINQ
            return this.profesorTableAdapter.GetData().ToList()
            .Where(profesorLinq => profesorLinq.id == rut).FirstOrDefault();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Obtener el rut desde la caja de texto
            int rut;
            int.TryParse(txtRut.Text, out rut);

            // Seleccionar registro
            // Con LINQ
            DataSetProfesor.ProfesorRow fila = ConsultarProfesor(rut);
            if (fila != default)
            {
                // Por cada registro (en este caso uno solo)
                // Se agregan los datos dentro de las cajas de texto.
                string[] nombreCompleto = fila.nombre.Split(' ');
                txtPrimerNombre.Text = nombreCompleto[0];
                txtSegundoNombre.Text = nombreCompleto[1];
                txtApellidos.Text = nombreCompleto[2] + " " + nombreCompleto[3];
                txtPass.Text = fila.pass;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Es el proceso inverso a recuperar desde base de datos.
            // Estamos recuperando la información desde
            // las cajas de texto del formulario de windows.
            int rut, digito;
            int.TryParse(txtRut.Text, out rut);
            int.TryParse(txtDigito.Text, out digito);

            
            bool existe = this.profesorTableAdapter
                          .GetData()
                          .ToList()
                          .Where(x => x.id == rut).FirstOrDefault() 
                          != default;
            if (!existe)
            {
                string[] nombreCompleto = new string[4];
                nombreCompleto[0] = txtPrimerNombre.Text;
                // En caso de que no haya segundo nombre
                // Asigna un string vacío al buffer.
                nombreCompleto[1] = txtSegundoNombre.Text == null ?
                                    string.Empty : txtSegundoNombre.Text;
                string[] apellidos = txtApellidos.Text.Split(' ');
                nombreCompleto[2] = apellidos[0];
                // Intento, en caso de no tener segundo apellido
                // en la excepción asigna un string vacío al buffer.
                try
                {
                    nombreCompleto[3] = apellidos[1];
                }
                catch (IndexOutOfRangeException ex)
                {
                    nombreCompleto[3] = string.Empty;
                }
                string pass = txtPass.Text;
                Profesor profesor;
                profesor.id = rut;
                profesor.nombre = string.Empty;
                profesor.pass = pass;

                nombreCompleto.ToList().ForEach(texto => profesor.nombre += texto + " ");
                profesorTableAdapter.Insert(profesor.id, profesor.pass, profesor.nombre);
                // Volver a realizar un select y guardar los datos a la tabla
                this.profesorTableAdapter.Fill(this.dataSetProfesor.Profesor);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int rut;
            int.TryParse(txtRut.Text, out rut);
            DataSetProfesor.ProfesorRow profesor = ConsultarProfesor(rut);
            if (profesor != default)
            {
                string[] nombreCompleto = new string[4];
                nombreCompleto[0] = txtPrimerNombre.Text;
                // En caso de que no haya segundo nombre
                // Asigna un string vacío al buffer.
                nombreCompleto[1] = txtSegundoNombre.Text == null ?
                                    string.Empty : txtSegundoNombre.Text;
                string[] apellidos = txtApellidos.Text.Split(' ');
                nombreCompleto[2] = apellidos[0];
                // Intento, en caso de no tener segundo apellido
                // en la excepción asigna un string vacío al buffer.
                try
                {
                    nombreCompleto[3] = apellidos[1];
                }
                catch (IndexOutOfRangeException ex)
                {
                    nombreCompleto[3] = string.Empty;
                }
                string nombreFinal = string.Empty;
                nombreCompleto.ToList().ForEach(texto => nombreFinal += texto + " ");
                
                this.profesorTableAdapter.Update(txtPass.Text, nombreFinal, rut, profesor.pass, profesor.nombre);
                // Volver a realizar un select y guardar los datos a la tabla
                this.profesorTableAdapter.Fill(this.dataSetProfesor.Profesor);
            }
        }
    }
}
