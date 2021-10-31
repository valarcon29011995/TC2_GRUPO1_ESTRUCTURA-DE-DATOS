using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC2
{
    internal class ListaEnlazadaSimple
    {
        public Nodo cabeza;
        public void RecorerrLista()
        {
            Console.WriteLine("Lista de Pedidos");
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine(actual.ID + " " + actual.pedido + " " + actual.direccion);
                actual = actual.siguiente;
            }
            Console.WriteLine("*****************************************************");
        }
        public void AgregarAlInicio(int ID,  string pedido, string direccion)
        {
            Console.WriteLine("Agregando al inicio el elemento: "+ pedido);
            Nodo nuevo = new Nodo();
            nuevo.ID = ID;
            nuevo.pedido = pedido ;
            nuevo.direccion = direccion ;
            nuevo.siguiente = cabeza;
            cabeza = nuevo;
            Console.WriteLine("");
        }
        public void AgregarAlFinal (int ID, string pedido, string direccion)
        {
            Console.WriteLine("Agregando al final el elemento: " + pedido);
            if (cabeza==null)
            {
                cabeza = new Nodo();
                cabeza.ID = ID;
                cabeza.pedido = pedido ;
                cabeza.direccion = direccion ;
                cabeza.siguiente = null;
            }
            else
            {
                Nodo actual = cabeza;
                Nodo nuevo = new Nodo(); 
                nuevo.ID = ID;
                nuevo.pedido = pedido;
                nuevo.direccion = direccion ;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
            Console.WriteLine("");
        }
        public void EliminarInicio()
        {
            Console.WriteLine("Eliminando elemento del inicio:");
            Console.WriteLine(cabeza.pedido);
            Nodo temporal = new Nodo();
            temporal = cabeza;
            cabeza = cabeza.siguiente;
            temporal = null;
        }
        public void EliminarFinal()
        {
            Console.WriteLine("Eliminando elemento del final");
            Nodo temporal, puntero = new Nodo();
            puntero = cabeza;
            while (puntero.siguiente.siguiente != null)
            {
                puntero = puntero.siguiente;
            }
            temporal = puntero.siguiente;
            Console.WriteLine(puntero.siguiente.pedido);
            puntero.siguiente = null;
            temporal = null;
        }
        public void AgregarLuegoDe (string referencia, int ID, string pedido, string direccion)
        {
            Console.WriteLine("Agregando el elemento luego de " + referencia);
            Nodo nuevo = new Nodo();
            nuevo.ID = ID;
            nuevo.pedido = pedido;
            nuevo.direccion = direccion;
            Nodo actual = cabeza;
            while (actual.pedido != referencia)
            {
                actual = actual.siguiente;
            }
            nuevo.siguiente = actual.siguiente;
            actual.siguiente = nuevo;
            Console.WriteLine("");
        }
        public void EliminarLuegoDe(string referencia)
        {
            Nodo temporal, puntero =new Nodo();
            puntero = cabeza;
            Nodo actual = cabeza;
            while (puntero.pedido != referencia)
            {
                puntero=puntero.siguiente;
            }
            temporal = puntero.siguiente;
            puntero.siguiente = puntero.siguiente.siguiente;
            Console.WriteLine("Eliminando pedido luego de: " + referencia);
            temporal = null;
        }

    }
}
