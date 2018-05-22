namespace ScrumTable.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drafts
    {
        public int Id { get; set; }

        [ForeignKey("Story")]
        public int StoryId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public int Status { get; set; }

        public virtual Story Story { get; set; }
    }
}
