using Microsoft.EntityFrameworkCore;
using University.DAL.Models;

namespace University.DAL.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Course>().HasData(
        //    new Course { Id = 1, Name = "Прикладна математика", Description = "" }
        //    );
        //modelBuilder.Entity<Group>().HasData(
        //    new Group { Id = 1, Name = "SR-11" }
        //    );
        //modelBuilder.Entity<Student>().HasData(
        //    new Student { Id = 1, FirstName = "Ія", LastName = "Атрощенко" }
        //    );




        //modelBuilder.Entity<Course>().HasData(
        //    new Course { CourseId = 1, Name = "Прикладна математика", Description = "" },
        //    new Course { CourseId = 2, Name = "Комп`ютерна інженерія", Description = "" },
        //    new Course { CourseId = 3, Name = "Електроніка та електромеханіка", Description = "" },
        //    new Course { CourseId = 4, Name = "Юридичне право", Description = "" }
        //    );

        //modelBuilder.Entity<Group>().HasData(
        //    new Group { GroupId = 111, CourseId = 1, Name = "SR-11" },
        //    new Group { GroupId = 112, CourseId = 1, Name = "SR-12" },
        //    new Group { GroupId = 113, CourseId = 1, Name = "SR-13" },
        //    new Group { GroupId = 121, CourseId = 2, Name = "PI-21" },
        //    new Group { GroupId = 131, CourseId = 3, Name = "EE-31" },
        //    new Group { GroupId = 141, CourseId = 4, Name = "YP-41" }
        //    );

        //modelBuilder.Entity<Student>().HasData(
        //    new Student { StudentId = 1, GroupId = 111, FirstName = "Ія", LastName = "Атрощенко" },
        //    new Student { StudentId = 2, GroupId = 111, FirstName = "Гаїна", LastName = "Троцька" },
        //    new Student { StudentId = 3, GroupId = 111, FirstName = "Устина", LastName = "Глущак" },
        //    new Student { StudentId = 4, GroupId = 111, FirstName = "Шанетта", LastName = "Морачевська" },
        //    new Student { StudentId = 5, GroupId = 111, FirstName = "Уляна", LastName = "Савула" },
        //    new Student { StudentId = 6, GroupId = 111, FirstName = "Глафира", LastName = "Шамрай" },
        //    new Student { StudentId = 7, GroupId = 111, FirstName = "Корнелія", LastName = "Магура" },
        //    new Student { StudentId = 8, GroupId = 111, FirstName = "Фелікса", LastName = "Коник" },
        //    new Student { StudentId = 9, GroupId = 111, FirstName = "Улита", LastName = "Фартушняк" },
        //    new Student { StudentId = 10, GroupId = 111, FirstName = "Ада", LastName = "Варивода" },
        //    new Student { StudentId = 11, GroupId = 111, FirstName = "Есфіра", LastName = "Мороз" },
        //    new Student { StudentId = 12, GroupId = 112, FirstName = "Йоган", LastName = "Рижук" },
        //    new Student { StudentId = 13, GroupId = 112, FirstName = "Вітан", LastName = "Боровий" },
        //    new Student { StudentId = 14, GroupId = 112, FirstName = "Яртур", LastName = "Жук" },
        //    new Student { StudentId = 15, GroupId = 112, FirstName = "Славобор", LastName = "Сливенко" },
        //    new Student { StudentId = 16, GroupId = 112, FirstName = "Кий", LastName = "Бузинний" },
        //    new Student { StudentId = 17, GroupId = 112, FirstName = "Дантур", LastName = "Горовенко" },
        //    new Student { StudentId = 18, GroupId = 112, FirstName = "Ярчик", LastName = "Чічка" },
        //    new Student { StudentId = 19, GroupId = 112, FirstName = "Матвій", LastName = "Білявський" },
        //    new Student { StudentId = 20, GroupId = 112, FirstName = "Недан", LastName = "Баліцький" },
        //    new Student { StudentId = 21, GroupId = 112, FirstName = "Щек", LastName = "Удовенко" },
        //    new Student { StudentId = 22, GroupId = 113, FirstName = "Орест", LastName = "Колосовський" },
        //    new Student { StudentId = 23, GroupId = 113, FirstName = "Йонас", LastName = "Вихрущ" },
        //    new Student { StudentId = 24, GroupId = 113, FirstName = "Наслав", LastName = "Прокопчук" },
        //    new Student { StudentId = 25, GroupId = 113, FirstName = "Куйбіда", LastName = "Лемешко" },
        //    new Student { StudentId = 26, GroupId = 113, FirstName = "Ліпослав", LastName = "Мовчан" },
        //    new Student { StudentId = 27, GroupId = 113, FirstName = "Снозір", LastName = "Назарук" },
        //    new Student { StudentId = 28, GroupId = 113, FirstName = "Дорогосил", LastName = "Тарасович" },
        //    new Student { StudentId = 29, GroupId = 113, FirstName = "Юхим", LastName = "Забродський" },
        //    new Student { StudentId = 30, GroupId = 113, FirstName = "Яртур", LastName = "Цвєк" },
        //    new Student { StudentId = 31, GroupId = 121, FirstName = "Лук`ян", LastName = "Григоренко" },
        //    new Student { StudentId = 32, GroupId = 121, FirstName = "Хорив", LastName = "Горбачевський" },
        //    new Student { StudentId = 33, GroupId = 121, FirstName = "Царко", LastName = "Киричук" },
        //    new Student { StudentId = 34, GroupId = 121, FirstName = "Творимир", LastName = "Яхненко" },
        //    new Student { StudentId = 35, GroupId = 121, FirstName = "Яснолик", LastName = "Рошко" },
        //    new Student { StudentId = 36, GroupId = 121, FirstName = "Живорід", LastName = "Керножицький" },
        //    new Student { StudentId = 37, GroupId = 121, FirstName = "Нестор", LastName = "Засядько" },
        //    new Student { StudentId = 38, GroupId = 121, FirstName = "Йомер", LastName = "Павличенко" },
        //    new Student { StudentId = 39, GroupId = 121, FirstName = "Малик", LastName = "Білоскурський" },
        //    new Student { StudentId = 40, GroupId = 121, FirstName = "Осемрит", LastName = "Синиця" },
        //    new Student { StudentId = 41, GroupId = 131, FirstName = "Явір", LastName = "Сливенко" },
        //    new Student { StudentId = 42, GroupId = 131, FirstName = "Колодар", LastName = "Гайдабура" },
        //    new Student { StudentId = 43, GroupId = 131, FirstName = "Макар", LastName = "Гембицький" },
        //    new Student { StudentId = 44, GroupId = 131, FirstName = "Радогоста", LastName = "Гаркуша" },
        //    new Student { StudentId = 45, GroupId = 131, FirstName = "Юдихва", LastName = "Степура" },
        //    new Student { StudentId = 46, GroupId = 131, FirstName = "Млада", LastName = "Сенько" },
        //    new Student { StudentId = 47, GroupId = 131, FirstName = "Римма", LastName = "Пашко" },
        //    new Student { StudentId = 48, GroupId = 131, FirstName = "Цвітана", LastName = "Могиленко" },
        //    new Student { StudentId = 49, GroupId = 131, FirstName = "Марта", LastName = "Кирей" },
        //    new Student { StudentId = 50, GroupId = 131, FirstName = "Глафіра", LastName = "Любенецька" },
        //    new Student { StudentId = 51, GroupId = 131, FirstName = "Віра", LastName = "Тарасовна" },
        //    new Student { StudentId = 52, GroupId = 141, FirstName = "Жадана", LastName = "Заяць" },
        //    new Student { StudentId = 53, GroupId = 141, FirstName = "Тава", LastName = "Андрусенко" },
        //    new Student { StudentId = 54, GroupId = 141, FirstName = "Ядвіга", LastName = "Воронюк" },
        //    new Student { StudentId = 55, GroupId = 141, FirstName = "Стелла", LastName = "Рибенчук" },
        //    new Student { StudentId = 56, GroupId = 141, FirstName = "Мокрина", LastName = "Трегуб" }
        //    );
    }
}
