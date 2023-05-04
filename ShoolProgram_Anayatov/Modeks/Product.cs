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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Operation = new HashSet<Operation>();
        }
    
        public int id { get; set; }
        public int idProvider { get; set; }
        public int idTypeOfProduct { get; set; }
        public string NameProduct { get; set; }
        public string PurchaseVolume { get; set; }
        public string Unit { get; set; }
        public string PurchasePrice { get; set; }
        public Nullable<int> idStatusProduct { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operation { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual TypeOfProduct TypeOfProduct { get; set; }
        public virtual StatusProduct StatusProduct { get; set; }
    }
}
