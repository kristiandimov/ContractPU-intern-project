//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContractPU
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cours()
        {
            this.Contracts = new HashSet<Contract>();
        }
    
        public int id { get; set; }
        public string protocol { get; set; }
        public System.DateTime courseDate { get; set; }
        public string theme { get; set; }
        public string anotation { get; set; }
        public double totalHour { get; set; }
        public double totalCredit { get; set; }
        public Nullable<int> areaId { get; set; }
        public Nullable<int> educatorId { get; set; }
    
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual Educator Educator { get; set; }
    }
}