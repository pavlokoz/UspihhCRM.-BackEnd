using System.Collections.Generic;
using Uspihh.Models.EntityModels;

namespace Uspihh.Services.Services
{
    public interface ITestService
    {
        IList<TestEntity> GetAll();
    }
}
