using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace Lab2.Models
{

    public class Arbol<T> where T : IComparable<T>
    {
        public T valor;
        public Arbol<T> izquierdo;
        public Arbol<T> derecho;

        public void Insertar(Arbol<T> raiz, T dtInfo)
        {

            Arbol<T> ntemp = new Arbol<T>();
            //ntemp = null;
            ntemp.valor = dtInfo;
            ntemp.derecho = null;
            ntemp.izquierdo = null;

            if (raiz == null)
            {
                raiz = ntemp;
            }
            else
            {
                Arbol<T> nAux = raiz;
                Arbol<T> nPafre = raiz;
                bool bDerecha = false;
                while (nAux != null)
                {

                    nPafre = nAux;
                    if (dtInfo.CompareTo(nAux.valor) == 1)
                    {
                        nAux = nAux.derecho;
                        bDerecha = true;
                    }
                    else
                    {
                        nAux = nAux.izquierdo;
                        bDerecha = false;
                    }
                }
                if (bDerecha == true)
                {
                    nPafre.derecho = ntemp;
                }
                else
                {
                    nPafre.izquierdo = ntemp;
                }

            }
        }


        public Arbol<T> minvalue(Arbol<T> raiz)
        {
            Arbol<T> temp = new Arbol<T>();

            while (temp.izquierdo != null)
            {
                temp = temp.izquierdo;
            }

            return temp;
        }




        //izquierdo > es 1
        //derecho > es -1
        //iguales 0

        public Arbol<T> Eliminar(Arbol<T> raiz, T temp)
        {
            Arbol<T> info = new Arbol<T>();

            info.valor = temp;

            if (raiz == null)
            {
                return raiz;
            }

            if (info.valor.CompareTo(raiz.valor) == -1)
            {
                return Eliminar(raiz.izquierdo, info.valor);
            }

            if (info.valor.CompareTo(raiz.valor) == 1)
            {
                return Eliminar(raiz.derecho, info.valor);
            }

            if (info.valor.CompareTo(raiz.valor) == 0)
            {
                if (raiz.izquierdo == null && raiz.derecho == null)
                {
                    raiz = null;
                }
                else if (raiz.izquierdo == null)
                {
                    Arbol<T> tep = raiz;
                    raiz = raiz.derecho;
                    raiz.derecho = null;
                    temp = default(T);
                }

                else if (raiz.derecho == null)
                {
                    Arbol<T> tep = raiz;
                    raiz = raiz.izquierdo;
                    raiz.izquierdo = null;
                    temp = default(T);
                }

                else
                {
                    Arbol<T> min = minvalue(raiz.derecho);
                    raiz.valor = min.valor;
                    return Eliminar(raiz.derecho, min.valor);
                }


            }

            return raiz;

        } 
    }

    

    


    public class Pais : IComparable<Pais>
    {

        public string nombre { get; set; }
        public string Grupo { get; set; }


        public int CompareTo(Pais other)
        {
            return this.nombre.CompareTo(other.nombre);
        }


        
    }

    


}