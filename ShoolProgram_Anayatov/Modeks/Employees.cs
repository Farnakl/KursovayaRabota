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
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Operation = new HashSet<Operation>();
        }
    
        public int id { get; set; }
        public int idJobTitle { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string ResidentialAddress { get; set; }
        public string RegistrationAddress { get; set; }
        public string Telephone { get; set; }
        public string TIN { get; set; }
        public string Passport { get; set; }
        public int idFamilyStatus { get; set; }
        public int idEducation { get; set; }
        public string Speciality { get; set; }
    
        public virtual Education Education { get; set; }
        public virtual FamilyStatus FamilyStatus { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operation { get; set; }
    }
}
