using System;

namespace Calculadora_Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            double respuesta = 0;
            double angulo;
            double radianes;
            double valorPi = 3.14159;

            Console.WriteLine("[CALCULADORA MÁGICA] \n ¿Cuántos valores desea emplear en las operaciones?");
            //Declaramos e inicializamos las variables "numValores" (valores usados) y "arrayValores" (array para guardar los datos).
            int numValores = int.Parse(Console.ReadLine());
            int[] Valores = new int[numValores];
            //Ciclo For para rellenar el array con los datos.
            for (int i = 0; i < numValores; i++)
            {
                Console.WriteLine("Ingrese el valor del número " + (i + 1));
                //Cada nuevo valor será guardado en el espacio en turno (i) del array "Valores"
                Valores[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("¿Qué operación desea realizar?\n1-Suma\n2-Resta\n3-División\n4-Multiplicación\n5-Seno\n6-Tangente\n7-Coseno");
            //La variable "opc" lee la elección del usuario.
            opc = int.Parse(Console.ReadLine());
            //Switch para evaluar la respuesta del usuario, con respecto a la variable "opc".
            switch (opc)
            {
                case 1: //Suma
                    //Ciclo para sumar todos los valores dentro del array.
                    for (int x = 0; x < numValores; x++)
                    {
                        //En cada ciclo, se sumará el valor anterior de la variable "respuesta" con el valor en turno del array "Valores".
                        respuesta += Valores[x];
                    }

                    break;

                case 2: //Resta
                    //Ciclo for para realizar las repeticiones necesarias de los cálculos
                    for (int x = 0; x < numValores; x++)
                    {
                        /* 
                         Sí es el primer turno (x = 0), se inicializa la variable "respuesta" con 
                         el primer valor ingresado para evitar fallos en el cálculo, ya que de no hacerlo
                         le estaríamos restando el primer valor a 0, que es el valor por defecto de la
                         variable respuesta.
                        */
                        if (x == 0)
                        {
                            respuesta = Valores[0];
                        }
                        /*
                         una vez inicializada la variable "respuesta" se procede al cálculo. En cada ciclo, el valor de respuesta
                         se reducirá dependiendo del valor en turno de Valores [x]
                         */
                        else
                        {
                            respuesta -= Valores[x];
                        }
                    }
                    break;

                case 3: //División
                    //Ciclo for para realizar las repeticiones necesarias de los cálculos
                    for (int x = 0; x < numValores; x++)
                    {
                        /* 
                         Sí es el primer turno (x = 0), se inicializa la variable "respuesta" con 
                         el primer valor ingresado para evitar fallos en el cálculo, ya que de no hacerlo
                         estaríamos diviendo el primer dato entre 0, que es el valor por defecto de la
                         variable respuesta.
                        */
                        if (x == 0)
                        {
                            respuesta = Valores[0];
                        }
                        /*
                         una vez inicializada la variable "respuesta" se procede al cálculo. En cada ciclo, el valor de respuesta
                         aumentará dependiendo del valor en turno de Valores [x].
                         */
                        else
                        {
                            respuesta /= Valores[x];
                        }
                    }
                    break;

                case 4: //Multiplicación
                    //Ciclo for para realizar las repeticiones necesarias de los cálculos
                    for (int x = 0; x < numValores; x++)
                    {
                        /* 
                         Sí es el primer turno (x = 0), se inicializa la variable "respuesta" con 
                         el primer valor ingresado para evitar fallos en el cálculo, ya que de no hacerlo
                         le multiplicando el primer valor con 0, que es el valor por defecto de la
                         variable respuesta.
                        */
                        if (x == 0)
                        {
                            respuesta = Valores[0];
                        }
                        /*
                         una vez inicializada la variable "respuesta" se procede al cálculo. En cada ciclo, el valor de respuesta
                         aumentará dependiendo del valor en turno de Valores [x].
                         */
                        else
                        {
                            respuesta *= Valores[x];
                        }
                    }
                    break;

                case 5: //Seno
                    //Inicializamos la variable "angulo" al convertir el valor del array en double.
                    angulo = Convert.ToDouble(Valores.GetValue(0));
                    //Realizamos la conversión a radianes.
                    radianes = angulo * (valorPi / 180);
                    //Mediante función Math.Sin calculamos el seno.
                    respuesta = Math.Sin(radianes);
                    break;

                case 6: //Tangente
                    //Inicializamos la variable "angulo" al convertir el valor del array en double.
                    angulo = Convert.ToDouble(Valores.GetValue(0));
                    //Realizamos la conversión a radianes.
                    radianes = angulo * (valorPi / 180);
                    //Mediante función Math.Tan calculamos la Tangente.
                    respuesta = Math.Tan(radianes);
                    break;

                case 7: //Coseno
                    //Inicializamos la variable "angulo" al convertir el valor del array en double.
                    angulo = Convert.ToDouble(Valores.GetValue(0));
                    //Realizamos la conversión a radianes.
                    radianes = angulo * (valorPi / 180);
                    //Mediante función Math.Cos calculamos el Coseno.
                    respuesta = Math.Cos(radianes);
                    break;
            } 

            Console.WriteLine("El resultado es " + respuesta);
            Console.WriteLine("Gracias por usar [CALCULADORA MÁGICA].");
            Console.ReadKey();
        }
    }
}
