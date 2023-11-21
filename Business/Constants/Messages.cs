using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        #region Course
        public static string CourseAdded = " Kurs Eklendi";
        public static string CourseUpdated = " Kurs Eklendi";
        public static string CourseDeleted = " Kurs Silindi";
        public static string CourseListed = "Kurslar Listelendi";
        public static string GetCourse = "Kurs Getirildi";
        public static string GetCourseDetail = "Kurs Detayları Getirildi";



        #endregion


        #region Genel

        public static string Added = " Veri Eklendi";
        public static string Updated = " Veri Güncellendi";
        public static string Deleteded = " Veri Silindi";
        public static string Listed = "Veri Listelendi";
        public static string GetData = "Veri Getirildi";




        #endregion

        #region Category

        public static string CategoryAdded = "Added";
        public static string CategoryDeleted = " Category Deleted";
        public static string GetCategory = "Kategori Getirildi";
        public static string CategoryUpdated = " Category Updated";
        public static string CategoriesListed = "Listed";

        #endregion


        #region CourseInstructor

        public static string CourseInstructorAdded = "Added";
        public static string CourseInstructorDeleted = " Category Deleted";
        public static string GetCourseInstructor = "Kategıri Getirildi";
        public static string CourseInstructorUpdated = " Category Updated";
        public static string CourseInstructorListed = "Listed";




        #endregion


        public static string ErrorMessage = " Error Message";
    }
}
