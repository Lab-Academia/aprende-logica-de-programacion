using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logica
{
    public enum TiposDeDato
    {
        Int, // int ... numeros enteros (Z)
        Float, // float ... numeros reales (R)
        Char, // char .. caracteres (letras, numeros, simbolos)
        String, // string .. cadenas de caracteres (palabras, oraciones, parrafos)
    }

    // Variables: 
    // var name = value 
    // es un espacio reservado de memoria que puede variar su contenido
    // durante la ejecucion del programa.
    // el identificador guarda un puntero hacia un espacio de memoria específico donde
    // se encuentra el objeto
    
    public enum EstructurasDeDato
    {
        ArrayUnidimensional, // var[] name = {x,y,z} ... espacios contiguos de memoria, ordenados de 0 a N-1 (N = num. de elementos)
        ArrayMultidimensional, // var[,...,] name = [{},...,{}] matrices de 2 o mas dimensiones
        LinkedList, // List<T> name = {} .. coleccion lineal de datos organizados en nodos enlazados (cada nodo sabe donde esta el proximo) 
        ArraysAsociativos, // Dictionary, HashMap ..  Array dinamico mapeado key:value
        Grafos, // Arbol es el grafo mas usado. Pueden representar redes de nodos.
        Clases, // Plantillas para crear objetos de datos segun un modelo.
                // Son representaciones abstractas de conceptos.
                // Contienen campos y operaciones propias y de sus parientes
                // Se guardan en la memoria heap
        Structs, // Plantillas para crear objetos de datos segun un modelo.
                 // Son representaciones abstractas de conceptos.
                 // Contienen campos y operaciones propias y de sus parientes
                 // Se generan en stack (+ eficientes, útiles en objetos livianos)
        Enums, // Enumeradores.
               // Array de constantes enteras.
               // Cada nombre esta asociado a un valor entero
    }
    
    // Material de apoyo : class https://www.developerro.com/2023/07/26/class-struct-record/
    
    public class Variables
    {
        #region Variables
        // Declaracion de variables
        // tipo identificador = valor;
        // tipo: un tipo de dato primitivo, o definido por el usuario (Clase)
        // identificador: un nombre o alias con el que referiremos a este espacio de memoria
        // = valor: valor opcional asignado a la variable. el valor debe corresponder con el tipo especificado

        int numeroEnteroA; // variable tipo entero llamada "numeroEnteroA", con valor 0
        int numeroEnteroB = 5; // variable tipo entero llamada "numeroEnteroB" con valor 5 asignado
        int numeroEnteroC = -1; // variable tipo entero llamada "numeroEnteroC" con valor -1 asignado

        float numeroDecimalA; // variable tipo num. punto flotante llamada "numeroDecimalA", con valor 0
        float numeroDecimalB = 3.141592f; // variable tipo numerico de punto flotante llamada "numeroDecimalB", con valor 3.141592

        char caracterA; // variable tipo caracter llamada "caracterA", con valor null
        char caracterB = 'w'; // variable tipo caracter llamada "caracterB", con valor w
        // los caracteres se tratan con comillas simples ' '.
        char caracterC = ' '; // "caracterC", valor "espacio" 
        char caracterD = '\n'; // "caracterD", valor "salto de linea"
        char caracterE = '\t'; // "caracterE", valor "tabulacion"
        char caracterF = '\0'; // "caracterF", valor "fin de cadena" 

        string textoA; // variable tipo cadena de texto llamada "textoA", con valor null
        string textoB = "Hola, mundo!"; // variable tipo cadena de texto, con valor "Hola, mundo!"
                                        // los textos/cadenas se tratan con comillas dobles " ";
        #endregion

        #region Uso de Variables
        void EjemploUsoVariablesA()
        {
            numeroEnteroA = 17; // asignar el valor 17 en la variable numeroEnteroA
            numeroEnteroA = 16 + 128; // asignar la suma de dos constantes, 16 y 128 a numeroEnteroA
            numeroEnteroA = numeroEnteroB + 1; // asignar la suma de una variable, numeroEnteroB(tipo int) y la constante 1 a numeroEnteroA
            numeroEnteroA = numeroEnteroB + numeroEnteroC; // asignar la suma de las variables numeroEnteroB y numeroEnteroC a numeroEnteroA

            // 3 variantes de lo mismo 
            numeroEnteroA = numeroEnteroA + 1; // acumular (sumar) al valor de numeroEnteroA, 1. (numero = numero + 1) 
            numeroEnteroA += 1; // acumular en numeroEnteroA, 1
            numeroEnteroA++; // acumular en numeroEnteroA, 1

            numeroEnteroA *= 2; // duplicar (multip. x 2) el valor de numeroA
            numeroEnteroA /= 2; // dividir por 2 el valor de numeroA
            
        }
        #endregion
    }
    public class Constantes
    {
        // Son valores que no pueden cambiar en ningún momento en la ejecución.
        // Puedo guardar en un espacio de memoria una constante, en este caso, para identificar 
        // cosas que no pueden cambiar, como el valor de Error 404, o un puerto donde conectarnos
        const int NUMERO_ENTERO = 2;
        const int PUERTO_HTTP = 80;
        const int ERROR_NOTFOUND = 404;

    }

}