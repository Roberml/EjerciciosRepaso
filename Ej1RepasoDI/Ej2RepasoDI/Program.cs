using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2RepasoDI
{
    class Program
    {
        public static Random rand = new Random();


        public static int numeroAleatorio()
        {
            int resultado;
            int per = rand.Next(0, 101);
            if (per <= 5)
            {
                resultado = 0;
            }
            else
            {
                if (per >= 6 &&per<= 10)
                {
                    resultado = 1;
                }
                else
                {
                    if (per >= 11 && per <= 15)
                    {
                        resultado = 2;
                    }
                    else
                    {
                        if (per >= 16 && per <= 25)
                        {
                            resultado = 3;
                        }
                        else
                        {
                            if (per >= 26 && per <= 40)
                            {
                                resultado = 4;
                            }
                            else
                            {
                                if (per >= 41 && per <= 55)
                                {
                                    resultado = 5;
                                }
                                else
                                {
                                    if (per >= 56 && per <= 70)
                                    {
                                        resultado = 6;
                                    }
                                    else
                                    {
                                        if (per >= 71 && per <= 80)
                                        {
                                            resultado = 7;

                                        }
                                        else
                                        {
                                            if (per >= 81 && per <= 90)
                                            {
                                                resultado = 8;
                                            }
                                            else
                                            {
                                                if (per >= 91 && per <= 95)
                                                {
                                                    resultado = 9;
                                                }
                                                else
                                                {
                                                    resultado = 10;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

           












            return resultado;
        }
        static void Main(string[] args)
        {
            int media;
            int suma=0;
            for (int i = 0; i < 100; i++)
            {
               int num = numeroAleatorio();
                Console.WriteLine(num);
                suma += num;
                
                
            }
            media = suma / 100;
            Console.WriteLine("media: "+media);
            Console.ReadKey();
        }
    }
}
