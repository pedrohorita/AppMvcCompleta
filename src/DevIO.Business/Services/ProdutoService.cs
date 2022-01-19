using DevIo.Business.Models;
using DevIO.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produdo)
        {
            throw new NotImplementedException();
        }

        public async Task Atualizar(Produto produdo)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
