
namespace punto1.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----- CILINDROS -----");
                Console.Write("Ingresa el Radio del cilindro:");
                double radio = double.Parse(Console.ReadLine());
                Console.Write("Ingresa la Altura del cilindro:");
                double alto = double.Parse(Console.ReadLine());

                if (radio > 0 && alto > 0)
                {
                    Console.Clear();
                    Console.WriteLine("----- DATOS -----");
                    Console.WriteLine($"RADIO: {radio}");
                    Console.WriteLine($"ALTURA: {alto}");

                    double volumen = CalcularVolumen(radio, alto);
                    double superficie = CalcularSuperficie(radio, alto);


                    Console.WriteLine("----- RESULTADOS -----");
                    Console.WriteLine($"Volumen del Cilindro: {volumen}");
                    Console.WriteLine($"Superficie del Cilindro: {superficie}");
                }
                else
                {
                    Console.WriteLine("Verifica que los datos ingresados sean válidos e intentalo nuevamente.");
                }
            }
            catch (Exception ex)
            {

                Console.Clear();
                Console.WriteLine("Algo salió mal o los datos fueron mal ingresados, intentelo de nuevo." +Environment.NewLine + ex.Message);
            }
        }

        private static double CalcularSuperficie(double radio, double alto)
        {
            return ((2 * Math.PI) * Math.Pow(radio,2)) + ((2* Math.PI) * radio * alto);
        }

        private static double CalcularVolumen(double radio, double alto)
        {
            return (Math.PI * Math.Pow(radio,2) / alto);
        }
    }
}
