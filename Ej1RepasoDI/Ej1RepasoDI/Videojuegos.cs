using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1RepasoDI
{
    class Videojuegos
    {
        public  List<Videojuego> videojuegos;


        

        public int Posicion(int año)
        {
            

            for (int i = 0; i<videojuegos.Count; i++)
            {
                if (año < videojuegos[i].Año)
                {
                    return i;
                }
               
            }

            return videojuegos.Count;

        }



        public bool Eliminar(int posmax, int posmin=0)
        {

            if (posmin < 0 || posmin > videojuegos.Count || posmax < 0 || posmax > videojuegos.Count || posmax < posmin)
            {
                return false;
            }
            else
            {
                for (int i = posmax; i >= posmin; i--)
                {
                    videojuegos.RemoveAt(i);
                }

                return true;
            }

        }





       


        public List<Videojuego> Busqueda(Videojuego.Estilo est)
        {
            List<Videojuego> coleccionEstilo = new List<Videojuego>();

            foreach (Videojuego v in videojuegos)
            {
                if (v.estilo == est)
                {
                    coleccionEstilo.Add(v);
                }

            }
            return coleccionEstilo;
        }

        public Videojuegos()
        {
            videojuegos = new List<Videojuego>();
        }
    }
}
