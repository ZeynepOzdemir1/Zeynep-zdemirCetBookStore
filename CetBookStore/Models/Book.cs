using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength = 3, ErrorMessage = "Bu alan 3 ile 512 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable




        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bu alan 3 ile 100 karakter arasında olmalıdır")]
        [Display(Name = "Yazarı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Authors { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bu alan 5 ile 300 karakter arasında olmalıdır")]
        [Display(Name = "Tanımı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Description { get; set; }
        [Display(Name = "Fiyatı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Decimal Price { get; set; }
        [Display(Name = "Basım Yılı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int PressYear { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Stok Sayısı")]
        public int StockCount { get; set; }


        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        [Display(Name = "Kategori Adı")]

        public Category Category { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Yorum Listesi")]
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
            //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
