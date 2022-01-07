using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class ChildPhoto
    {
        [Key]
        public int PhotosId { get; set;}
        public string Title {get; set;}
        
        public string FileName {get; set;}
        public string PhotoPath {get; set;}
        public bool IsMain {get; set;}
        public int Chld {get; set;}
        public Child Child {get; set;}
         public DateTime UploadDate {get; set;}=DateTime.Now;
    }
}