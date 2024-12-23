using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAL.Entities
{
    public class Dignosis
    {
        [Key]
        public int ID { get; set; }
        public string Disease { get; set; }

    }
}
