using System;

namespace ConsoleAppDelegatesCSharp
{
    class Program
    {

        public delegate void test(string nombre);
        delegate int delegadoSumar(int num1, int num2);
        delegate string delegadoHW();
        delegate void test2();
        static void Main(string[] args)
        {
            //Ejemplo delegado 1, configado desde la propiedad de tipo de delegado que puede asignarsele un metodo en su constructor
            //realizando una instancia como si se trata de un objeto.-
            test test1 = new test(muestraMensaje); 
            test1("Samuel");


            //Ejemplo 2: Creamos la propiedad de tipo delegado
            //como estamos en una clase estatica debemos tambien crear los metodos de tipo static
            delegadoSumar metodoSumar = new delegadoSumar(sumar);
            int sumatoria = metodoSumar(1, 3);

            //Ejemplo 3: En este caso tenemos un delegado en el cual asignamos un metodo anonimo
            delegadoHW delegadoHelloWorld = delegate () { return "Hello world";  };
            string mensajeRetornado  = delegadoHelloWorld(); //aqui invocamos el delegado y nos retorna el mensaje Hello world

            //Ejemplo 4:
            test2 delegadoSms = delegate () { Console.WriteLine("Test Sms"); };
            delegadoSms();

        }
        
        public static void muestraMensaje(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }

        public static int sumar(int num1 , int num2)
        {
            return num1 + num2;
        }
    }
}
