using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab2_b1.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        public Book()
        {

        }
        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.Title = title;
            this.Author = author;
            this.ImageCover = image_cover;
        }
        [Display(Name = "Mã sách")]
        [Required(ErrorMessage = "Id không được để trống")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //private string title;

        [StringLength(250,ErrorMessage ="Tiêu đề không được vượt quá 250 ký tự")]
        [Display(Name ="Tiêu đề")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        //private string author;
        [Display(Name = "Tác giả")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        //private string image_cover;
        [Display(Name = "Đường dẫn ảnh bìa  ")]
        public string ImageCover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }
    }

}