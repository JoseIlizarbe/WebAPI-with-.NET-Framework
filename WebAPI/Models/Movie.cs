namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string mov_name { get; set; }

        [Required]
        [StringLength(300)]
        public string mov_description { get; set; }

        public bool mov_status { get; set; }

        [StringLength(150)]
        public string user_creation { get; set; }

        [StringLength(150)]
        public string user_modified { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_creation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_modified { get; set; }
    }
}
