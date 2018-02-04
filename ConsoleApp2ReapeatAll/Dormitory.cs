using System.Collections.ObjectModel;

namespace ConsoleApp2ReapeatAll
{
    public class Dormitory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Collection<Student> AllStudent { get; set; }
    }
}