namespace MvcForumTranslator.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaleStringResource")]
    public partial class LocaleStringResource
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string ResourceValue { get; set; }

        public Guid LocaleResourceKey_Id { get; set; }

        public Guid Language_Id { get; set; }

        public virtual Language Language { get; set; }

        public virtual LocaleResourceKey LocaleResourceKey { get; set; }
    }
}
