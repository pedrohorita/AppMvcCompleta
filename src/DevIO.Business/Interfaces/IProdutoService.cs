using DevIo.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produdo);
        Task Atualizar(Produto produdo);
        Task Remover(Guid id);

    }
}
