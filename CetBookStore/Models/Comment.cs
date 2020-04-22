using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Display(Name = "Yorum Başlığı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bu alan 3 ile 500 karakter arasında olmalıdır")]

        public string Title { get; set; }
        [Display(Name = "Yorum Detayı")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bu alan 3 ile 500 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Detail { get; set; }
        [Display(Name = "Değerlendirme")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int? Rating { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]

        public int BookId { get; set; }

        [Display(Name = "Yorum Yapılan Kitap")]

        public Book Book { get; set; }


        public Comment()
        {
            CreatedDate = DateTime.Now;
        }





    }






}
