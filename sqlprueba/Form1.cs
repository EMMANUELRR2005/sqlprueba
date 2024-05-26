using sqlprueba.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlprueba
{
    public partial class Form1 : Form
    {
        private PersonajesDB personaje;
        private string[] razasDragonBall = 
            {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
         };
        
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesDB();

        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if ( personaje.ProbaConexion())
            {
                MessageBox.Show("Simoncho");

            }
            else
            {
                MessageBox.Show("Nel pastel");
            }
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void CREAR_Click(object sender, EventArgs e)
        {
            string id = Id.Text;
            string nombre = Nombre.Text;
            string raza1 = RazaList.Text;
            DateTime fecha_creacion = DateTime.Now;
            int nivelpoder = (int)NivelDePoder.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza1, nivelpoder, fecha_creacion);
            if (respuesta > 0)
            {
                MessageBox.Show("Creado con Exito");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Malismo");
            }
        }

        private void tbcrear_Click(object sender, EventArgs e)
        {
            

        }

        private void NivelDePoder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RazaList.Items.AddRange(razasDragonBall);
        }

        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(Id.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();
                Nombre.Text = nombre;
                RazaList.Text = raza;
                NivelDePoder.Value = nivelPoder;
                
                textBoxhistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontro codigo");
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id.Text);
            string nombre = Nombre.Text;
            string raza = RazaList.Text;
            int nivelPoder = (int)NivelDePoder.Value;
            string historia = textBoxhistoria.Text;
            int respuesta = personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Si se pudo mi rey");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }

        private void dateTimePickerfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id.Text);
            int respuesta = personaje.BorrarPersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Si se pudo guapo");
                Id.Clear();
                Nombre.Clear();
                RazaList.SelectedIndex = -1;
                NivelDePoder.Value = 0;
                textBoxhistoria.Clear();
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }
    }
}
