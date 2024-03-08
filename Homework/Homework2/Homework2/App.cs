using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homework2
{
    public class App
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Harvard University app!");
                Console.WriteLine("Please select an option");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add a Student");
                Console.WriteLine("2. See All Students");
                Console.WriteLine("3. Remove a Student");
                Console.WriteLine("4. Add a Teacher");
                Console.WriteLine("5. See All Teachers");
                Console.WriteLine("6. Quit a Teacher");
                Console.WriteLine("7. Add a Lesson");
                Console.WriteLine("8. See Schedule For The Group");
                Console.WriteLine("");
                Console.WriteLine("Select a command");

                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewAllStudents();
                        break;
                    case 3:
                        RemoveStudentById();
                        break;
                    case 4:
                        AddTeacher();
                        break;
                    case 5:
                        ViewAllTeachers();
                        break;
                    case 6:
                        QuitTeacher();
                        break;
                    case 7:
                        AddLesson();
                        break;
                    case 8:
                        SeeAllLessons();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        }
        public void AddStudent()
        {
            Console.WriteLine("Please enter student's name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Please enter student's surname: ");
            string surname = Console.ReadLine() ?? "";

            int studentGroup;
            bool validInput = false;

            do
            {
                Console.WriteLine("Please enter student's group: ");
                string groupInput = Console.ReadLine() ?? "";

                if (!int.TryParse(groupInput, out studentGroup))
                {
                    Console.WriteLine("Invalid input for group. Please enter a valid integer value.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            var studentService = new StudentService();
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = name,
                Surname = surname,
                Group = studentGroup
            };
            studentService.AddStudent(student);

            Console.WriteLine($"Student {student.Name} {student.Surname} added");
        }
        public void ViewAllStudents()
        {
            var studentService = new StudentService();
            studentService.DisplayAllStudents();
        }
        public void RemoveStudentById()
        {
            Console.WriteLine("Please enter the ID of the student you want to remove: ");
            if (Guid.TryParse(Console.ReadLine(), out Guid studentId))
            {
                var studentService = new StudentService();
                studentService.RemoveStudent(studentId);
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }
        public void AddTeacher()
        {
            Console.WriteLine("Please enter teacher's name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Please enter teacher's surname: ");
            string surname = Console.ReadLine() ?? "";

            var teacherService = new TeacherService();
            var teacher = new Teacher
            {
                Id = Guid.NewGuid(),
                Name = name,
                Surname = surname
            };
            teacherService.AddTeacher(teacher);

            Console.WriteLine($"Teacher {teacher.Name} {teacher.Surname} added");
        }
        public void ViewAllTeachers()
        {
            var teacherService = new TeacherService();
            teacherService.DisplayAllTeachers();
        }
        public void QuitTeacher()
        {
            Console.WriteLine("Enter Teacher ID to quit:");
            Guid teacherId;
            if (!Guid.TryParse(Console.ReadLine(), out teacherId))
            {
                Console.WriteLine("Invalid Teacher ID.");
                return; 
            }

            var teacherService = new TeacherService();
            teacherService.QuitTeacher(teacherId);
        }
        public static void AddLesson()
        {
            Console.WriteLine("Enter Teacher ID:");
            Guid teacherId;
            if (!Guid.TryParse(Console.ReadLine(), out teacherId))
            {
                Console.WriteLine("Invalid Teacher ID.");
                return; 
            }

            Console.WriteLine("Enter Group:");
            int group;
            if (!int.TryParse(Console.ReadLine(), out group))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the group.");
                return;
            }

            Console.WriteLine("Enter Subject:");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Day:");
            string day = Console.ReadLine();
            if (!LessonManager.IsValidDay(day))
            {
                Console.WriteLine("Invalid day. Lessons can only be scheduled from Monday to Friday.");
                return;
            }

            Console.WriteLine("Enter Time:");
            string time = Console.ReadLine();

            LessonManager lessonManager = new LessonManager("lessons.json");

            if (!lessonManager.IsTeacherAvailable(teacherId, day, time) || !lessonManager.IsSlotAvailable(group, day, time))
            {
                Console.WriteLine("Teacher is not available at the specified time and day, or the slot is already occupied. Lesson cannot be added.");
                return;
            }

            Lesson newLesson = new Lesson
            {
                Teacher = teacherId,
                Group = group,
                Subject = subject,
                Day = day,
                Time = time
            };

            lessonManager.AddLesson(newLesson);
            Console.WriteLine("Lesson added successfully.");
        }

        public void SeeAllLessons()
        {
            LessonManager lessonManager = new LessonManager("lessons.json");
            TeacherService teacherService = new TeacherService();

            Console.WriteLine("Enter the group:");
            int group;
            if (!int.TryParse(Console.ReadLine(), out group))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the group.");
                return;
            }

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine($"Lessons for {day}:");
                List<Lesson> lessonsForDay = lessonManager.GetLessonsForDay(group, day);

                foreach (var lesson in lessonsForDay)
                {
                    string teacherName = teacherService.GetTeacherNameById(lesson.Teacher);
                    Console.WriteLine($"Teacher: {teacherName}, Subject: {lesson.Subject}, Time: {lesson.Time}");
                }
                if (lessonsForDay.Count == 0)
                {
                    Console.WriteLine("No lessons scheduled.");
                }
                Console.WriteLine();
            }
        }
    }

}

