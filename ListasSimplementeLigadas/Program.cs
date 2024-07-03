namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F***k Miercoles");
            Lista miLista = new Lista();
            miLista.Agregar("A");
            miLista.Agregar("B");
            miLista.Agregar("C");


            Console.WriteLine(miLista.ObtenerDatos());

            Console.WriteLine("Buscando B");
            Nodo? nodoB = new Nodo();
            nodoB = miLista.Buscar("B");
            if (nodoB != null)
            {
                Console.WriteLine(nodoB.Dato);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }

            try
            {
                Console.WriteLine("");
                Console.WriteLine("Eliminar B");
                miLista.EliminarNodo("B");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurio un error {ex.Message}");
            }

            Console.WriteLine(miLista.ObtenerDatos());
        }
    }
}
