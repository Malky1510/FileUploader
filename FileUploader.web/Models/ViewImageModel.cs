using FileUploader.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FileUploader.web.Models
{
    public class ViewImageModel
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Password { get; set; }

        public bool CorrectPassword { get; set; }
    }
}
