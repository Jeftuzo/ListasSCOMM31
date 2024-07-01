namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F***k Lunes");
            Lista miLista = new Lista();
            miLista.Agregar("A");
            miLista.Agregar("B");

            Console.WriteLine(miLista.ObtenerDatos());

            Console.WriteLine("Buscando B");
            Nodo? nodoB = new Nodo();
            nodoB = miLista.Buscar("B");
            if (nodoB != null )
            {
                Console.WriteLine(nodoB.Dato);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }
    }
}
