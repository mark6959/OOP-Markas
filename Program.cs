namespace gitNavnAflevering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade student1 = new Grade("Markas", 50);
            Grade student2 = new Grade("Bob", 100);

            GradeList gradeList = new GradeList(2);

            gradeList.AddGrade(student1);
            gradeList.AddGrade(student2);

            Grade[] grades = gradeList.getAllGrades();
            foreach (Grade grade in grades )
            {
                Console.WriteLine("Name: " +grade.getName() + "Point: " + grade.getPoint());
            }
        }
    }
}