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
    
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int CustomerId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Addr { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string PassportNumber { get; set; }
        public int PassportTypeId { get; set; }
    
        public virtual Companies Companies { get; set; }
        public virtual PassportTypes PassportTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
