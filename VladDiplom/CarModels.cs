//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VladDiplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarModels()
        {
            this.ClientCars = new HashSet<ClientCars>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public int TechInfo { get; set; }
        public int Year { get; set; }
        public int Country { get; set; }
        public int Rul { get; set; }
    
        public virtual Countries Countries { get; set; }
        public virtual Marks Marks { get; set; }
        public virtual RulPlace RulPlace { get; set; }
        public virtual TechInformation TechInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientCars> ClientCars { get; set; }
    }
}
