using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Child
    {
        [Key]
        public int Chld { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string ChildCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(80)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(80)")]
        public string SurName { get; set; }

        public string KnownAs { get; set; }


        [Column(TypeName = "Nvarchar(10)")]
        public string Sex { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {SurName}";
        public string PhotoPath { get; set; }
        public string StudyPath { get; set; }
        [Required]
        [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 

        public DateTime DateOfBirth { get; set; }


        [Required] 
        public DateTime FoundRelinguished { get; set; }

        [DataType(DataType.Date)]
        [Required] public DateTime Intake { get; set; }
        public string PlaceOfBirth { get; set; }
        public string LegalRep { get; set; }

        // [Required] 
        [Column(TypeName = "Nvarchar(80)")]
        public string Region { get; set; }
       public ICollection<ChildPhoto> ChildPhotos {get; set;}

    //   public ICollection<ChildStudyReport> ChildStudyReports {get; set;}
    //   public ICollection<ReviewChild> ReviewChildren {get; set;}
    //   public ICollection<Matching> MatchingChild {get; set;}
       
        //  public int GetAge()
        //  {
        //     return DateOfBirth.CalculategeAge();
        //  }
    }
}