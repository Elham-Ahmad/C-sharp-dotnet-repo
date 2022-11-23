using System.ComponentModel.DataAnnotations;

namespace DapperCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Designation{ get; set; }
        public int Department { get; set; }

    }
}
