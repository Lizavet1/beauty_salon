namespace beauty_salon.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientService")]
    public partial class ClientService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientService()
        {
            DocumentByServices = new HashSet<DocumentByService>();
            ProductSales = new HashSet<ProductSale>();
        }

        public int ID { get; set; }

        public int ClientID { get; set; }

        public int ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        public string Comment { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentByService> DocumentByServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
