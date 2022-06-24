using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Model
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public int year { get; set; }
        public int rating { get; set; }
        public string genre { get; set; }
        public string leadactor { get; set; }
        public string title { get; set; }
       
    }
}
