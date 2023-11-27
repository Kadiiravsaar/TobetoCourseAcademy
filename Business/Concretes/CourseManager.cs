using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concretes;
using Entities.Dto;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        ICategoryService _categoryService ;

        // bir entity manager kendisi hariç başka Dal'ı enjekte edemez ***

        public CourseManager(ICourseDal courseDal, ICategoryService categoryService)
        {
            _courseDal = courseDal;
            _categoryService = categoryService;
        }


        [ValidationAspect(typeof(CourseValidator))]
        // bu metodu doğrula(ValidationAspect)  (typeof) CourseValidator kullanarak
        public IResult Add(Course course)
        {

            var result = BusinessRules.Run(CheckIfProdCountOfCategory(course.Id),CheckIfCourseNameExists(course.Name),
                CheckIfCategoryLimitExceded());

            if (result!=null)
            {
                return result;
            }

            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleteded);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return new SuccessDataResult<List<Course>>
                (_courseDal.GetAll(p => p.Price > minValue && p.Price < maxValue), Messages.GetData);
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(x => x.Id == id), Messages.GetData);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetail()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<CourseDetailDto>>("Sistem Bakımda");

            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetail(), Messages.GetCourseDetail);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);

        }
        private IResult CheckIfProdCountOfCategory(int id)
        {

            var result = _courseDal.GetAll(x => x.CategoryId == id).Count();

            if (result >= 15)
            {
                return new ErrorDataResult<Course>("Sayı 15den büyük");
            }
            else
                return new SuccessResult("Başarılı");
        }
        private IResult CheckIfCourseNameExists(string course)
        {

            var result = _courseDal.GetAll(x => x.Name == course).Any();

            if (result)
            {
                return new ErrorDataResult<Course>("Aynı isimden var aga");
            }
            else
                return new SuccessResult("Başarılı");
        }

        private IResult CheckIfCategoryLimitExceded()
        {

            var result = _categoryService.GetAll();

            if (result.Data.Count()>=15)
            {
                return new ErrorDataResult<Course>("15i geçti aga ürün ekleme");
            }
            else
                return new SuccessResult("Başarılı");
        }



    }
}
