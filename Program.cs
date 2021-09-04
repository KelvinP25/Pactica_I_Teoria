using System;

namespace Practica_1
{
    class Program
    {
        public enum Dias
        {
            Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
        }
        static void Main(string[] args)
        {
            int menu = 0;
            int menuCap1 = 0, menuCap2 = 0, menuCap3 = 0;
            //Menu general
            do
            {
                Console.WriteLine("----- MENU PRINCIPAL -----\n\n");
                Console.WriteLine("Elija una Opccion: ");
                Console.WriteLine("1- Capitulo 1");
                Console.WriteLine("2- Capitulo 2");
                Console.WriteLine("3- Capitulo 3");
                Console.WriteLine("4- Salir");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        //Menu del capitulo I
                        do
                        {

                            Console.WriteLine("----- CAPITULO I -----\n\n");
                            Console.WriteLine("Elija una Opccion: ");
                            Console.WriteLine("1- Ejercicio 1");
                            Console.WriteLine("2- Ejercicio 5");
                            Console.WriteLine("3- Salir");
                            menuCap1 = Convert.ToInt32(Console.ReadLine());
                            switch (menuCap1)
                            {
                                case 1:
                                    ImprimirNombre();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    NombreFrase();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3: break;
                                default:
                                    Console.WriteLine("Opccion no valida, elija un numero vaido");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (menuCap1 != 3);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        //Menu del CAPITULO II
                        do
                        {
                            Console.WriteLine("----- CAPITULO II -----\n\n");
                            Console.WriteLine("Elija una Opccion: ");
                            Console.WriteLine("1- Ejercicio 1");
                            Console.WriteLine("2- Ejercicio 3");
                            Console.WriteLine("3- Ejercicio 4");
                            Console.WriteLine("4- Ejercicio 5");
                            Console.WriteLine("5- Salir");
                            menuCap2 = Convert.ToInt32(Console.ReadLine());
                            switch (menuCap2)
                            {
                                case 1:
                                    PerimetroPoligono();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Radianes();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    ConvertidorGrados();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    ConvertirDollarEuro();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 5: break;
                                default:
                                    Console.WriteLine("Opccion incorrecta");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (menuCap2 != 5);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        //menu del CAPITULO III
                        do
                        {
                            Console.WriteLine("----- CAPITULO III -----\n\n");
                            Console.WriteLine("Elija una Opccion: ");
                            Console.WriteLine("1- Ejercicio 1");
                            Console.WriteLine("2- Ejercicio 4");
                            Console.WriteLine("3- Salir");
                            menuCap3 = Convert.ToInt32(Console.ReadLine());
                            switch (menuCap3)
                            {
                                case 1:
                                    NumPar();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Semana();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3: break;

                                default:
                                    Console.WriteLine("Opccion incorrecta");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (menuCap3 != 3);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4: break;

                    default:
                        Console.WriteLine("Opccion incorrecta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (menu != 4);


        }

        // EJERCICIO 1 DEL CAPITULO I
        public static void ImprimirNombre()
        {
            Console.WriteLine("Kelvin Peña");
        }

        // EJERCICIO 5 DEL CAPITULO I
        public static void NombreFrase()
        {
            ImprimirNombre();
            Console.WriteLine("Hola \n¿Que tal?");
        }

        // EJERCICIO 1 DEL CAPITULO II
        public static void PerimetroPoligono()
        {
            double perimetro = 0.00;
            double lados, longitud;
            Console.WriteLine("Ingrese la cantidad de lados");
            lados = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud de uno de sus lados");
            longitud = Convert.ToDouble(Console.ReadLine());

            perimetro = longitud * lados;

            Console.WriteLine($"El perimetro es: {perimetro}");
        }

        // EJERCICIO 3 DEL CAPITULO II
        public static void Radianes()
        {
            float grados = 0;
            double radianes = 0;
            Console.WriteLine("Ingrese la cantidad de grados: ");
            grados = Convert.ToSingle(Console.ReadLine());

            radianes = (grados * Math.PI) / 180;
            Console.WriteLine($"EL total en radianes son {radianes}");

        }

        // EJERCICIO 4 DEL CAPITULO II
        public static void ConvertidorGrados()
        {
            float gradosCen = 0;
            float gradosFa = 0;
            Console.WriteLine("Ingrese la cantidad de grados Centigrados: ");
            gradosCen = Convert.ToSingle(Console.ReadLine());

            gradosFa = (gradosCen * 9 / 5) + 32;
            Console.WriteLine($"EL total de grados en Fahrenheit es: {gradosFa}");
        }

        // EJERCICIO 5 DEL CAPITULO II
        public static void ConvertirDollarEuro()
        {
            float dollar = 0;
            float euros = 0, dinero = 0;
            int Op = 0;

            Console.WriteLine("Elija una opccion a la cual desea cambiar: ");
            Console.WriteLine("1- Dollar");
            Console.WriteLine("2- Euro");


            Op = Convert.ToInt32(Console.ReadLine());
            if (Op == 1)
            {
                Console.WriteLine("Ingrese la cantidad de euros que desea cambiar");
                dinero = Convert.ToSingle(Console.ReadLine());
                dollar = dinero * 1.19f;
                Console.WriteLine($"La cantidad de dinero en dollar es: {dollar}");
            }
            if (Op == 2)
            {
                euros = dinero * 0.84f;
                Console.WriteLine($"La cantidad de dinero en euros es: {euros}");
            }


        }

        // EJERCICIO 1 DEL CAPITULO III
        public static void NumPar()
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par..");
            }
            else
            {
                Console.WriteLine("El numero es Impar..");
            }
        }

        // EJERCICIO 4 DEL CAPITULO III
        public static void Semana()
        {
            int num;
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            num = Convert.ToInt32(Console.ReadLine());

            Dias dia = (Dias)num;

            Console.WriteLine(dia);
        }
    }
}
