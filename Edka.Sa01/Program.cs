using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa01
{
    class Program
    {
        public static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa {Descricao="Internet",Valor=89, Vencimento= new DateTime(2022, 11, 11)},
            new Despesa {Descricao="Roupas",Valor=400, Vencimento= new DateTime(2022, 11, 11)},
            new Despesa {Descricao="Comida",Valor=760, Vencimento= new DateTime(2022, 11, 11)}
        };
        static void Main(string[] args)
        {
            var despesasAbaixoCem = from d in despesas 
                                    where d.Valor < 100 
                                    orderby d.Vencimento
                                    select d;

            foreach(var item in despesasAbaixoCem)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        
    }
}
