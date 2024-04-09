namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            bool estado;
            float valorIngresado;

            numeroIngresado = Console.ReadLine();
            estado = int.TryParse(valorIngresado, out numeroIngresado);

            if (numeroIngresado > 0 && estado)
            {
                Math.Pow(numeroIngresado, 2);
                Math.Pow(numeroIngresado, 3);
                Console.WriteLine()
            }


        }
    }
}
