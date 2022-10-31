using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa01
{
    class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString()
        {
            return $"{Descricao,-10} -------- {Valor,-5} - {Vencimento:dd/MM/yyyy}";
        }
    }
}
