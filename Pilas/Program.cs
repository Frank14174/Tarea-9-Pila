using Pilas.clases;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Pilas
{
    class Program
    {
        static void ejemploPilaLineal() {

            PilaLineal pila;
            int x;
            int clave = -1;

            Console.WriteLine("Ingrese numeros y para terminar -1");

            try {
                pila = new PilaLineal();
                
                do { 
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x!=-1) {
                        pila.insertar(x);
                    }
                } while (x!=clave);

                Console.WriteLine("Estos son los elementos de la Pila");

                //para desapilar

                while (!pila.pilaVacia()) {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                   
                }
            }
            catch (Exception error) {
                Console.WriteLine("Error= " + error.Message);
            }
        }

        //TAREA
        static void ejercicioListEnlazada() {
            PilaListaEnlazada enla;
            int x;
            int clave= -1;
            Console.WriteLine("Ingrese numeros y para terminar -1");

            try {
                enla = new PilaListaEnlazada();
                do {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x!=-1) {
                        enla.insertar(x);
                    }
                } while (x!=clave);

                Console.WriteLine("ELEMENTOS DE LA PILA...");

                while (!enla.pilaVacia()) {

                    x = (int)(enla.quitar());
                    Console.WriteLine("ELEMENTOS POP..."+ x);
                }

            }
            catch (Exception error) {
                Console.WriteLine($"Error{error.Message}");
            }

        }
        
        //Tarea  
        static void ejercicioPalindromoEnla() {
            PilaListaEnlazada pilaChar;
            bool esPalindromo;
           
            String pal;
            string espacio = "";

            try {
                pilaChar = new PilaListaEnlazada();
                Console.WriteLine("Teclee una palabra para saber si es PALINDROMO");
                pal = Console.ReadLine();
                
                int len = pal.Length;
                
                for (int i = 0; i <= len - 1; i++)
                {
                    if (pal[i] != ' ')
                    {

                        espacio = espacio.ToLower() + pal.ToLower()[i];
                        espacio = Regex.Replace(espacio.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
                    }
                }

                for (int i = 0; i <= espacio.Length;) {
                    Char c;
                    c = espacio[i++];
                   
                    pilaChar.insertar(c);
                }

                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = espacio[j++] == c; 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {espacio} es PALINDROMO");
                }
                else
                {
                    Console.WriteLine($"Nel, no es PALINDROMO");
                }
            }
            catch (Exception error) {
                Console.WriteLine("Error"+error.Message);
            
            }
        
        }
        //TAREA De EXPRESIONES
        public static void ejercicioExpresiones() {
            PilaLineal pilaExp;
            String cadena;
            Boolean eval;

            try
            {
                pilaExp = new PilaLineal();
                Console.WriteLine("Ingresa su expresion");
                cadena = Console.ReadLine();

                for (int i = 0; i < cadena.Length;)
                {
                    Char c;
                    c = cadena[i];
                    eval = true;

                    if (cadena[i] == '(' || cadena[i] == '[' || cadena[i] == '{')
                    {
                        pilaExp.insertar(cadena[i]);
                    }
                    else 
                    {
                        if (cadena[i] == ')')
                        {
                            c = (Char)pilaExp.quitarChar();

                            if (c != '(')
                            {
                               eval= false;
                            }
                        }
                        else
                        {
                            if (cadena[i] == ']')
                            {
                                c = (Char)pilaExp.quitarChar();
                                if (c != '[')
                                {
                                    eval= false;
                                }
                            }
                            else
                            {
                                if (cadena[i] == '}')
                                {
                                    c = (Char)pilaExp.quitarChar();
                                    if (c != '{')
                                    {
                                        eval= false;
                                    }
                                }

                            }
                        }

                    }
                }
                eval = true;
                for (int j=0; eval && !pilaExp.pilaVacia();) {
                    Char c;
                    c = (Char)pilaExp.quitarChar(); ;
                    eval =cadena[j++] == c;
                }
                pilaExp.limpiarPila();
                if (eval)
                {
                    Console.WriteLine("Espresion correcta :)" + cadena);
                }
                else {
                    Console.WriteLine("Expresion Incorrecta :(");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error = " + error);
            }
        }

        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            
            String pal;
            string espacio="";
           
            try
            {
                
                pilaChar = new PilaLineal();
                Console.WriteLine("\tTeclee una palabra para ver si es PALINDROMO ");
                pal = Console.ReadLine();
                pal.ToLower();

                int len = pal.Length;
                for (int i=0; i<=len-1; i++) {
                    if (pal[i] !=' ') {

                        espacio = espacio.ToLower() + pal.ToLower()[i];
                        espacio = Regex.Replace(espacio.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
                    }
                }
                       
                
                //creamos la pila con los chars
                for (int i = 0; i < espacio.Length;)
                {
                    Char c;
                    c = espacio[i++];
                    pilaChar.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = espacio[j++] == c; //evalua si la pos es igual 
                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {espacio} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es PALINDROMO");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }

        static void EjemploPilaLista()
        {
            PilaList pl = new PilaList();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            int pau;
            pau = 0;
            
        }

        static void Main(string[] args)
        {
            //ejemploPilaLineal();
            //EjemploPilaLista();
            
            //TAREA 
            //palindromo();
            ejercicioListEnlazada();
            //ejercicioExpresiones();
            
        }
    }
}
