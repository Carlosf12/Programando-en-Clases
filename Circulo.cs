  class Program
    {
        static void Main(string[] args)
        {
            //Variables Auxiliares
            double area = 0, radio = 0;

            //Explicación del ejercicio
            Console.WriteLine("Encontrar el Area de un Circulo.");
            
            //Pediendo datos
            Console.Write("Ingrese el radio del circulo: ");
            
            //Convierte de texto a tipo entero
            radio = Int32.Parse(Console.ReadLine());

            //Realiza la operación
            area = radio * radio * 3.1415;

            //Imprimiendo el resultado
            Console.WriteLine("El Area del Circulo: " + area);

            //El programa espera a que se reciba una tecla
            //La funcion de esto es que no se cierre el programa
            Console.ReadKey();
        }
    }