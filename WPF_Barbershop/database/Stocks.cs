//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Barbershop.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stocks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stocks()
        {
            this.Service_records = new HashSet<Service_records>();
        }
    
        public int ID_Stock { get; set; }
        public string Title { get; set; }
        public Nullable<double> Discount_size { get; set; }
        public System.DateTime Start_date_ { get; set; }
        public System.DateTime End_date_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_records> Service_records { get; set; }
    }
}
