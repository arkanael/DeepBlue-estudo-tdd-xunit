using DeepBlue.Infra.Data.Contracts.Repository;
using DeepBlue.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

namespace DeepBlue.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private ConcurrentDictionary<Guid, Produto> context;

        public ProdutoRepository(ConcurrentDictionary<Guid, Produto> context)
        {
            this.context = context;
        }

        public void Create(Produto produto)
        {
            context[produto.Id] = produto;
        }

        public void Update(Produto produto)
        {
            context[produto.Id] = produto;
        }

        public Produto Remove(Guid id)
        {
            var produto = new Produto();
            context.Remove(id, out produto);

            return produto;
        }

        public List<Produto> SelectAll()
        {
            return context.Values
                .OrderBy(p =>p.Nome)
                .ToList();
        }

        public Produto SelectById(Guid id)
        {
            return context.Values
                .SingleOrDefault(p => p.Id.Equals(id));
        }
    }
}
