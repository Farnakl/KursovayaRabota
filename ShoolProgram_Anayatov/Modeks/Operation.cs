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
    
    public partial class Operation
    {
        public int id { get; set; }
        public int idProduct { get; set; }
        public string Quantity { get; set; }
        public Nullable<System.DateTime> DateOfsale { get; set; }
        public int idEmployees { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Product Product { get; set; }
    }
}