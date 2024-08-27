using cilindro.entidades;

namespace punto3.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio: ");
            var r = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el alto: ");
            var h = int.Parse(Console.ReadLine());
            Cilindro c = new Cilindro(r, h);
            Console.WriteLine(c.GetInfo());
        }
    }
}
