namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Movimento_Estoque_Varias_Filiais_Normal_Relatorio
    {
        public int? Ordem { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Prod_Serv_Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Prod_Serv_Nome { get; set; }

        [Column(TypeName = "money")]
        public decimal? Estoque_Qtde_Estoque { get; set; }

        public DateTime? Estoque_Data_Alteracao { get; set; }

        public int? Classes_Codigo { get; set; }

        public int? Sub_Codigo { get; set; }

        public int? Grupos_Codigo { get; set; }

        public int? Fabricantes_Codigo { get; set; }

        public int? Familias_Codigo { get; set; }

        [StringLength(5)]
        public string Unidades_Nome { get; set; }

        public long? Cli_For_Codigo { get; set; }

        [StringLength(60)]
        public string CLi_For_Nome { get; set; }

        public int? Pesquisa1_Codigo { get; set; }

        public int? Pesquisa2_Codigo { get; set; }

        public int? Pesquisa3_Codigo { get; set; }

        public int? Filiais_Codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Prod_Serv_Inativo { get; set; }
    }
}
