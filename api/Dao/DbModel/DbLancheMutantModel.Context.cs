﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dao.DbModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<USP_TB_INGREDIENTE_Result> USP_TB_INGREDIENTE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_INGREDIENTE_Result>("USP_TB_INGREDIENTE");
        }
    
        public virtual ObjectResult<USP_TB_LANCHE_Result> USP_TB_LANCHE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_LANCHE_Result>("USP_TB_LANCHE");
        }
    
        public virtual ObjectResult<USP_TB_LANCHE_INGREDIENTE_Result> USP_TB_LANCHE_INGREDIENTE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_LANCHE_INGREDIENTE_Result>("USP_TB_LANCHE_INGREDIENTE");
        }
    
        public virtual ObjectResult<USP_TB_DOMINIO_Result> USP_TB_DOMINIO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_DOMINIO_Result>("USP_TB_DOMINIO");
        }
    
        public virtual ObjectResult<USP_CARREGAR_VENDAS_LANCHE_Result> USP_CARREGAR_VENDAS_LANCHE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CARREGAR_VENDAS_LANCHE_Result>("USP_CARREGAR_VENDAS_LANCHE");
        }
    
        public virtual ObjectResult<USP_TB_VENDAS_Result> USP_TB_VENDAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_VENDAS_Result>("USP_TB_VENDAS");
        }
    
        public virtual ObjectResult<USP_TB_VENDAS_LANCHES_Result> USP_TB_VENDAS_LANCHES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_TB_VENDAS_LANCHES_Result>("USP_TB_VENDAS_LANCHES");
        }
    
        public virtual int USP_DELETA_VENDAS_LANCHES(Nullable<int> codigo)
        {
            var codigoParameter = codigo.HasValue ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DELETA_VENDAS_LANCHES", codigoParameter);
        }
    
        public virtual int USP_INSERIR_VENDAS_LANCHE(string cod_lanche, string descricao_venda)
        {
            var cod_lancheParameter = cod_lanche != null ?
                new ObjectParameter("cod_lanche", cod_lanche) :
                new ObjectParameter("cod_lanche", typeof(string));
    
            var descricao_vendaParameter = descricao_venda != null ?
                new ObjectParameter("descricao_venda", descricao_venda) :
                new ObjectParameter("descricao_venda", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_INSERIR_VENDAS_LANCHE", cod_lancheParameter, descricao_vendaParameter);
        }
    }
}
