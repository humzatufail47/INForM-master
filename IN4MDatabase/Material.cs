
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace IN4MDatabase
{

using System;
    using System.Collections.Generic;
    
public partial class Material
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Material()
    {

        this.BillOfQuantities = new HashSet<BillOfQuantity>();

        this.Components = new HashSet<Component>();

    }


    public System.Guid MaterialsID { get; set; }

    public string MaterialsDescription { get; set; }

    public Nullable<decimal> UnitRate { get; set; }

    public string Dimension { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BillOfQuantity> BillOfQuantities { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Component> Components { get; set; }

}

}
