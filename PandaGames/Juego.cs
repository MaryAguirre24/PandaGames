using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaGames
{
    public class Juego
    {
        public string Nombre { get; set; }

        public string Plataforma { get; set; }

        public decimal Precio { get; set; }

        public void Agregar(string nombre,
                            string plataforma,
                            string precio)
        {
            Nombre = nombre;
            Plataforma = plataforma;
            Precio = Convert.ToDecimal(precio);

            
        }
         
       
    }
       

}
