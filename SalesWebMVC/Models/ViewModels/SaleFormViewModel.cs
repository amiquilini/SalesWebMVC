using SalesWebMVC.Models.Enums;
using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class SaleFormViewModel
    {
        public SalesRecord Sale { get; set; }
        public ICollection<SaleStatus> Status { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}
