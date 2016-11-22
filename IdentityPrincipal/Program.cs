using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespce par crir identidde
using System.Security.Principal;
using System.Security.Claims;

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

            var nome = new Claim(ClaimTypes.Name, "Jean Lopes");
            var telefone = new Claim("Telefone", "11961249186");
            var role = new Claim(ClaimTypes.Role, "Admin");

            var listClaim = new[] {nome, telefone, role};

            var identidade = new ClaimsIdentity(listClaim, "LgroupAuthentication");

            //3 - Juntar tudo e colocar no ambiente (Principal)
            var principal = new ClaimsPrincipal(identidade);

            //4 - Precisamos colocar no contexto o usuario autenticado
            Thread.CurrentPrincipal = principal;

            // PRONTO ESTAMOS AUTENTICADOS
            Console.WriteLine("Estou Autenticado ?? => " + Thread.CurrentPrincipal.Identity.IsAuthenticated);
            Console.WriteLine("Sou Admin do Sistema ?? => " + Thread.CurrentPrincipal.IsInRole("Admin"));
            Console.WriteLine("Qual é a minha Autenticação ?? => " + Thread.CurrentPrincipal.Identity.AuthenticationType);
            Console.WriteLine("Qual é o meu nome de usuario ?? => " + Thread.CurrentPrincipal.Identity.Name);
            Console.WriteLine("Qual seu telefone ?? => " + ((ClaimsPrincipal)Thread.CurrentPrincipal).Claims.First(x => x.Type.Equals("Telefone")).Value);

            Console.ReadKey();



        }
    }
}
