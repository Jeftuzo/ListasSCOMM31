namespace ListasSimplementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F***k Jueves!");
            Lista miLista = new Lista();

            miLista.Agregar("A");
            miLista.Agregar("B");
            miLista.Agregar("C");
            miLista.Agregar("D");

            miLista.Buscar("B");
            miLista.BuscarAnterior("D");

            Console.WriteLine("Dato en la lista circular:");
            Console.WriteLine(miLista.ObtenerDatos());

            miLista.EliminarNodo("C");
            Console.WriteLine("Datos en la lista circular despues de eliminar 'C'");
            Console.WriteLine(miLista.ObtenerDatos());
        }
    }
}
