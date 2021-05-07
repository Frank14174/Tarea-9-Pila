using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class Nodo
    {
        public Object dato;
        public Nodo enlace;

        public Nodo(Object x) {
            dato = x;
            enlace = null;
        }

        public Nodo(Object x, Nodo n) {
            dato = x;
            enlace = n;
        }
        public Object getDato(){
            return dato;
        }

        public Nodo getEnlace() {
            return enlace;
        }

        public void setEnlace(Nodo enlace){
            this.enlace = enlace;
        }

    }
}
