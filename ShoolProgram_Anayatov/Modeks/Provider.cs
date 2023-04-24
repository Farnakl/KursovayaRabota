//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoolProgram_Anayatov.Modeks
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provider()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string CheckingAccount { get; set; }
        public string TIN { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> idStatusProvider { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        public virtual StatusProvider StatusProvider { get; set; }
    }
}