namespace ListasDoblementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToString("dd MM yyyy"));
            int diaSemana = (int)DateTime.Now.DayOfWeek;
            string dia;
            switch (diaSemana)
            {
                case 1: dia = "Lunes"; break;
                case 2: dia = "Martes"; break;
                case 3: dia = "Miercoles"; break;
                case 4: dia = "Jueves"; break;
                case 5: dia = "Viernes"; break;
                case 6: dia = "Sabado"; break;
                case 7: dia = "Domingo"; break;
                default: dia = "NA"; break;
            }
            Console.WriteLine($"F**k {dia}!");
            Lista milista = new Lista();
            milista.Agregar("A");
            milista.Agregar("B");
            milista.Agregar("C");
            milista.Agregar("D");

            Console.WriteLine(milista.ObtenerDatos());
            Console.WriteLine(milista.ObtenerDatosReversa());
        }
    }
}
