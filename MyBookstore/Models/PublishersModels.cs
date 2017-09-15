using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class PublishersModels
    {
        [Key]
        public string name { get; set; }
    }
}