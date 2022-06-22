using SGCliente.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCliente.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            #region Cliente
            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Tays",
                    CPF = "898.560.550-08"
                },

                new Cliente
                {
                    Nome = "Xeana",
                    CPF = "749.084.200-09"
                }
            };

            context.AddRange(clientes);
            #endregion

            #region Contato
            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Email = "tays@latapack.com.br",
                    Telefone = "(65) 3590-0395",
                    Cliente = clientes[0]
                },

                new Contato
                {
                    Nome = "Contato 2",
                    Email = "xeana@latapack.com.br",
                    Telefone = "(19) 99411-3035",
                    Cliente = clientes[1]
                }
            };
            
            context.AddRange(contatos);
            context.SaveChanges();
            #endregion
        }
    }
}
