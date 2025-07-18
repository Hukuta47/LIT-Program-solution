//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InkTrack.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cartridge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cartridge()
        {
            this.Printer = new HashSet<Printer>();
            this.CartridgeModel = new HashSet<CartridgeModel>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public int StatusId { get; set; }
        public int TypeId { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRefills { get; set; }
        public Nullable<System.DateTime> LastDateOfRefill { get; set; }
    
        public virtual CartridgeStatus CartridgeStatus { get; set; }
        public virtual CartridgeType CartridgeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Printer> Printer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartridgeModel> CartridgeModel { get; set; }
    }
}
