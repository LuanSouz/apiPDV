using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPDV.model
{
    public class Change
    {

        [Key]
        public int Id { get; set; }
        public double value { get; set; }

        public string Note { get; set; }
    }
}
