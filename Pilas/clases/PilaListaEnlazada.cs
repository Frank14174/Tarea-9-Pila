using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class PilaListaEnlazada
    {
        private Nodo listaEn;
        private int cima;

        public PilaListaEnlazada()
        {
            listaEn = null;
            cima = -1;
        }

        public void insertar(Object ele) {
            Nodo nuevo = new Nodo(ele);
            //if (listaEn == null)
            //{
            //    listaEn = nuevo;
            //}
            //else {
            //    nuevo.enlace = listaEn;
            //    listaEn = nuevo;
            //}
            //cima++;

            cima++;
            nuevo.enlace = listaEn;
            listaEn = nuevo;
        }
       
        public Object quitar()
        {
            Object aux;
            if (listaEn == null)
            {
                return null;
            }
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = listaEn.dato;
            listaEn = listaEn.enlace;
            cima--;
            return aux;
        }

        public Object cimaPila() {
            
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return listaEn.dato;
        }
  

        public bool pilaVacia()
        {
            return cima == -1;
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }

        //para PALINDROMO
        public object quitarChar() {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia no hay datos");
            }
            aux = (char)listaEn.dato;
            cima--;
            return aux;
        }

        public void visualizarinverso() {
            Nodo n;
            n = listaEn;

            while (n!=null) {
                Console.WriteLine(n.dato+"");
                n = n.enlace;
                cima--;
                Console.WriteLine(n+"");
            }

        }

    }
}
