namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yeyy Jueves");
            Lista miLista = new Lista();
            miLista.Agregar("A");
            miLista.Agregar("B");

            Console.WriteLine(miLista.ObtenerDatos());
        }
    }
}
