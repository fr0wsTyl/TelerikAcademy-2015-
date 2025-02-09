/*
 We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines. 
 * Students have name and unique class number. Classes have unique text identifier.
 * Teachers have name. Disciplines have name, number of lectures and number of exercises.
 * Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields,
 * define the class hierarchy and create a class diagram with Visual Studio.
 */

namespace Problem_1.School_classes
{
    public class Discipline : IComment
    {
        public string DisciplineName { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }
        public string Comment { get; set; }
    }
}