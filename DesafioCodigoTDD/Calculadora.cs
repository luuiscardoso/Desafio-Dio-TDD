using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCodigoTDD
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }
        public int soma(int n1, int n2)
        {
            var result = n1 + n2;
            _historico.Add($"{n1} + {n2} = {result}");
            return result;
        }

        public int subtrair(int n1, int n2)
        {
            var result = n1 - n2;
            _historico.Add($"{n1} - {n2} = {result}");
            return result;
        }

        public int dividir(int n1, int n2)
        {
            var result = n1 / n2;
            _historico.Add($"{n1} / {n2} = {result}");
            return result;
        }

        public int multiplicar(int n1, int n2)
        {
            var result = n1 * n2;
            _historico.Add($"{n1} * {n2} = {result}");
            return result;
        }

        public List<string> historico()
        {
            List<string> lista = _historico.TakeLast(3).ToList();
            return lista;
        }
    }
}
