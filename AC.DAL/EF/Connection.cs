//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AC.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Connection : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Connection()
        {
            this.Overwriters = new HashSet<Connection>();
        }
    
        public int Id { get; set; }
        public int NodeAId { get; set; }
        public int NodeBId { get; set; }
        public int A2BConnectionTypeId { get; set; }
        public int B2AConnectionTypeId { get; set; }
        public Nullable<int> OverwritesId { get; set; }
        public Nullable<int> GraphId { get; set; }
        public decimal WeightA2B { get; set; }
        public decimal WeightB2A { get; set; }
    
        public virtual ConnectionType A2BConnectionType { get; set; }
        public virtual ConnectionType B2AConnectionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Connection> Overwriters { get; set; }
        public virtual Connection Overwrite { get; set; }
        public virtual Graph Graph { get; set; }
        public virtual Node NodeA { get; set; }
        public virtual Node NodeB { get; set; }
    }
}
