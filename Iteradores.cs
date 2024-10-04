using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logica
{
    public class Iteradores
    {
        public void CicloWhile()
        {

        }

        public void CicloDoWhile()
        {

        }

        public void CicloFor()
        {

        }

        public void CicloForEach()
        {
            // Necesita un derivado de IEnumerable, por ejemplo
            // una lista de ints.
            List<int> enteros = new List<int>() { 2, 4, 6, 28, 2466, 8998 };

            // puede utilizarse en un array de los tipos primitivos
            int[] arrayDeEnteros = new int[] { 2, 4, 6, 8, 28, 2466, 8998 };

            CondicionalIf[] arrayClasePropia = new CondicionalIf[] { new CondicionalIf(), new CondicionalIf(), new CondicionalIf() };

            foreach (var item in enteros)
            {
                System.Console.Write(item + " "); // salida: "2 4 6 28 2466 8998"
            }
            foreach (var item in arrayDeEnteros)
            {
                System.Console.Write(item + " "); // salida: "2 4 6 28 2466 8998"
            }
            foreach (var item in arrayClasePropia)
            {
                System.Console.Write(item.ToString() + " "); // salida: ""
            }


            #region Que son los IEnumerables
            // Este ciclo repetitivo funciona con IEnumerables,
            // System.Collections.IEnumerable es una clase de la cual derivan, por 
            // ejemplo, las List<T>, IEnumerator, y otras listas enumerables
            // https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.ienumerable-1?view=net-8.0

            // Ejemplos de implementacion intermedios-avanzados *(lectura de archivos)*
            // se utilizan tambien en los Streams de escritura.
            // https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.ienumerable-1?view=net-8.0#examples

            #endregion

        }

    }
}
