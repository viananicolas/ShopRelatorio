using ShopRelatorios.DAL.Models;

namespace ShopRelatorios.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prod_Serv
    {
        [Key]
        public int Ordem { get; set; }

        public int Ordem_Classe { get; set; }

        public int Ordem_Subclasse { get; set; }

        public int Ordem_Grupo { get; set; }

        public int Ordem_Familia { get; set; }

        public int Ordem_Pesquisa_1 { get; set; }

        public int Ordem_Pesquisa_2 { get; set; }

        public int Ordem_Pesquisa_3 { get; set; }

        public int Ordem_Moeda { get; set; }

        public int Ordem_Unidade_Venda { get; set; }

        public int Ordem_Mensagem_Nota { get; set; }

        public int Ordem_Fabricante { get; set; }

        public int Ordem_Fornecedor1 { get; set; }

        public int Ordem_Fornecedor2 { get; set; }

        public int Ordem_Fornecedor3 { get; set; }

        public int Ordem_Fornecedor4 { get; set; }

        public int Ordem_Fornecedor5 { get; set; }

        public int Ordem_NCM { get; set; }

        public int Ordem_NBS { get; set; }

        public int Ordem_Classe_Imposto_Saida { get; set; }

        public int Ordem_Classe_Imposto_Entrada { get; set; }

        public int Ordem_Produto_Fracionado { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo_Ordenacao { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public bool Controla_Estoque { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto { get; set; }

        public bool Promocao { get; set; }

        public bool Limita_Desconto { get; set; }

        [Column(TypeName = "money")]
        public decimal Desconto_Maximo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Nota { get; set; }

        [Required]
        public string Observacao { get; set; }

        public bool Bloqueado_Venda { get; set; }

        public bool Bloqueado_Movimento { get; set; }

        public bool Comissao_Sobrepoe { get; set; }

        [Required]
        [StringLength(1)]
        public string Comissao_Sobrepoe_Tipo { get; set; }

        [Column(TypeName = "money")]
        public decimal Comissao_Perc { get; set; }

        [Column(TypeName = "money")]
        public decimal Comissao_Valor { get; set; }

        public bool Nao_Incluir_Tabela { get; set; }

        [Column(TypeName = "money")]
        public decimal Peso_Liq { get; set; }

        [Column(TypeName = "money")]
        public decimal Peso_Bruto { get; set; }

        public bool Permite_Complemento { get; set; }

        public int Qtde_Fracionada_Casas_Decimais { get; set; }

        public int Preco_Fracionado_Casas_Decimais { get; set; }

        public bool Fracionar_Permitido { get; set; }

        [Column(TypeName = "money")]
        public decimal Fracionar_Qtde { get; set; }

        public bool Permite_Fracionar_Sem_Estoque { get; set; }

        public bool Nao_Imprimir_Etiqueta { get; set; }

        public int Tipo_Item { get; set; }

        public bool Medicamento { get; set; }

        public int Tipo_Medicamento { get; set; }

        public int Tipo_BC_ICMS_ST_Medicamento { get; set; }

        [Column(TypeName = "money")]
        public decimal Cubagem { get; set; }

        [Required]
        [StringLength(32)]
        public string Valida_Produto { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Adicional1 { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Adicional2 { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Adicional3 { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Adicional4 { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Adicional5 { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Barras { get; set; }

        public bool Preco_Faixa_Qtde { get; set; }

        public int Origem_Mercadoria { get; set; }

        [Required]
        [StringLength(80)]
        public string Texto_Saida { get; set; }

        [Required]
        [StringLength(30)]
        public string Extra1 { get; set; }

        [Required]
        [StringLength(30)]
        public string Extra2 { get; set; }

        [Required]
        [StringLength(30)]
        public string Extra3 { get; set; }

        public bool Uso_Interno { get; set; }

        [Required]
        [StringLength(3)]
        public string Ex_Tipi { get; set; }

        public bool Web_Promocao { get; set; }

        public bool Web_Nao_Exportar { get; set; }

        [Required]
        [StringLength(1000)]
        public string Web_Obs1 { get; set; }

        [Required]
        [StringLength(1000)]
        public string Web_Obs2 { get; set; }

        public bool Ind_Produto_Composto { get; set; }

        public bool Ind_Materia_Prima { get; set; }

        public bool Ind_Produto_Acabado { get; set; }

        [Required]
        [StringLength(1)]
        public string Ind_Tipo { get; set; }

        [Required]
        [StringLength(1)]
        public string Ind_Imprimir_Na_Nota { get; set; }

        [Required]
        [StringLength(1)]
        public string Ind_Imprimir_No_Ticket { get; set; }

        [Required]
        [StringLength(50)]
        public string Texto_Detalhado1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Texto_Detalhado2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Texto_Detalhado3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Texto_Detalhado4 { get; set; }

        [Required]
        [StringLength(50)]
        public string Texto_Detalhado5 { get; set; }

        [Required]
        [StringLength(5)]
        public string Cod_Classifica_Serv { get; set; }

        public DateTime Data_Cadastro { get; set; }

        public DateTime Data_Alteracao { get; set; }

        public bool Inativo { get; set; }

        public int Ordem_Funcionario_Alteracao { get; set; }

        public int Ordem_Funcionario_Cadastro { get; set; }

        public bool Vendido_Por_Peso { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria_Perc_Nacional { get; set; }

        [Column(TypeName = "money")]
        public decimal Carga_Tributaria_Perc_Importado { get; set; }

        public bool Carga_Tributaria_Zero_Nao_Mostrar { get; set; }

        [Required]
        [StringLength(20)]
        public string Carga_Tributaria_Fonte { get; set; }

        [Required]
        [StringLength(36)]
        public string FCI { get; set; }

        [Column(TypeName = "money")]
        public decimal FCI_Perc_Importado { get; set; }

        [Column(TypeName = "money")]
        public decimal FCI_Valor_Venda { get; set; }

        [Column(TypeName = "money")]
        public decimal FCI_Valor { get; set; }

        public bool FCI_Gerar_Calcular { get; set; }

        public bool Produto_ANP { get; set; }

        [Required]
        [StringLength(9)]
        public string Codigo_ANP { get; set; }

        [Required]
        [StringLength(32)]
        public string Validacao { get; set; }

        public bool Gerar_FCI_Externo { get; set; }

        [Required]
        [StringLength(32)]
        public string Valida_P2 { get; set; }

        public bool Invalido { get; set; }

        [Required]
        [StringLength(150)]
        public string Site_Prod { get; set; }

        public bool Importar_Observacoes { get; set; }

        public bool Colocar_Vitrine_Loja { get; set; }

        public bool Nao_Permitir_Correios { get; set; }

        public bool Frete_Gratis { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor_Somar_Frete { get; set; }

        [StringLength(20)]
        public string Codigo_Tributacao_ISS { get; set; }

        public int? Ordem_Enquadramento_IPI { get; set; }

        public bool Ind_Producao_Terceiro { get; set; }

        public int? Ordem_CEST { get; set; }

        public int? Dias_Validade { get; set; }

        public int? Tipo_Produto_Balanca_Toledo { get; set; }

        [StringLength(32)]
        public string Valida_P2V2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Altura { get; set; }

        [Column(TypeName = "money")]
        public decimal? Largura { get; set; }

        [Column(TypeName = "money")]
        public decimal? Comprimento { get; set; }

        //public virtual Classes Classes { get; set; }

        //public virtual Fabricantes Fabricantes { get; set; }

        //public virtual Familias Familias { get; set; }

        //public virtual Grupos Grupos { get; set; }

        //public virtual Subclasses Subclasses { get; set; }
    }
}
