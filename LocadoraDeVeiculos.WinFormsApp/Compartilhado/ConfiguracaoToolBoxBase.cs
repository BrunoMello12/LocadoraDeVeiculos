﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.Compartilhado
{
    public abstract class ConfiguracaoToolBoxBase
    {
        #region tooltips dos botões

        public abstract string TipoCadastro { get; }

        public abstract string TooltipInserir { get; }

        public abstract string TooltipEditar { get; }

        public abstract string TooltipExcluir { get; }

        public abstract string TooltipPrecos { get; }

        public abstract string TooltipFiltrar { get; }

        #endregion

        #region estados dos botões
        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool PrecoHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return true; } }

        #endregion
    }
}
