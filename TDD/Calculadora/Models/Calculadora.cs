using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;


        public Calculadora(string data){
            this.data = data;
            listaHistorico = new List<string>();
        }

        public int Somar(int val1, int val2){
            int resultado = val1 + val2;
            listaHistorico.Insert(0, $"Res: {val1}+{val2} = {resultado}" + data);
            return resultado;

        }
        public int Subtrair(int val1, int val2){
            int resultado = val1 - val2;
            listaHistorico.Insert(0, $"Res: {val1}-{val2} = {resultado}" + data);
            return resultado;

        }
        public int Multiplicar(int val1, int val2){
            int resultado = val1 * val2;
            listaHistorico.Insert(0, $"Res: {val1}*{val2} = {resultado}" + data);
            return resultado;

        }
        public int Dividir(int val1, int val2){
            int resultado = val1 / val2;
            listaHistorico.Insert(0, $"Res: {val1}/{val2} = {resultado}" + data);
            return resultado;

        }

        public List<string> Historico(){
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}