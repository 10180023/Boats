//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatsProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoices
    {
        public int InvoiceId { get; set; }
        public int ContractId { get; set; }
        public bool Settled { get; set; }
        public decimal Sum { get; set; }
        public decimal SumInclVAT { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Contracts Contracts { get; set; }
    }
}
