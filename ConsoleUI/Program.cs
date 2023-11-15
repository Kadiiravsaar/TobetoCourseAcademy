using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;

//CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

//CourseInstructorManager courseInstructorManager  = new CourseInstructorManager(new EFCourseInstructorDal());

//CourseInstructorManager courseInstructorManager = new CourseInstructorManager(new EFCourseInstructorDal());
////
//CourseInstructor courseInstructor = new CourseInstructor { InstructorId = 4, CourseId = 4 };
//courseInstructorManager.Add(courseInstructor);


//Instructor instructor1 = new Instructor { Name = "Ersin" }; // ID eklersen naneyi yersin 
//InsturctorManager ınsturctorManager = new InsturctorManager(new EFInstructorDal());
//ınsturctorManager.Add(instructor1);




CourseManager courseManager = new CourseManager(new EFCourseDal(), );


//Course course1 = new Course
//{
//    Name = "Ruby2",
//    CategoryId = 2,
//    Description = "olur2 olur",
//    ImageUrl = "Ersinburda2.png",
//    Price = 102,
//    CourseInstructors = new List<CourseInstructor>() { new CourseInstructor { InstructorId = 4, CourseId = 5 } } bunu eklemedi Ersin : Macera aramayın. Barış: yok . Onur: ersin +1
//};
//courseManager.Add(course1);




var curse = courseManager.GetCourse(5); // bu ersin
foreach (var courseInstructor in curse.CourseInstructors)
{
    Console.Write($"{courseInstructor.Instructor.Name} {courseInstructor.Course.Name} ");
    Console.WriteLine();
}


//foreach (var item in courseManager.GetCourse(2))
//{
//    Console.WriteLine(item.Name);
//}


//InsturctorManager ınsturctorManager = new InsturctorManager(new EFInstructorDal());
//CourseManager courseManager = new CourseManager(new EFCourseDal());

//Console.WriteLine("Kodlama.io Eğitim Kanalına Hoşgeldiniz");
//Console.WriteLine("**");
//Console.WriteLine("\nLütfen kurs numarası giriniz...");
//Console.WriteLine("( C#:1 / Java:2 / Python:3 / HTML:4 / CSS:5 )");
//int courseNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("\nSeçim ekrana getiriliyor...\n---------------------------");

//var course = courseManager.GetCourse(1);

//foreach (var courseInstructor in course.CourseInstructors)
//{
//    Console.Write($"{courseInstructor.Instructor.Name} ");
//}

