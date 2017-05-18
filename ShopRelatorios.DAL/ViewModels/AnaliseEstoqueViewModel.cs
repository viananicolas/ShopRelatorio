using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRelatorios.DAL.ViewModels
{
    public class AnaliseEstoqueViewModel
    {
        public string Produto { get; set; }
        public decimal VendasF1 { get; set; }
        public decimal VendasF2 { get; set; }
        public decimal VendasF3 { get; set; }
        public decimal VendasF4 { get; set; }
        public decimal TotalVendas { get; set; }
        public decimal MediaVendas { get; set; }
        public decimal EstoqueF1 { get; set; }
        public decimal EstoqueF2 { get; set; }
        public decimal EstoqueF3 { get; set; }
        public decimal EstoqueF4 { get; set; }
        public decimal TotalEstoque { get; set; }
        public decimal SG1 { get; set; }
        public decimal SG3 { get; set; }

    }
}
