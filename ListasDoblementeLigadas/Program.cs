namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F***k Lunes!");
            Lista milista= new Lista();
            milista.Agregar ("A");
            milista.Agregar ("B");
            milista.Agregar ("C");
            milista.Agregar ("D");

            Console.WriteLine(milista.ObtenerDatos());

            Console.WriteLine("Datos en reversa");
            Console.WriteLine(milista.ObtenerDatosReversa());

            milista.Eliminar("A");
            milista.Eliminar("C");


        }
    }
}
