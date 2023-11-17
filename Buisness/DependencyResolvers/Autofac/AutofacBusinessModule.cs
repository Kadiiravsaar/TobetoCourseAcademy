using Autofac;
using Buisness.Abstract;
using Buisness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Buisness.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EFCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CourseInstructorManager>().As<ICourseInstructorDal>().SingleInstance();
            builder.RegisterType<EFCourseInstructorDal>().As<ICourseInstructorDal>().SingleInstance();

            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EFCourseDal>().As<ICourseDal>().SingleInstance();

            builder.RegisterType<InsturctorManager>().As<IInstructorService>().SingleInstance();
            builder.RegisterType<EFInstructorDal>().As<IInstructorDal>().SingleInstance();

        }
    }
}
