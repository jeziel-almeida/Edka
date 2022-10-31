using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05
{
    class Program
    {
        public static List<Disciplina> matrizCurricular = new List<Disciplina>
        {
            new Disciplina {Nome="Neurociência e aprendizagem", Inicio=new DateTime(2022,08,08), Termino=new DateTime(2022,09,12)},
            new Disciplina {Nome="Habilidades socio emocionais", Inicio=new DateTime(2022,08,10), Termino=new DateTime(2022,08,24)},
            new Disciplina {Nome="Felicidade", Inicio=new DateTime(2022,08,31), Termino=new DateTime(2022,09,14)},
            new Disciplina {Nome="Teoria do Desenv. Humano e da Aprendizagem", Inicio=new DateTime(2022,09,19), Termino=new DateTime(2022,10,24)},
            new Disciplina {Nome="Planejamento Pedagógico", Inicio=new DateTime(2022,08,27), Termino=new DateTime(2022,10,23)},
            new Disciplina {Nome="Educação Inclusiva e Cidadania", Inicio=new DateTime(2022,09,21), Termino=new DateTime(2022,11,09)},
            new Disciplina {Nome="Gestão da Sala de Aula", Inicio=new DateTime(2022,11,16), Termino=new DateTime(2022,12,30)},
            new Disciplina {Nome="Met. Dinâmicas e Inovativas", Inicio=new DateTime(2022,10,31), Termino=new DateTime(2022,11,14)},
            new Disciplina {Nome="Projeto Integrador", Inicio=new DateTime(2022,11,21), Termino=new DateTime(2022,12,05)},
            new Disciplina {Nome="Avaliação por Competências", Inicio=new DateTime(2023,01,01), Termino=new DateTime(2023,01,02)},
            new Disciplina {Nome="Aprendizagem por Competências", Inicio=new DateTime(2023,01,02), Termino=new DateTime(2023,01,02)},
            new Disciplina {Nome="Prática Docente à Distância", Inicio=new DateTime(2023,01,03), Termino=new DateTime(2023,01,04)},
            new Disciplina {Nome="Legislação e Dir. da Ed. Profissional e Tecnológica", Inicio=new DateTime(2023,01,04), Termino=new DateTime(2023,01,05)},
            new Disciplina {Nome="Ambientes de Aprendizagem Inovativos", Inicio=new DateTime(2023,01,05), Termino=new DateTime(2023,01,06)},
        };
        static void Main(string[] args)
        {
            var ordemCrescente = from d in matrizCurricular 
                                 orderby d.Inicio ascending
                                 select d;

            var ordemDescrescente = from d in matrizCurricular
                                 orderby d.Inicio descending
                                 select d;
            
            Console.WriteLine("1 - Ordem crescente. 2 - Ordem decrescente");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    foreach (var item in ordemCrescente)
                    {
                        Console.WriteLine(item);
                    }

                    Console.ReadKey();
                    break;
                case 2:
                    foreach (var item in ordemDescrescente)
                    {
                        Console.WriteLine(item);
                    }

                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;
            }
            
        }
    }
}
