using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Form_Api.Model
{
    public class Signupform
    {
        [Key]
        public int id { get; set; }

        public string? name { get; set; }

        public string? Email { get; set; }

        public string? password { get; set; }

        public string? subject { get; set; }

        [NotMapped]
        public string? cpassword { get; set; }
    }
}
