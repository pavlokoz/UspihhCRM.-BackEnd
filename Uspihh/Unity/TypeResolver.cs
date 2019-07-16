using Unity;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;
using Uspihh.Models.IdentityModels;
using Uspihh.Models.Mappers;
using Uspihh.Models.Mappers.Impl;
using Uspihh.Services.Services;
using Uspihh.Services.Services.Impl;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Unity
{
    public class TypeResolver
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();

            //Services
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentService, StudentService>();

            //Mappers
            container.RegisterType<IMapper<TestEntity, TestDTO>, TestMapper>();
            container.RegisterType<IMapper<ApplicationUser, RegisterOfUserBindingModel>, UserMapper>();
            container.RegisterType<IMapper<StudentEntity, StudentDTO>, StudentMapper>();

        }
    }
}