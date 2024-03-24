using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homework2
{
    public class StudentService
    {
        private const string filePath = "students.json";

        public void AddStudent(Student student)
        {
            var students = GetAllStudents();
            students.Add(student);
            SaveStudents(students);
        }

        public List<Student> GetAllStudents()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
            }
            else
            {
                return new List<Student>();
            }
        }

        public void DisplayAllStudents()
        {
            var students = GetAllStudents();
            if (students.Count > 0)
            {
                Console.WriteLine("List of all students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Group: {student.Group}, Id {student.Id}");
                }
            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }

        private void SaveStudents(List<Student> students)
        {
            string json = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, json);
        }

        public void RemoveStudent(Guid studentId)
        {
            var students = GetAllStudents();
            var studentToRemove = students.FirstOrDefault(s => s.Id == studentId);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                SaveStudents(students);
                Console.WriteLine($"Student with ID {studentId} removed.");
            }
            else
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }
    }
}
