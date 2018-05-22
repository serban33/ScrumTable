namespace ScrumTable.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Story")]
    public partial class Story
    {
        public int Id { get; set; }

        [Required]
        [StringLength(21)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }
        
        public virtual ICollection<Drafts> Drafts { get; set; }
    }
}
