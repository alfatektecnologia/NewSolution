using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSolution
{
   public class Calculadora
    {
        private List<string> listaHistorico;
        private int res;
        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int val1, int val2)
        {
            res = val1 + val2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;
        
        }
        public int subtrair(int val1, int val2)
        {
            res = val1 - val2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;

        }
        public int multiplicar(int val1, int val2)
        {
            res = val1 * val2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;

        }
        public int dividir(int val1, int val2)
        {
            res = val1 / val2;
            listaHistorico.Insert(0, "Res: " + res);
            return res;

        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            
            return listaHistorico;

        }


    }
}
