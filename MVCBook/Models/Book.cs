using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;//BASE DE DATOS


namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="VarChar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VarChar")]      
        [MaxLength(50, ErrorMessage = "La longitud del nombre del autor no puede exceder los 50 caracteres")]
        public string Author { get; set; }


        [Range(100, 10000,ErrorMessage ="El número de páginas está garantizado entre 100 y 10.000 páginas.")] 
        public int PagesNumber { get; set; }


        [Required]
        [StringLength (50)]
        public string Publisher { get; set; }



        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage = "Ingrese un formato de fecha válido, Por ejemplo: 2017-06-16")]
        public string PublicationDate { get; set; }

       
        public string Content { get; set; }

        [Column(TypeName ="Money")]
        public decimal Price { get; set; }


        [Column(TypeName = "Money")]
        [Compare("Price", ErrorMessage = "Los precios ingresados dos veces deben ser los mismos")]
        [NotMapped]
        public decimal PriceConfirm { get; set; }
    }
}