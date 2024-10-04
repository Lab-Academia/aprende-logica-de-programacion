using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logica
{
    public class CondicionalIf
    {
        

        private void Condicionales()
        {
            bool condicion = true;

            //Composicion de un condicional if:
            // palabra reservada "if": comienzo de estructura condicional                             // V = Verdadero
            // condicion: una expresion que pueda brindar valor verdadero o falso al evaluarse        // F = Falso

            // ej. "Esta lloviendo?"  SI/NO - V/F
            // "Hay 5 pelotas en esta caja?" SI/NO - V/F
            // "Tienes mas de 18 años?" SI/NO - V/F

            // Se usa en el lenguaje comun. Podemos identificarlo en estructuras del estilo 

            // "Si //////, entonces ...."

            int miNumero = 5;
            
            if(miNumero == 5)
            {
                System.Console.WriteLine("El valor de miNumero es 5");
            }

            // Condicion trivial. verdadero es verdadero?
            // simplificacion de if(true == true)
            if (true)
            {
                System.Console.WriteLine("Siempre se ejecuta esta linea");
            }

            if(condicion) // evaluar el valor de "condicion" (var. booleana)
            {
                // ejecutar cuando condicion == true
            }
            else
            {
                // ejecutar cuando NO (condicion == true)
            }
        }
        private void EjemploIfElse()
        {
            int numero = Random.Range(0, 4);

            if (numero == 1) // evaluar el valor de "condicion" (var. booleana) ====> cuanto vale "numero"?                                   -> en la linea 43
            {
                #region Leccion 1...
                // para que se ejecute esta linea en el caso de ejemplo, "numero" debe valer (tener guardado/asignado) 1.
                // condicion == true ???
                // Si numero es igual a 1 ... entonces: decir Hola Mundo.
                #endregion
                System.Console.WriteLine("Hola Mundo."); // si valió 1, entonces la comparación en la línea 45 fue verdadera. 
                // numero es igual a 1?
                // 1 es igual a 1?
                // Verdadero.
                
                #region Ver mas...
                // todavia tengo dudas... cuanto vale numero ??? -----> numero, mientras estemos en este bloque de codigo, 
                // podremos estar seguro-as de que vale 1. en la condicion de abajo, creamos el codigo que abordara que hacer en 
                // caso de que numero sea Diferente a 1.
                #endregion
            }
            else if (numero == 2)
            {
                #region Aprende más sobre else if...
            #endregion @ labacademia.net
            }
            // else if()
            // {
            // }
            // ...
            else // numero == 0 o numero == 3
            {
                System.Console.WriteLine("Hola Mundo."); // si NO valió 1, NI valió 2, es un caso que no evaluamos, pero podemos medir fácilmente.

                // los casos en donde numero no haya validado la condición de if, ni tampoco la de else if 
                // .... numero, comparado a ver si era 1 en la línea 45. FALSO
                // .... comparado nuevamente en la línea 63, pero estamos aquí, así que tampoco fue 2.
                // else toma todos los casos en donde las condiciones evaluadas hayan sido FALSAS. 
            }
        }
        private void EjemploCondicionalIf()
        {
            int numeroA = 5;
            int numeroB = 6;

            if(numeroA < numeroB) // 5 es menor que 6?
            {
                // ---> En caso positivo (con estos valores, es cierto)
                // ejecutar las siguientes instrucciones:
                System.Console.WriteLine("El valor de numeroA es MENOR que numeroB");
            }
            else
            {
                // ---> En caso negativo (imagina que los valores de numeroA=20, numeroB=10)
                // ejecutar las siguientes instrucciones:
                System.Console.WriteLine("El valor de numeroA es MAYOR o IGUAL que numeroB");
            }

        }

        // ... Area de Recreacion L:D


        // Sobreescritura del metodo ToString (propio de Object, la clase de la cual derivan todos los tipos en C#)
        // // ... ver mas: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/override
        public override string ToString()
        {
            return "Leccion de Condicional If";
        }
    }
}