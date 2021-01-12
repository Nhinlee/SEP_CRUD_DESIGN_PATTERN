using System;
using CustomHibernateSQL.Attributes;

namespace TestingHibernateSQL
{
    [Table("Employees", "dbo")]
    class Employee
    {

        [Column("ID",FieldFlags.PRIMARY_KEY)]
        public string Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("BirthDate")]
        public DateTime BirthDate { get; set; }

        [Column("Position")]
        public string Position { get; set; }

        [Column("Salary")]
        public float Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, BirthDate: {BirthDate}, Position: {Position}, Salary: {Salary}";
        }
    }
}
