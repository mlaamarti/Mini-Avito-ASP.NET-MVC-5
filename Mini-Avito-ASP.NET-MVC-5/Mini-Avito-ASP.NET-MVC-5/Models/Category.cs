using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mini_Avito_ASP.NET_MVC_5.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Type de l'emploi")]
        public string categoryName { get; set; }
        [Required]
        [Display(Name = "Description du type")]
        public string categoryDescription { get; set; }

        //  One To Many banding  catagory has collection of jobs
        public virtual  ICollection<Job> jobs { get; set; }
    }
}