using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandaGames
{
    public partial class Form1 : Form
    {
        private List<Juego>juegos = new List<Juego>();
       
       
        

        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar Elementos

            lstJuegos.Items.Add("Grand Street Auto V - Ps4 - $10000");
            lstJuegos.Items.Add("Minecraft - Ps4 - $5000");
            lstJuegos.Items.Add("Halo - Xbox S - $4000");
            lstJuegos.Items.Add("League of Legend- PC - $10000");
            lstJuegos.Items.Add("The Last Of Us Parte II - Ps5 - $20000");
        }

        private void lstJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstJuegos.SelectedIndex != -1) 
            {
                lblJuegos.Text = (string)lstJuegos.Items[lstJuegos.SelectedIndex];

            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstJuegos.SelectedIndex;

            if (indice!= -1)
            {
                lstJuegos.Items.RemoveAt(indice);

              
            }
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string plataforma = cmbPlataforma.Text;
            string precio = txtPrecio.Text;


            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(plataforma) || string.IsNullOrWhiteSpace(precio))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            string juego = ( txtNombre.Text + " - " + cmbPlataforma.Text + " - " + txtPrecio.Text);
            lstJuegos.Items.Add(juego);

            // Limpiar los campos
            txtNombre.Clear();
            cmbPlataforma.SelectedIndex = 0;
            txtPrecio.Clear();
            txtNombre.Focus();
              
        }
 

    }

} 
