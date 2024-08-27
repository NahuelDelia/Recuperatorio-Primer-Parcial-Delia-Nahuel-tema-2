namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double mayorVolumen = 0;
                double mayorSuperficie = 0;
                int iteracion = 0;
                double promedioVolumen = 0;
                double promedioSuperficie = 0;
                Console.WriteLine("----- CILINDROS -----");
                Console.Write("¿Cuandos cilindros deseas ingresar?: ");
                int topecilindros = int.Parse(Console.ReadLine());
                if (topecilindros > 0)
                {
                    for (int i = 0; i < topecilindros; i++)
                    {
                        Console.WriteLine($"----- CILINDRO N:{i + 1} -----");
                        Console.Write("Ingresa el Radio del cilindro:");
                        double radio = double.Parse(Console.ReadLine());
                        Console.Write("Ingresa la Altura del cilindro:");
                        double alto = double.Parse(Console.ReadLine());

                        if (radio > 0 && alto > 0)
                        {
                            double volumen = CalcularVolumen(radio, alto);
                            double superficie = CalcularSuperficie(radio, alto);

                            Console.WriteLine("----- RESULTADOS -----");
                            Console.WriteLine($"Volumen del Cilindro: {volumen:N2}");
                            Console.WriteLine($"Superficie del Cilindro: {superficie:N2}");

                            promedioVolumen += volumen;
                            if (volumen > mayorVolumen)
                            {
                                mayorVolumen = volumen;
                                iteracion = i;
                            }

                            promedioSuperficie += superficie;
                            if (superficie > mayorSuperficie)
                            {
                                mayorSuperficie = superficie;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Verifica que los datos ingresados sean válidos e intentalo nuevamente.");
                        }

                        promedioVolumen /= topecilindros;
                        Console.WriteLine($"Promedio de Superficies: {promedioSuperficie:N2}");
                        Console.WriteLine($"Cilindro de mayor volumen: {mayorVolumen:N2}");
                        Console.WriteLine($"Iteración {i}");
                    }
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

        private static double CalcularVolumen(double radio, double alto)
        {
            return (Math.PI * Math.Pow(radio, 2) / alto);
        }

        private static double CalcularSuperficie(double radio, double alto)
        {
            return ((2 * Math.PI) * Math.Pow(radio, 2)) + ((2 * Math.PI) * radio * alto);
        }
    }
}
