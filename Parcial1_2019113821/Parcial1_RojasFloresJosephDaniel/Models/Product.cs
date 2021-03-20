using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_RojasFloresJosephDaniel.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Ingrese entre 3 a 30")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode =true)]
        public Nullable<float> Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime Date { get; set; }
    }
}