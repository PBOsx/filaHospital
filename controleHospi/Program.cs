using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleHospi
{
    class Program
    {
        static void Main(string[] args)
        {

              String opcao;
              String recor, view, exit;
              String novoCadastro, cadastrados;

       

                  Console.WriteLine("press 1 for new registration or");
              Console.WriteLine("press 2 for view records");
              Console.WriteLine("press q for Exit");
              opcao = Console.ReadLine();

              switch (opcao)
              {
                  case "1":
                      recor =("");
                      break;

                  case "2":
                      view = ("");
                      break;

                  case "q":
                      break;


            }

            Console.ReadKey();
        }
        
    }
}
