namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopModel : DbContext
    {
        public ShopModel()
            : base("name=ShopModel")
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Fabricantes> Fabricantes { get; set; }
        public virtual DbSet<Familias> Familias { get; set; }
        public virtual DbSet<Filiais> Filiais { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Subclasses> Subclasses { get; set; }
        public virtual DbSet<Movimento> Movimento { get; set; }
        public virtual DbSet<Prod_Serv> Prod_Serv { get; set; }
        public virtual DbSet<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio> View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio { get; set; }
        public virtual DbSet<View_Movimento_Vendas_Varias_Filiais_Relatorio> View_Movimento_Vendas_Varias_Filiais_Relatorio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Fabricantes>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Fabricantes>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Familias>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Familias>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Razao_Social)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Fone)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Inscricao_Estadual)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Inscricao_Municipal)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Inscricao_Suframa)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Tipo_Data)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Tipo_Arredondamento)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Cor_Linhas_Relatorios)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Layout_Nota_Saida)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Layout_Nota_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Layout_Ticket_Saida)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Layout_Ticket_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Optante_Simples_Perc_Aproveitamento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Venda_Rapida)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Saidas)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Saidas_1)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Saidas_2)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Saidas_3)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Financeiro_Carencia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Financeiro_Juros)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Financeiro_Multa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Financeiro_Desconto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Imagem_Fundo_Menu)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Logotipo_Pequena)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Computador_Atualizacao_Automatica)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Senha_Web_Atualizacao_Automatica)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.UF_Atualizacao_Automatica)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Valida_U1)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nao_Importar_PV_Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_CRC)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Cod_IBGE_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Cod_IBGE_UF)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_UF)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_Token)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_IdToken)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_Valor_Sem_Identificacao)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_Caixa_Postal)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Contabilista_CEP_Caixa_Postal)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFe_Observacao1)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFe_Observacao2)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFe_Observacao3)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFe_Observacao4)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.SAT_Assinatura)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.SAT_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_Logotipo_Danfe)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_Valor_Condicao_Enviar_Endereco)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.NFCe_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.SAT_Versao_Layout)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Carol_Perc_Minimo_Antecipacao_Financeira)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.CNAE)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Carol_Perc_Minimo_Saldo_Credito_Otica_OS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Entradas)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .Property(e => e.Nome_Entradas_1)
                .IsUnicode(false);

            modelBuilder.Entity<Filiais>()
                .HasMany(e => e.Movimento)
                .WithRequired(e => e.Filiais)
                .HasForeignKey(e => e.Ordem_Filial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grupos>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Grupos>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Tipo_Operacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Interno_Gerado_Por)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Criado_Por)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Ultima_Gravacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Sem_Desconto_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Desconto_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Acrescimo_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Com_Desconto_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Final_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Comissao_Perc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Referencia_Interna)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Qtde_Total_Prod)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Qtde_Total_Serv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Qtde_Total_Geral)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Serv_Sem_Desconto_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Prod_Sem_Desconto_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Custo_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Frete_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Desconto_Total_Serv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Desconto_Total_Prod)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Desconto_Total_Geral)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Acrescimo_Total_Serv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Acrescimo_Total_Prod)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Acrescimo_Total_Geral)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Despesa_Acessoria)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.IPI_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.IPI_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Normal_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Normal_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Subst_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Subst_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Diferido_Valor_Operacao_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Diferido_Valor_Diferimento_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Retido_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Retido_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Desonerado_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Base_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Valor_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Base_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Valor_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Base_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Valor_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Base_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Valor_Prod_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Base_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Valor_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Base_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Valor_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Base_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Valor_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Base_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Valor_Serv_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Normal_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.PIS_Subst_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Normal_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.COFINS_Subst_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.CSOSN_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.CSOSN_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.II_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.II_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ISS_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ISS_Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.IR_Base)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.IR_Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Imp_Fiscal_Base_ICMS_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Imp_Fiscal_Base_ISS_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Imp_Fiscal_Valor_ICMS_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Imp_Fiscal_Valor_ISS_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Retencao_CSLL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Retencao_PIS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Retencao_COFINS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Observacao_Sistema)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Observacao_Fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Pedido_Fornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Local_Exportacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.UF_Exportacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Local_Despacho)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Serv)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Total_Prod)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Nome_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Documento_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Modelo_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Indicador_Presencial)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Peso_Final)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Cubagem_Final)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Informacoes_Fisco)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Carga_Tributaria)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.CFPS)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Arquivo_XML_Importado)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Indicador_Destino)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Endereco_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Situacao_Expedicao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Valida_R04)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Natureza_Operacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Preco_Custo_Medio_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Simples_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Simples_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Modo_Envio_Avulso)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Numero_Envio_Avulso)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Situacao_VEF)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Tipo_Recebimento_Frete)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Frete_Valor_Separado_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Frete_Descricao_Conta)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Diferido_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Diferido_Normal_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Versao_Gravacao)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Versao_Efetivacao_Estoque)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Versao_Efetivacao_Financeiro)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Peso_Liquido_Final)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Carga_Tributaria_Federal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Carga_Tributaria_Estadual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Carga_Tributaria_Municipal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.TEF_Comprovante_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.TEF_Comprovante_Estabelecimento)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Numero_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Bairro_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_Cidade_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_UF_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.NFCE_Cupom_CEP_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Desonerado_Valor_Subtrair_Total_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Partilhado_Base_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Partilhado_Valor_Destino_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_Partilhado_Valor_Remetente_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.ICMS_FCP_Valor_Somado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Momento_Efetiva_Estoque)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.Tipo_Arredondamento)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .Property(e => e.UF_Filial)
                .IsUnicode(false);

            modelBuilder.Entity<Movimento>()
                .HasMany(e => e.Movimento1)
                .WithOptional(e => e.Movimento2)
                .HasForeignKey(e => e.Ordem_Movimento_Referenciado);

            modelBuilder.Entity<Subclasses>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Subclasses>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            //modelBuilder.Entity<Subclasses>()
            //    .HasMany(e => e.Prod_Serv)
            //    .WithRequired(e => e.Subclasses)
            //    .HasForeignKey(e => e.Ordem_Subclasse)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio>()
                .Property(e => e.Prod_Serv_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio>()
                .Property(e => e.Estoque_Qtde_Estoque)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio>()
                .Property(e => e.Unidades_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio>()
                .Property(e => e.CLi_For_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Movimento_Prod_Serv_Qtde)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Movimento_Prod_Serv_Preco)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Filiais_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Movimento_Tipo_Operacao)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Qtde_Estoque_Atual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Codigo_Cor)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Nome_Cor)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Tamanho_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Nome_Tamanho)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Adicional1)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Adicional2)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Adicional3)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Adicional4)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Adicional5)
                .IsUnicode(false);

            modelBuilder.Entity<View_Movimento_Vendas_Varias_Filiais_Relatorio>()
                .Property(e => e.Prod_Serv_Codigo_Barras)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
    .Property(e => e.Codigo)
    .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Ordenacao)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Desconto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Desconto_Maximo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Nome_Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Comissao_Sobrepoe_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Comissao_Perc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Comissao_Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Peso_Liq)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Peso_Bruto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Fracionar_Qtde)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Cubagem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Valida_Produto)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Adicional1)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Adicional2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Adicional3)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Adicional4)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Adicional5)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Barras)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Saida)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Extra1)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Extra2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Extra3)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Ex_Tipi)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Web_Obs1)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Web_Obs2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Ind_Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Ind_Imprimir_Na_Nota)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Ind_Imprimir_No_Ticket)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Detalhado1)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Detalhado2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Detalhado3)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Detalhado4)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Texto_Detalhado5)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Cod_Classifica_Serv)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Carga_Tributaria_Perc_Nacional)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Carga_Tributaria_Perc_Importado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Carga_Tributaria_Fonte)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.FCI)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.FCI_Perc_Importado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.FCI_Valor_Venda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.FCI_Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_ANP)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Validacao)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Valida_P2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Site_Prod)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Valor_Somar_Frete)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Codigo_Tributacao_ISS)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Valida_P2V2)
                .IsUnicode(false);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Altura)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Largura)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prod_Serv>()
                .Property(e => e.Comprimento)
                .HasPrecision(19, 4);
        }
    }
}
