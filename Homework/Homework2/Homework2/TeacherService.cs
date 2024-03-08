using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class TeacherService
    {
        private const string filePath = "teachers.json";

        public void AddTeacher(Teacher teacher)
        {
            var teachers = GetAllTeachers();
            teachers.Add(teacher);
            SaveTeachers(teachers);
        }

        public List<Teacher> GetAllTeachers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Teacher>>(json) ?? new List<Teacher>();
            }
            else
            {
                return new List<Teacher>();
            }
        }

        public void SaveTeachers(List<Teacher> teachers)
        {
            string json = JsonConvert.SerializeObject(teachers);
            File.WriteAllText(filePath, json);
        }

        public void DisplayAllTeachers()
        {
            var teachers = GetAllTeachers();
            if (teachers.Count > 0)
            {
                Console.WriteLine("List of all teachers:");
                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Name: {teacher.Name}, Surname: {teacher.Surname}, Subject: {teacher.Subject}, Id: {teacher.Id}");
                }
            }
            else
            {
                Console.WriteLine("No teachers found.");
            }
        }

        public string GetTeacherNameById(Guid teacherId)
        {
            var teachers = GetAllTeachers();
            var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacher != null)
            {
                return $"{teacher.Name} {teacher.Surname}";
            }
            else
            {
                return "Unknown Teacher"; 
            }
        }

        public void QuitTeacher(Guid teacherId)
        {
            var teachers = GetAllTeachers();
            var teacherToRemove = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacherToRemove != null)
            {
                teachers.Remove(teacherToRemove);
                SaveTeachers(teachers);
                Console.WriteLine($"Teacher {teacherToRemove.Name} {teacherToRemove.Surname} removed");

                RemoveLessonsByTeacher(teacherId);
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }

        private void RemoveLessonsByTeacher(Guid teacherId)
        {
            var lessonManager = new LessonManager("lessons.json");
            var lessons = lessonManager.LoadLessons();
            var lessonsToRemove = lessons.Where(lesson => lesson.Teacher == teacherId).ToList();
            foreach (var lesson in lessonsToRemove)
            {
                lessons.Remove(lesson);
            }
            lessonManager.SaveLessons(lessons);
        }
    }
}
