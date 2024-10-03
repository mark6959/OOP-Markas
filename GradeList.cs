using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitNavnAflevering
{
    internal class GradeList
    {
        private int size;
        private List <Grade> grades = new List<Grade>();
        public GradeList(int MaxNumberOfGrades) { } 

        public int GetSize() {
            return size;
        }

        public Grade GetGrade(string index) {
            foreach (Grade grade in grades)
            {
                if(grade.getName() == index)
                {
                    return grade;
                }
            }
            return null;
        }

        public void AddGrade(Grade Grade) {
            grades.Add(Grade);
        }

        public Grade[] getAllGrades()
            { return grades.ToArray(); }

        public double getAverage()
        {
            double sum = 0;
            foreach (Grade grade in grades)
            {
                sum += grade.getPoint();
            }
            return sum / grades.Count;
        }

        public string? toString()
        {
            return null;
        }
    }

}
