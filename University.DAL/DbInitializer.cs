using Microsoft.EntityFrameworkCore;
using University.DAL.Models;

namespace University.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(UniversityContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            var courses = new Course[]
            {
                new Course{Name = "Прикладна математика", Description = ""},
                new Course{Name = "Комп`ютерна інженерія", Description = ""},
                new Course{Name = "Електроніка та електромеханіка", Description = ""},
                new Course{Name = "Юридичне право", Description = ""}
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var groups = new Group[]
{
                new Group{GroupId = 101, CourseId = 0, Name = "SR-01"},
                new Group{GroupId = 102, CourseId = 0, Name = "SR-02"},
                new Group{GroupId = 103, CourseId = 0, Name = "SR-03"},
                new Group{GroupId = 111, CourseId = 1, Name = "PI-11"},
                new Group{GroupId = 121, CourseId = 2, Name = "EE-21"},
                new Group{GroupId = 131, CourseId = 3, Name = "YP-31"}
};
            context.Groups.AddRange(groups);
            context.SaveChanges();

            var students = new Student[]
            {
                new Student{StudentId = 1, GroupId = 101, FirstName = "Ія", LastName = "Атрощенко"},
                new Student{StudentId = 2, GroupId = 101, FirstName = "Гаїна", LastName = "Троцька"},
                new Student{StudentId = 3, GroupId = 101, FirstName = "Устина", LastName = "Глущак"},
                new Student{StudentId = 4, GroupId = 101, FirstName = "Шанетта", LastName = "Морачевська"},
                new Student{StudentId = 5, GroupId = 101, FirstName = "Уляна", LastName = "Савула"},
                new Student{StudentId = 6, GroupId = 101, FirstName = "Глафира", LastName = "Шамрай"},
                new Student{StudentId = 7, GroupId = 101, FirstName = "Корнелія", LastName = "Магура"},
                new Student{StudentId = 8, GroupId = 101, FirstName = "Фелікса", LastName = "Коник"},
                new Student{StudentId = 9, GroupId = 101, FirstName = "Улита", LastName = "Фартушняк"},
                new Student{StudentId = 10, GroupId = 101, FirstName = "Ада", LastName = "Варивода"},
                new Student{StudentId = 11, GroupId = 101, FirstName = "Есфіра", LastName = "Мороз"},
                new Student{StudentId = 1, GroupId = 102, FirstName = "Йоган", LastName = "Рижук"},
                new Student{StudentId = 2, GroupId = 102, FirstName = "Вітан", LastName = "Боровий"},
                new Student{StudentId = 3, GroupId = 102, FirstName = "Яртур", LastName = "Жук"},
                new Student{StudentId = 4, GroupId = 102, FirstName = "Славобор", LastName = "Сливенко"},
                new Student{StudentId = 5, GroupId = 102, FirstName = "Кий", LastName = "Бузинний"},
                new Student{StudentId = 6, GroupId = 102, FirstName = "Дантур", LastName = "Горовенко"},
                new Student{StudentId = 7, GroupId = 102, FirstName = "Ярчик", LastName = "Чічка"},
                new Student{StudentId = 8, GroupId = 102, FirstName = "Матвій", LastName = "Білявський"},
                new Student{StudentId = 9, GroupId = 102, FirstName = "Недан", LastName = "Баліцький"},
                new Student{StudentId = 10, GroupId = 102, FirstName = "Щек", LastName = "Удовенко"},
                new Student{StudentId = 1, GroupId = 103, FirstName = "Орест", LastName = "Колосовський"},
                new Student{StudentId = 2, GroupId = 103, FirstName = "Йонас", LastName = "Вихрущ"},
                new Student{StudentId = 3, GroupId = 103, FirstName = "Наслав", LastName = "Прокопчук"},
                new Student{StudentId = 4, GroupId = 103, FirstName = "Куйбіда", LastName = "Лемешко"},
                new Student{StudentId = 5, GroupId = 103, FirstName = "Ліпослав", LastName = "Мовчан"},
                new Student{StudentId = 6, GroupId = 103, FirstName = "Снозір", LastName = "Назарук"},
                new Student{StudentId = 7, GroupId = 103, FirstName = "Дорогосил", LastName = "Тарасович"},
                new Student{StudentId = 8, GroupId = 103, FirstName = "Юхим", LastName = "Забродський"},
                new Student{StudentId = 9, GroupId = 103, FirstName = "Яртур", LastName = "Цвєк"},
                new Student{StudentId = 1, GroupId = 111, FirstName = "Лук`ян", LastName = "Григоренко"},
                new Student{StudentId = 2, GroupId = 111, FirstName = "Хорив", LastName = "Горбачевський"},
                new Student{StudentId = 3, GroupId = 111, FirstName = "Царко", LastName = "Киричук"},
                new Student{StudentId = 4, GroupId = 111, FirstName = "Творимир", LastName = "Яхненко"},
                new Student{StudentId = 5, GroupId = 111, FirstName = "Яснолик", LastName = "Рошко"},
                new Student{StudentId = 6, GroupId = 111, FirstName = "Живорід", LastName = "Керножицький"},
                new Student{StudentId = 7, GroupId = 111, FirstName = "Нестор", LastName = "Засядько"},
                new Student{StudentId = 8, GroupId = 111, FirstName = "Йомер", LastName = "Павличенко"},
                new Student{StudentId = 9, GroupId = 111, FirstName = "Малик", LastName = "Білоскурський"},
                new Student{StudentId = 10, GroupId = 111, FirstName = "Осемрит", LastName = "Синиця"},
                new Student{StudentId = 1, GroupId = 121, FirstName = "Явір", LastName = "Сливенко"},
                new Student{StudentId = 2, GroupId = 121, FirstName = "Колодар", LastName = "Гайдабура"},
                new Student{StudentId = 3, GroupId = 121, FirstName = "Макар", LastName = "Гембицький"},
                new Student{StudentId = 4, GroupId = 121, FirstName = "Радогоста", LastName = "Гаркуша"},
                new Student{StudentId = 5, GroupId = 121, FirstName = "Юдихва", LastName = "Степура"},
                new Student{StudentId = 6, GroupId = 121, FirstName = "Млада", LastName = "Сенько"},
                new Student{StudentId = 7, GroupId = 121, FirstName = "Римма", LastName = "Пашко"},
                new Student{StudentId = 8, GroupId = 121, FirstName = "Цвітана", LastName = "Могиленко"},
                new Student{StudentId = 9, GroupId = 121, FirstName = "Марта", LastName = "Кирей"},
                new Student{StudentId = 10, GroupId = 121, FirstName = "Глафіра", LastName = "Любенецька"},
                new Student{StudentId = 11, GroupId = 121, FirstName = "Віра", LastName = "Тарасовна"},
                new Student{StudentId = 1, GroupId = 131, FirstName = "Жадана", LastName = "Заяць"},
                new Student{StudentId = 2, GroupId = 131, FirstName = "Тава", LastName = "Андрусенко"},
                new Student{StudentId = 3, GroupId = 131, FirstName = "Ядвіга", LastName = "Воронюк"},
                new Student{StudentId = 4, GroupId = 131, FirstName = "Стелла", LastName = "Рибенчук"},
                new Student{StudentId = 5, GroupId = 131, FirstName = "Мокрина", LastName = "Трегуб"}
            };
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
