using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityPrincipal
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Todo os sistema funciona com os seguintes passos:

            //1 - Preciso criar uma identidade

            //2 - Para este fim preciso criar algumas declarações
                    //Como nome, Telefone, papeis etc.
                    //=> no mínimo devemos adicionar um nome

            //3 - Juntar tudo e colocar no ambiente (Principal)

            Console.ReadKey();
        }
    }
}
