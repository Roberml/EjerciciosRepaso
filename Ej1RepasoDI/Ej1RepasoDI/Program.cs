#define COSA



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Cambiar por funciones

namespace Ej1RepasoDI
{
    class Program
    {

        public static int pedirEntero()
        {
            bool isNum;
            int num=0;
            string a;
            do
            {
                try
                {

                    isNum = true;
                    Console.WriteLine("dime un número");
                    a = Console.ReadLine();
                    num = Convert.ToInt32(a);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("escribe un número válido");
                    isNum = false;
                }

            } while (!isNum);

            return num;
           
        }

        public static Videojuego crearVideojuego()
        {
            string titulo;
            int año;
            Videojuego v=new Videojuego("", 0, Videojuego.Estilo.Arcade);
            try {     
                Console.WriteLine("dime titulo para el juego");
                titulo = Console.ReadLine();
                Console.WriteLine("año de salida");
                año = pedirEntero();
                Videojuego.Estilo est = elegirEstilo();
                v = new Videojuego(titulo, año, est);
                




            }catch (FormatException e)
            {
                Console.WriteLine("parámetros no válidos");
                

                
            }

            return v;

            


        }

        public static Videojuego.Estilo elegirEstilo()
        {
            Videojuego.Estilo est=Videojuego.Estilo.Arcade;
            try
            {
                
                Console.WriteLine("de qué estilo es");
                do
                {
                    for (int i = 0; i < Enum.GetNames(typeof(Videojuego.Estilo)).Length; i++)
                    {
                        Console.WriteLine(i + 1 + ": " + ((Videojuego.Estilo)(i + 1)));
                    }
                    est = (Videojuego.Estilo)Convert.ToInt32(Console.ReadLine());

                } while ((int)est > 5||(int)est<=0);
               

            }
            catch (FormatException e)
            {
                Console.WriteLine("parámetros no válidos");
                
            }
            return est;


        }


        static void Main(string[] args)
        {

#if COSA
            Videojuegos vjs = new Videojuegos();
            Videojuego v1 = new Videojuego("Uncharted", 2008, Videojuego.Estilo.Videoaventura);
            Videojuego v2 = new Videojuego("Monkey Island", 1990, Videojuego.Estilo.Videoaventura);
            Videojuego v3 = new Videojuego("Space Invaders", 1978, Videojuego.Estilo.Arcade);
            vjs.videojuegos.Add(v3);
            vjs.videojuegos.Add(v2);
            vjs.videojuegos.Add(v1);
            vjs.videojuegos.Add(v1);
            vjs.videojuegos.Add(v1);
            vjs.videojuegos.Add(v1);
            vjs.videojuegos.Add(v1);


#endif
            bool funcionando = true;

            try
            {
                do
                {


                    Console.WriteLine("1: Insertar nuevo juego");
                    Console.WriteLine("2: Eliminar videojuegos");
                    Console.WriteLine("3: Visualizar lista");
                    Console.WriteLine("4: Visualizar estido");
                    Console.WriteLine("5: Modificar videojuego");
                    Console.WriteLine("6: Salir del programa");
                    int opc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("-----------------------------------------------------------");

                    switch (opc)
                    {
                        case 1:

                            Videojuego vCrear = crearVideojuego();

                            vjs.videojuegos.Insert(vjs.Posicion(vCrear.Año), vCrear);
                            Console.WriteLine("Juego añadido");



                            break;


                        case 2:
                            try
                            {
                                int a;
                                int b;
                                Console.WriteLine("Dime posiciones");
                                Console.WriteLine("posicion minima");
                                string astring = Console.ReadLine();
                                Console.WriteLine("posicion maxima");
                                string bstring = Console.ReadLine();
                                if (astring == "" && bstring == "")
                                {
                                    Console.WriteLine("no has puesto parametros");

                                }
                                else
                                {
                                    if (astring == "" && bstring != "")
                                    {
                                        b = Convert.ToInt32(bstring);

                                        if (vjs.Eliminar(b) == true)
                                        {
                                            Console.WriteLine("videojuegos eliminados");
                                        }
                                        else
                                        {
                                            Console.WriteLine("ha ocurrido un error");
                                        }

                                    }
                                    else
                                    {
                                        if (astring != "" && bstring != "")
                                        {
                                            a = Convert.ToInt32(astring);
                                            b = Convert.ToInt32(bstring);
                                            if (vjs.Eliminar(a, b) == true)
                                            {
                                                Console.WriteLine("videojuegos eliminados");
                                            }
                                            else
                                            {
                                                Console.WriteLine("ha ocurrido un error");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("has introducido mal los parámetros");
                                        }

                                    }
                                }

                            }
                            catch (System.FormatException e)
                            {

                                Console.WriteLine("parámetros no validos");
                            }


                            break;


                        case 3:

                            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "titulo", "estilo", "posición");
                            for (int i = 0; i < vjs.videojuegos.Count; i++)
                            {
                                Console.WriteLine("{0,-20} {1,-20} {2,-20}", vjs.videojuegos[i].Titulo, vjs.videojuegos[i].estilo, i);

                            }




                            break;


                        case 4:

                            for (int i = 0; i < Enum.GetNames(typeof(Videojuego.Estilo)).Length; i++)
                            {
                                Console.WriteLine(i + 1 + ": " + ((Videojuego.Estilo)(i + 1)));
                            }
                            int opcEestilo = Convert.ToInt32(Console.ReadLine());
                            foreach (Videojuego v in vjs.Busqueda((Videojuego.Estilo)opcEestilo))
                            {
                                Console.WriteLine(v.Titulo + " " + v.Año);
                            }
                            if (opcEestilo > Enum.GetNames(typeof(Videojuego.Estilo)).Length)
                            {
                                Console.WriteLine("estilo no encontrado");
                            }



                            break;


                        case 5:
                            try
                            {
                                Console.WriteLine("que juego quieres modificar");
                                int pos = Convert.ToInt32(Console.ReadLine());
                                Videojuego vNuevo = crearVideojuego();
                                vjs.videojuegos[pos] = vNuevo;

                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine("juego no encontrado");

                            }







                            break;





                        case 6:
                            Console.WriteLine("Adiós");
                            Console.ReadLine();
                            funcionando = false;


                            break;




                        default:
                            break;
                    }

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("-----------------------------------------------------------");

                } while (funcionando);

            }
            catch (FormatException e)
            {
                Console.WriteLine("opción no válida");

                throw;
            }

           

        }



    }
}
