using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homework2
{
    internal class LessonManager
    {
        private string _lessonsFile;
        public LessonManager(string lessonsFile)
        {
            _lessonsFile = lessonsFile;
        }
        public List<Lesson> LoadLessons()
        {
            if (File.Exists(_lessonsFile))
            {
                string json = File.ReadAllText(_lessonsFile);
                return JsonConvert.DeserializeObject<List<Lesson>>(json);
            }
            else
            {
                return new List<Lesson>();
            }
        }
        public void SaveLessons(List<Lesson> lessons)
        {
            string json = JsonConvert.SerializeObject(lessons, Formatting.Indented);
            File.WriteAllText(_lessonsFile, json);
        }
        public void AddLesson(Lesson lesson)
        {
            List<Lesson> lessons = LoadLessons();
            lessons.Add(lesson);
            SaveLessons(lessons);
        }
        public bool IsTeacherAvailable(Guid teacherId, string day, string time)
        {
            List<Lesson> lessons = LoadLessons();

            foreach (var lesson in lessons)
            {
                if (lesson.Teacher == teacherId && lesson.Day == day && lesson.Time == time)
                {
                    return false; 
                }
            }

            return true;
        }
        public List<Lesson> GetLessonsForDay(int group, string day)
        {
            List<Lesson> lessons = LoadLessons();

            // Filter lessons for the specified group and day
            List<Lesson> lessonsForDay = lessons.Where(l => l.Group == group && l.Day == day).ToList();

            return lessonsForDay;
        }
        public void RemoveLesson(Lesson lesson)
        {
            List<Lesson> lessons = LoadLessons();
            lessons.Remove(lesson);
            SaveLessons(lessons);
        }

        public bool IsSlotAvailable(int group, string day, string time)
        {
            List<Lesson> lessons = LoadLessons();

            // Count lessons for the specified group, day, and time slot
            int count = lessons.Count(l => l.Group == group && l.Day == day && l.Time == time);

            // Check if the slot is available (less than 3 lessons already scheduled)
            return count < 3;
        }
        public static bool IsValidDay(string day)
        {
            return day.ToLower() == "monday" || day.ToLower() == "tuesday" || day.ToLower() == "wednesday" || day.ToLower() == "thursday" || day.ToLower() == "friday";
        }
        public List<Lesson> GetLessonsForTime(int group, string day, string time)
        {
            List<Lesson> lessons = LoadLessons();
            List<Lesson> lessonsForTime = lessons.Where(l => l.Group == group && l.Day == day && l.Time == time).ToList();

            return lessonsForTime;
        }


    }
}
