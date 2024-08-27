using System.Text;

namespace cilindro.entidades
{
    public struct Cilindro
    {
        public double r { get; set; }
        public double h { get; set; }

        public Cilindro(double radio, double alto)
        {
            r = radio;
            h = alto;
        }

        public static double superficie(double r, double h)
        {
            return ((2 * Math.PI) * Math.Pow(r, 2)) + ((2 * Math.PI) * r * h);
        }

        public static double volumen(double r, double h)
        {
            return (Math.PI * Math.Pow(r, 2) / h);
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Valor del área: {superficie}");
            sb.AppendLine($"Valor del volumen: {volumen}");

            return sb.ToString();
        }
    }
    

    
    
}
