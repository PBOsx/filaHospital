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
            String i;
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
                    Console.WriteLine("Qual nome do paciente?");
                    break;

                  case "2":
                      view = ("");
                    Console.WriteLine("Esses são os registros atuais");
                    break;

                  case "q":
                    exit = (""); 
                      break;


            }

            Console.ReadKey();
        }
        
    }
}
