using AutoMapper;
using DeepBlue.Infra.Data.Entities;
using DeepBlue.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepBlue.Presentation.Mappings
{
    public class ProdutoMap : Profile
    {
        public ProdutoMap()
        {
            CreateMap<ProdutoCadastroModel, Produto>()
                .AfterMap((src, dest) => dest.Id = Guid.NewGuid());

            CreateMap<ProdutoEdicaoModel, Produto>();

            CreateMap<Produto, ProdutoConsultaModel>();
        }
    }
}
