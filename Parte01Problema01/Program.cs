using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("INSTRUCCIONES");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("01. Siempre presione ENTER para avanzar");
            Console.WriteLine("02. Recuerda que para salir del programa escriba SALIR respetando las mayúsculas");
            Console.WriteLine("03. Escriba alguna palabra que desee transformar, presion ENTER");            

            string word= Console.ReadLine();
            string ExitWord = "SALIR";
            ChangeString _ChangeString = new ChangeString();
            string Result = "";

            while (word != ExitWord)
            {                

                Result = "";
                
                Result = _ChangeString.build(word);

                Console.WriteLine(Result);
                Console.WriteLine("-------------------------------------");
                word = Console.ReadLine();
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA, para salir presione alguna tecla");
            Console.ReadKey();

            
        }
    }
}
