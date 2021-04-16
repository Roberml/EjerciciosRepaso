using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1RepasoDI
{

    class Videojuego
    {
         
        public string Titulo { set; get; }
      

        private int año;
        public int Año
        {
            set
            {
                this.año = value;
            }
            get
            {
                return this.año;
            }
        }

        public enum Estilo
        {
            Arcade=1, Videoaventura=2, Shootemup=3, Estrategia=4, Deportivo=5

        }


        public Estilo estilo;
        


        public Videojuego(string titulo, int año, Estilo est)
        {
            this.año = año;
            this.Titulo = titulo;
            this.estilo = est;
        }


    }
}
