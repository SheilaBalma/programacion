using System;

namespace guias
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio44();
        }
        static void Ejercicio43()
        {
            Console.WriteLine("Ingrese primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("numero uno es mayor");
            } else if (num1 < num2)
            {
                Console.WriteLine("numero uno es menor");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.WriteLine("Fin del programa");
        }
        static void Ejercicio53()
        {
            Console.WriteLine("Ingrese primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la operación: \n S,suma \n R, resta \n D, división \n M, multiplicación");
            string operacion = Console.ReadLine();
            operacion = operacion.ToUpper();
            switch (operacion)
            {
                case "S":
                    {
                        int ResultadoS = num1 + num2;
                        Console.WriteLine(ResultadoS);
                        break;
                    }
                case "R":
                    {
                        int ResultadoR = num1 - num2;
                        Console.WriteLine(ResultadoR);
                        break;
                    }
                case "M":
                    {
                        int ResultadoM = num1 * num2;
                        Console.WriteLine(ResultadoM);
                        break;
                    }
                case "D":
                    {
                        if (num2 != 0)
                        {
                            int ResultadoD = num1 / num2;
                            Console.WriteLine(ResultadoD);
                        }
                        else
                        {
                            Console.WriteLine("error matemático");
                        }
                        break;
                    }
            } Console.WriteLine("Opcion incorrecta, reinicie");
        }
        static void Ejercicio93()
        {
            Console.WriteLine("Ingrese valor de X");
            double X = Convert.ToInt32(Console.ReadLine());

            if (X > 0)
            {
                double Resultado = 1 - Math.Pow(2, (1 + X));
                Console.WriteLine(Resultado);
            }
            else if (X < 0)
            {
                double Resultado = 1 + Math.Pow(2, (1 + X));
                Console.WriteLine(Resultado);
            }
            else
            {
                Console.WriteLine("Resultado es 0");
            }
        }
        static void Ejercicio104()
        {
            int valor1;
            int valor2;
            int sumaPares = 0;
            int sumaImpares = 0;


            Console.WriteLine("Ingrese el primer numero");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            valor2 = Convert.ToInt32(Console.ReadLine());

            for (int num = valor1; num <= valor2; num++)
            {
                if (num % 2 == 0)
                {

                    sumaPares = sumaPares + num;
                }
                else
                {
                    sumaImpares = sumaImpares + num;
                }
            }
            Console.WriteLine("la suma de numeros pares es " + sumaPares + "\n la suma de numeros impares es " + sumaImpares);
        }
        static void Ejercicio135()
        {
            char letra;
            Console.WriteLine("ingrese una caden de caracteres");
            string texto = Console.ReadLine();
            texto = texto.ToUpper();

            // for(int i = 0; i < texto.lenght; i++)
            {
                //     letra = texto[i];
            }

        }
        static void Practicando104()
        {
            int PrimerNumero;
            int SegundoNumero;
            int SumadePares = 0;
            int SumadeImpares = 0;
            Console.WriteLine("Ingrese primer numero");
            PrimerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            SegundoNumero = Convert.ToInt32(Console.ReadLine());

            for (int ValorInicial = PrimerNumero; ValorInicial <= SegundoNumero; ValorInicial++)
            {
                if (ValorInicial % 2 == 0)
                {
                    SumadePares += ValorInicial;
                }
                else
                {
                    SumadeImpares += ValorInicial;
                }
            }
            Console.WriteLine("Suma pares es: " + SumadePares + "\n La suma impares es: " + SumadeImpares);

        }
        static void CP1()
        {
            string texto;
            char letra;
            int contadorvocales = 0;
            int contadorcons = 0;
            Console.WriteLine("ingrese un texto");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            for (int i = 0; i < texto.Length; i++)
            {
                letra = texto[i];
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    contadorvocales++;

                } else if (letra == 'X')
                {
                    Console.WriteLine("Termino con X");
                    break;
                } else if (letra == ' ')
                {

                }
                else
                {
                    contadorcons++;
                }
            }
            Console.WriteLine("cantidad de consonantes:" + contadorcons + "\ncantidad de vocales: " + contadorvocales);
        }
        static void CP2()
        {
            string texto;
            string textofinal = "  ";
            char letra;
            Console.WriteLine("ingrese el texto");
            texto = Console.ReadLine();
            texto = texto.ToUpper();

            for (int i = 0; i < texto.Length; i++)
            {
                letra = texto[i];
                switch (letra)
                {
                    case 'A':
                        {
                            letra = 'E';
                            textofinal += letra;
                            break;
                        }
                    case 'E':
                        {
                            letra = 'I';
                            textofinal += letra;
                            break;
                        }
                    case 'I':
                        {
                            letra = 'O';
                            textofinal += letra;
                            break;
                        }
                    case 'O':
                        {
                            letra = 'U';
                            textofinal += letra;
                            break;
                        }
                    case 'U':
                        {
                            letra = 'A';
                            textofinal += letra;
                            break;
                        }
                    default:
                        {
                            textofinal += letra;
                            break;
                        }
                }
            }
            Console.WriteLine(textofinal);
        }
        static void CP3()
        {
            string texto;
            string textofinal = "  ";
            int opcion;
            char letra;
            Console.WriteLine("ingrese el texto");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            Console.WriteLine("ingresa una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < texto.Length; i++)
            {
                letra = texto[i];

                switch (opcion)
                {
                    case 1:
                        {
                            if (letra == 'A')
                            {
                                letra = 'E';
                                textofinal += letra;
                            }
                            else
                            {
                                textofinal += letra;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (letra == 'E')
                            {
                                letra = 'I';
                                textofinal += letra;
                            }
                            else
                            {
                                textofinal += letra;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (letra == 'I')
                            {
                                letra = 'O';
                                textofinal += letra;
                            }
                            else
                            {
                                textofinal += letra;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (letra == 'O')
                            {
                                letra = 'U';
                                textofinal += letra;
                            }
                            else
                            {
                                textofinal += letra;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (letra == 'U')
                            {
                                letra = 'A';
                                textofinal += letra;
                            }
                            else
                            {
                                textofinal += letra;
                            }
                            break;
                        }
                    default:
                        {
                            textofinal += letra;
                            break;
                        }
                }

            }
            Console.WriteLine(textofinal);
        }
        static void Ejercicio144 ()
        {
            string texto;
            char letra;
            string textofinal = "  ";
            Console.WriteLine("numero");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            for(int i = 0; i <texto.Length; i++)
            {
                letra = texto[i];
                textofinal += letra;
                Console.WriteLine(textofinal);
            }
        }
        static void Ejercicio154()
        {
            //int[][] matrix;
            //int tamanio = 10;
            //int[] aux = new int[tamanio];
            //int[] arr = new int[20];
           

            //for (int i=0; i < 20; i++)
            //{
            //    arr[i] = i+2;
            //}

            //Console.WriteLine("ingrese la posición que desea observar (primer lugar=0)");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(index + ": " + arr[index]);

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i + ": " + arr[i]);
            //}


            int cantidadA=0;
            //int[][] arr = new int[cantidadA][]

            int nota1;
            int nota2;
            int nota3;
            double promedio;
            string nombre;
            Console.Write("Ingrese la cantidad de alumnos: ");
            cantidadA = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= cantidadA; i++)
            {
                Console.Write("Ingrese el nombre del alumno: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del primer examen");
                nota1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del segundo examen");
                nota2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del Trabajo Practico");
                nota3 = Convert.ToInt32(Console.ReadLine());
                promedio = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("Primer nota:"+nota1+"\n Segunda nota 2:"+nota2+"\n Tercer nota:"+nota3+"\n El promedio es:"+promedio);
            }
        }
        static void Ejercicio44()
        {
            char opcion;
            int numeroA;
            int numeroB;
            double promedio=0;
            int cantidad=0;
            int SumaTotal=0;
            Boolean salir = false;

            while(!salir)
            {
            Console.WriteLine("Ingrese el primer numero");
            numeroA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numeroB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la opcion:\n 1,saber el promedio. \n 2,salir del programa");
            string Oopcion = Console.ReadLine();
            opcion = Convert.ToChar(Oopcion);
            
            
                switch (opcion)
                {
                    case '1':
                        {
                            if (numeroA < numeroB || numeroA == numeroB)
                            {
                                for (int i = numeroA + 1; i < (numeroB - 1); i++)
                                {
                                    cantidad++;
                                    SumaTotal += i;
                                    promedio = SumaTotal / cantidad;

                                }

                                Console.WriteLine("el promedio es: " + promedio);
                                salir = true;
                            }
                            else if (numeroA > numeroB)
                            {
                                Console.WriteLine("Opcion incorrecta");
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("usted salio del programa");
                            salir = true;
                            break;
                        }
                }
            }
        }
    }
}