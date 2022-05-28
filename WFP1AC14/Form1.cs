using p1ACrud13.Clases.Servicio;

namespace WFP1AC14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            ServicioAlumno srvAlumno = new();
            var respuesta = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridViewAlumnos.DataSource = respuesta; 
        }
    }
}