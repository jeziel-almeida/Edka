using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05
{
    class Disciplina
    {
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        public override string ToString()
        {
            return $"{Nome,-50} - {Inicio:dd/MM/yyyy} - {Termino:dd/MM/yyyy}";
        }
    }
}
