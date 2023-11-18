using Autofac;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EFCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CourseInstructorManager>().As<ICourseInstructorService>().SingleInstance();
            builder.RegisterType<EFCourseInstructorDal>().As<ICourseInstructorDal>().SingleInstance();

            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EFCourseDal>().As<ICourseDal>().SingleInstance();

            builder.RegisterType<InstructorManager>().As<IInstructorService>().SingleInstance();
            builder.RegisterType<EFInstructorDal>().As<IInstructorDal>().SingleInstance();

        }
    }
}
