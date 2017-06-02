using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue=false)]
        [Display(Name = "ID")]
        public int BookId { get; set; }

        [Display(Name="Название")]
        [Required(ErrorMessage="Пожалуйста, введите название музыки")]
        public string Name { get; set; }

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Пожалуйста, укажите имя автора")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Изображение")]
        [Required(ErrorMessage = "Пожалуйста, введите описание музыки")]
        public string Description { get; set; }

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Пожалуйста, укажите жанр произведения")]
        public string Genre { get; set; }

        [Display(Name = "Цена (руб)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение цены")]
        public decimal Price { get; set; }
        /*  [Display(Name = "Описание")]
          public string picture { get; set; }

          [Display(Name = "Год")]
          public int year { get; set; }*/

        [Display(Name = "адрес")]
          public string url { get; set; }

           [Display(Name = "Год")]
            [Required(ErrorMessage = "Пожалуйста, укажите год произведения")]
            public string year { get; set; }

           [Display(Name = "Описание")]
            [Required(ErrorMessage = "Пожалуйста, укажите жанр произведения")]
            public string picture { get; set; }

        public string dimensions { get; set; }
        public string weight { get; set; }
        public string barcode { get; set; }
        public string media { get; set; }

        /*  [Display(Name = "Жанр")]
          [Required(ErrorMessage = "Пожалуйста, укажите жанр произведения")]
          public string url { get; set; }
          */

    }
}
