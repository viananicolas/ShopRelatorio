namespace ShopRelatorios.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subclasses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Subclasses()
        //{
        //    Prod_Serv = new HashSet<Prod_Serv>();
        //}

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

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Prod_Serv> Prod_Serv { get; set; }
    }
}
