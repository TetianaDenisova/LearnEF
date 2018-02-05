using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2ReapeatAll
{
    public class Toy
    {
        [Key]
        [ForeignKey("Student")]
        public int Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
    }
}
