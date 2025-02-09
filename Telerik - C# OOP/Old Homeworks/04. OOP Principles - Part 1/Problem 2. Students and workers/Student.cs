/*
 * Define abstract class Human with first name and last name.
 * Define new class Student which is derived from Human and has new field � grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
*/
namespace Problem_2.Students_and_workers
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public override string Firstname { get; set; }

        public override string Lastname { get; set; }

        public Student(string inputFName, string inputLName, int inputGrade)
            : base(inputFName, inputLName)
        {
            this.Grade = inputGrade;
        }

        public override string ToString()
        {
            return "Grade: [" + this.Grade + "] Name -> " + this.Firstname + " " + this.Lastname;
        }
    }
}