namespace MvcForumTranslator.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaleResourceKey")]
    public partial class LocaleResourceKey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocaleResourceKey()
        {
            LocaleStringResources = new HashSet<LocaleStringResource>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Notes { get; set; }

        public DateTime DateAdded { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocaleStringResource> LocaleStringResources { get; set; }
    }
}
