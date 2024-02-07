namespace calEdadDiferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############# CALCULADORA FECHAS ##############");
            Console.WriteLine("Ingrese la primera fecha mayor (DD/MM/AAAA HH:MM:SS) :");
            DateTime fcha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda fecha menor (DD/MM/AAAA HH:MM:SS):");
            //Console.WriteLine("Introduce tu segunda fecha : ");
            DateTime fcha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan diferencia = fcha1 - fcha2;

            Console.WriteLine("Diferencia: "+ diferencia.Days +" días, "+ diferencia.Hours +" horas, " +
                + diferencia.Minutes + " minutos, "  + diferencia.Seconds + " segundos.");
        }

    }
}
