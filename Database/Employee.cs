using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
    }
}