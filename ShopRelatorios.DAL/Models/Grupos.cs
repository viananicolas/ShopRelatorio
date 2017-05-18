namespace ShopRelatorios.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grupos
    {
        [Key]
        public int Ordem { get; set; }

        public int Codigo { get; set; }

        [Required]
        [StringLength(25)]
        public string Nome { get; set; }

        public bool Nao_Envia_Web { get; set; }

        public bool Inativo { get; set; }

        public DateTime Data_Alteracao { get; set; }

        public int Ordem_Funcionario_Alteracao { get; set; }

        [Required]
        [StringLength(32)]
        public string Validacao { get; set; }
    }
}
