using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendToGiggin.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string desc { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public Boolean soldOut { get; set; }
    }
}
