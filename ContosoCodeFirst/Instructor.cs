using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoCodeFirst
{
    public class Instructor
    {
        [Key]
        [ForeignKey("Person")]
        public int ID { get; set; }
        public DateTime HireDate { get; set; }
        public Person Person { get; set; }
    }
}