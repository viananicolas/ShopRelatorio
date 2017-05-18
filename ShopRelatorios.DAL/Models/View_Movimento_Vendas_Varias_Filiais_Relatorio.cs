namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Movimento_Vendas_Varias_Filiais_Relatorio
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Movimento_Prod_Serv_Ordem { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prod_Serv_Ordem { get; set; }

        [StringLength(20)]
        public string Prod_Serv_Codigo { get; set; }

        [StringLength(102)]
        public string Prod_Serv_Nome { get; set; }

        [Column(TypeName = "money")]
        public decimal? Movimento_Prod_Serv_Qtde { get; set; }

        [Column(TypeName = "money")]
        public decimal? Movimento_Prod_Serv_Preco { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Filiais_Ordem { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Filiais_Codigo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Filiais_Nome { get; set; }

        public DateTime? Movimento_Data { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string Prod_Serv_Tipo { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ordem { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string Movimento_Tipo_Operacao { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qtde_Estoque_Atual { get; set; }

        public int? Ordem_Cor { get; set; }

        [StringLength(3)]
        public string Codigo_Cor { get; set; }

        [StringLength(25)]
        public string Nome_Cor { get; set; }

        public int? Ordem_Tamanho { get; set; }

        [StringLength(3)]
        public string Tamanho_Codigo { get; set; }

        [StringLength(25)]
        public string Nome_Tamanho { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Preco_Fracionado_Casas_Decimais { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Qtde_Fracionada_Casas_Decimais { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Adicional1 { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Adicional2 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Adicional3 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Adicional4 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Adicional5 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(25)]
        public string Prod_Serv_Codigo_Barras { get; set; }
    }
}
