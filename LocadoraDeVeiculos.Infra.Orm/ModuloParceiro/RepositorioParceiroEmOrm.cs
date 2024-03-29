﻿using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloParceiro
{
    public class RepositorioParceiroEmOrm : RepositorioBaseEmOrm<Parceiro>, IRepositorioParceiro
    {
        public RepositorioParceiroEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }
        public List<Parceiro> SelecionarTodos(bool incluirCupons = false)
        {
            if (incluirCupons)
                return registros
                        .Include(p => p.Cupons)
                .ToList();

            return registros.ToList();
        }
        public Parceiro SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}