using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pilas.clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] listaPila;

        public PilaLineal() {
            cima = -1; //condicion de pila llena
            listaPila = new Object[TAMPILA];
        }

        public bool pilaLlena() {
            return cima == TAMPILA - 1;
        }

        //operacion que modifica la oila

        public void insertar(Object elemento) {
            if (pilaLlena()) {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incrementar cima y insertar el elemento
            cima++;
            listaPila[cima] = elemento;
        }

        public bool pilaVacia() {
            return cima == -1;
        }

        //retorna un tipo char, para el ejemplo de palindromo
        public object quitarChar() {
            char aux;
            if (pilaVacia()) {
                throw new Exception("Pila Vacia no hay datos");    
            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;
        }

        //extrae elementos de la pila (pop)
        public Object quitar() {
            int aux;
            if (pilaVacia()) {
                throw new Exception("lA PILA VACIA NO SE PUEDE SACAR ");
            }

            //guardar el elemento en la cima
            aux = (int)listaPila[cima];

            // decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }

        public void limpiarPila() {
            cima = -1;
        }

        // operacion de preoceso a la pila
        public Object cimaPila() {
            if (pilaVacia()) {
                throw new Exception("Pila Vacia");
            }
            return listaPila[cima];
        }
        public string espacios(string srt) {
            return Regex.Replace(srt, @"\s+", String.Empty);
        }

     
    }
}
