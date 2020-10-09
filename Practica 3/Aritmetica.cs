using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{

    public enum Operacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }

    class Aritmetica
    {

        //atributos
        #region Atributos
        private double _resultado;
        private double _memoria;
        private double _memoriaDos;
        private double _memoriaTres;
        private double _temp1;
        private double _temp2;
        public Operacion _ultimaOperacion;
        private double _temp3;


        #endregion

        //Propiedades
        #region Propiedades
        public double Resultado { get { return _resultado; } set { _resultado = value; } }
        public double Memoria { get { return _memoria; } set { _memoria = value; } }

        public double MemoriaDos { get { return _memoriaDos; } set { _memoriaDos = value; } }

        public double MemoriaTres { get { return _memoriaTres; } set { _memoriaTres = value; } }

        public double Temporal1 { get { return _temp1; } set { _temp1 = value; } }
        public double Temporal2 { get { return _temp2; } set { _temp2 = value; } }

        public Operacion UltimaOperacion { get { return _ultimaOperacion; } set { _ultimaOperacion = value; } }

        public double Temporal3 { get { return _temp3; } set { _temp3 = value; } }

        #endregion


        #region Metodos
        public double Sumar(double numero1, double numero2)
        {
            var Resultado = numero1 + numero2;

            return Resultado;
        }

        public double Resta(double numero1, double numero2)
        {
            var Resultado = numero1 - numero2;
            return Resultado;
        }

        public double Division(double numero1, double numero2)
        {
            var Resultado = numero1 / numero2;
            return Resultado;
        }
        public double Multiplicacion(double numero1, double numero2)
        {
            var Resultado = numero1 * numero2;
            return Resultado;
        }
        #endregion
    }
}
