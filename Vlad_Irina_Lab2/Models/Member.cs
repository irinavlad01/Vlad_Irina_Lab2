using System.ComponentModel.DataAnnotations;

namespace Vlad_Irina_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-sA-Z\s-]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana-Maria.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Prenumele trebuie sa aiba minim 3 litere.")]
        public string? FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-sA-Z\s-]*$", ErrorMessage = "Numele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau Ana-Maria.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Numele trebuie sa aiba minim 3 litere.")]
        public string? LastName { get; set;}
        public string? Email { get; set; }
        [StringLength(70)]
        public string? Address { get; set; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Numarul de telefon trebuie sa contina cifre")]
        [StringLength(10)]
        public string? Phone { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }


    }
}
