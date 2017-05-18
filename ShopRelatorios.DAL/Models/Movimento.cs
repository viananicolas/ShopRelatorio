namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movimento")]
    public partial class Movimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movimento()
        {
            Movimento1 = new HashSet<Movimento>();
        }

        [Key]
        public int Ordem { get; set; }

        public int Ordem_Filial { get; set; }

        [Required]
        [StringLength(3)]
        public string Tipo_Operacao { get; set; }

        public int Ordem_Operacao { get; set; }

        public int Ordem_Operador { get; set; }

        public int Ordem_Caixa { get; set; }

        public int Ordem_Cli_For { get; set; }

        public int Ordem_Tabela_Preco { get; set; }

        public int Ordem_Vendedor1 { get; set; }

        public int Ordem_Vendedor2 { get; set; }

        public int Ordem_Comissionado { get; set; }

        public int Ordem_Rec_Pag { get; set; }

        public int Ordem_Financeiro { get; set; }

        public int Ordem_Funcionario_Checkout { get; set; }

        public int? Ordem_Movimento_Referenciado { get; set; }

        public int Finalidade { get; set; }

        public int Sequencia { get; set; }

        public bool Apagado { get; set; }

        public DateTime? Data { get; set; }

        public bool Interno { get; set; }

        [Required]
        [StringLength(50)]
        public string Interno_Gerado_Por { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? Servico_Concluido { get; set; }

        public DateTime? Data_Efetivado_Estoque { get; set; }

        public bool Efetivado_Financeiro { get; set; }

        public DateTime? Data_Efetivado_Financeiro { get; set; }

        public DateTime? Data_Criacao { get; set; }

        [Required]
        [StringLength(20)]
        public string Criado_Por { get; set; }

        public int Qtde_Gravacoes { get; set; }

        public DateTime? Data_Alteracao { get; set; }

        [Required]
        [StringLength(50)]
        public string Ultima_Gravacao { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Sem_Desconto_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Acrescimo_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Com_Desconto_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Final_Somado { get; set; }

        public bool Desconto_Total { get; set; }

        public bool Comissao_Fixa { get; set; }

        [Column(TypeName = "money")]
        public decimal Comissao_Perc { get; set; }

        [Required]
        [StringLength(10)]
        public string Referencia_Interna { get; set; }

        public long Numero_Nota_Fiscal { get; set; }

        public long Numero_Cupom_Fiscal { get; set; }

        [Column(TypeName = "money")]
        public decimal Qtde_Total_Prod { get; set; }

        [Column(TypeName = "money")]
        public decimal Qtde_Total_Serv { get; set; }

        [Column(TypeName = "money")]
        public decimal Qtde_Total_Geral { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Serv_Sem_Desconto_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Prod_Sem_Desconto_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Custo_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Frete_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto_Total_Serv { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto_Total_Prod { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto_Total_Geral { get; set; }

        [Column(TypeName = "money")]
        public decimal Acrescimo_Total_Serv { get; set; }

        [Column(TypeName = "money")]
        public decimal Acrescimo_Total_Prod { get; set; }

        [Column(TypeName = "money")]
        public decimal Acrescimo_Total_Geral { get; set; }

        [Column(TypeName = "money")]
        public decimal Despesa_Acessoria { get; set; }

        [Column(TypeName = "money")]
        public decimal IPI_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal IPI_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Normal_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Normal_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Subst_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Subst_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Diferido_Valor_Operacao_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Diferido_Valor_Diferimento_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Retido_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Retido_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Desonerado_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Base_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Valor_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Base_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Valor_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Base_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Valor_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Base_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Valor_Prod_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Base_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Valor_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Base_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Valor_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Base_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Valor_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Base_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Valor_Serv_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Normal_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal PIS_Subst_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Normal_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal COFINS_Subst_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal CSOSN_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal CSOSN_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal II_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal II_Valor_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ISS_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal ISS_Valor { get; set; }

        [Column(TypeName = "money")]
        public decimal IR_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal IR_Valor { get; set; }

        [Column(TypeName = "money")]
        public decimal Imp_Fiscal_Base_ICMS_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Imp_Fiscal_Base_ISS_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Imp_Fiscal_Valor_ICMS_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Imp_Fiscal_Valor_ISS_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal Retencao_CSLL { get; set; }

        [Column(TypeName = "money")]
        public decimal Retencao_PIS { get; set; }

        [Column(TypeName = "money")]
        public decimal Retencao_COFINS { get; set; }

        [Required]
        public string Observacao { get; set; }

        [Required]
        public string Observacao_Sistema { get; set; }

        [Required]
        public string Observacao_Fiscal { get; set; }

        public bool Observacao_Fiscal_Alterado { get; set; }

        public DateTime? Data_Acerto_Emprestimo { get; set; }

        public int Ordem_Funcionario_Alteracao { get; set; }

        [Required]
        [StringLength(32)]
        public string Validacao { get; set; }

        public DateTime? Data_Desefetivado_Estoque { get; set; }

        public bool Desefetivado_Financeiro { get; set; }

        public DateTime? Data_Desefetivado_Financeiro { get; set; }

        [StringLength(50)]
        public string Pedido_Fornecedor { get; set; }

        public DateTime? Data_Previsao_Recebimento { get; set; }

        [Required]
        [StringLength(60)]
        public string Local_Exportacao { get; set; }

        [Required]
        [StringLength(2)]
        public string UF_Exportacao { get; set; }

        [Required]
        [StringLength(60)]
        public string Local_Despacho { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Serv { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Total_Prod { get; set; }

        [Required]
        [StringLength(60)]
        public string NFCE_Cupom_Nome_Cliente { get; set; }

        public int NFCE_Cupom_Tipo_Documento { get; set; }

        [Required]
        [StringLength(20)]
        public string NFCE_Cupom_Documento_Cliente { get; set; }

        [Required]
        [StringLength(1)]
        public string Modelo_Nota { get; set; }

        [Required]
        [StringLength(1)]
        public string Indicador_Presencial { get; set; }

        [Column(TypeName = "money")]
        public decimal Peso_Final { get; set; }

        [Column(TypeName = "money")]
        public decimal Cubagem_Final { get; set; }

        [Required]
        [StringLength(2000)]
        public string Informacoes_Fisco { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria { get; set; }

        [Required]
        [StringLength(4)]
        public string CFPS { get; set; }

        public int CRT { get; set; }

        [Required]
        [StringLength(250)]
        public string Arquivo_XML_Importado { get; set; }

        [Required]
        [StringLength(1)]
        public string Indicador_Destino { get; set; }

        [Required]
        [StringLength(60)]
        public string NFCE_Cupom_Endereco_Cliente { get; set; }

        public bool Alteracoes_Offline { get; set; }

        [Required]
        [StringLength(1)]
        public string Situacao_Expedicao { get; set; }

        public bool Movimenta_Estoque { get; set; }

        [Required]
        [StringLength(32)]
        public string Valida_R04 { get; set; }

        public bool Invalido { get; set; }

        public int Codigo_Acerto { get; set; }

        [Required]
        [StringLength(50)]
        public string Natureza_Operacao { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco_Custo_Medio_Somado { get; set; }

        public bool NF_Manual_Fiscal { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Simples_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Simples_Valor_Somado { get; set; }

        [Required]
        [StringLength(30)]
        public string Modo_Envio_Avulso { get; set; }

        public DateTime? Data_Envio_Avulso { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Envio_Avulso { get; set; }

        public bool Operacao_Consumidor_Final { get; set; }

        [Required]
        [StringLength(1)]
        public string Situacao_VEF { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Recebimento_Frete { get; set; }

        [Column(TypeName = "money")]
        public decimal Frete_Valor_Separado_Somado { get; set; }

        [Required]
        [StringLength(80)]
        public string Frete_Descricao_Conta { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? Efetivado_Estoque { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? Desefetivado_Estoque { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Diferido_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Diferido_Normal_Valor_Somado { get; set; }

        public int Ordem_Credito_Cli_For { get; set; }

        [Required]
        [StringLength(10)]
        public string Versao_Gravacao { get; set; }

        [Required]
        [StringLength(10)]
        public string Versao_Efetivacao_Estoque { get; set; }

        [Required]
        [StringLength(10)]
        public string Versao_Efetivacao_Financeiro { get; set; }

        [Column(TypeName = "money")]
        public decimal Peso_Liquido_Final { get; set; }

        public int Ordem_Financeiro_Frete { get; set; }

        public DateTime? Data_Passou_Efetivacao_Estoque { get; set; }

        public DateTime? Data_Passou_Desefetivacao_Estoque { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria_Federal { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria_Estadual { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria_Municipal { get; set; }

        [StringLength(8000)]
        public string TEF_Comprovante_Cliente { get; set; }

        [StringLength(8000)]
        public string TEF_Comprovante_Estabelecimento { get; set; }

        public int? Ordem_Funcionario_Desefetivacao { get; set; }

        public int? Ordem_Funcionario_Efetivacao_Financeiro { get; set; }

        public int? Ordem_Funcionario_Efetivacao_Estoque { get; set; }

        [StringLength(60)]
        public string NFCE_Cupom_Numero_Cliente { get; set; }

        [StringLength(60)]
        public string NFCE_Cupom_Bairro_Cliente { get; set; }

        [StringLength(60)]
        public string NFCE_Cupom_Cidade_Cliente { get; set; }

        [StringLength(2)]
        public string NFCE_Cupom_UF_Cliente { get; set; }

        [StringLength(9)]
        public string NFCE_Cupom_CEP_Cliente { get; set; }

        [Column(TypeName = "money")]
        public decimal ICMS_Desonerado_Valor_Subtrair_Total_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal? ICMS_Partilhado_Base_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal? ICMS_Partilhado_Valor_Destino_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal? ICMS_Partilhado_Valor_Remetente_Somado { get; set; }

        [Column(TypeName = "money")]
        public decimal? ICMS_FCP_Valor_Somado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Imprimiu_Ticket { get; set; }

        public int? Ordem_Funcionario_Liberacao { get; set; }

        [StringLength(1)]
        public string Momento_Efetiva_Estoque { get; set; }

        public int? Ordem_Tabela_Custo { get; set; }

        public int? Ordem_Tabela_Custo_Medio { get; set; }

        public bool? Operacao_Grava_Custo { get; set; }

        [StringLength(1)]
        public string Tipo_Arredondamento { get; set; }

        public bool? Operacao_Permite_Gerar_Credito_Cliente { get; set; }

        public bool? FCI_Efetivou_Qtde { get; set; }

        public bool? FCI_Desefetivou_Qtde { get; set; }

        public DateTime? Data_Entrega { get; set; }

        public bool? Usar_UF_Filial_Calculo_Imposto { get; set; }

        [StringLength(2)]
        public string UF_Filial { get; set; }

        public int? Ordem_Motivo_Desefetivacao { get; set; }

        public int? Ordem_Plano_Contas3 { get; set; }

        public virtual Filiais Filiais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimento> Movimento1 { get; set; }

        public virtual Movimento Movimento2 { get; set; }
    }
}
