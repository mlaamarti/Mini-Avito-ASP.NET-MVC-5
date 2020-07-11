using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mini_Avito_ASP.NET_MVC_5.Models
{
    public class Job
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nom du l'emploi")]
        public string jobTitle { get; set; }
        [Required]
        [Display(Name = "Description de l'emploi")]
        public string jobContent { get; set; }
        [Display(Name = "Photo de emploi")]
        public string jobImage { get; set; }

        [Display(Name = "Type de l'emploi")]
        public int categoryId { get; set; }

        public Category category { get; set; }
    }
}