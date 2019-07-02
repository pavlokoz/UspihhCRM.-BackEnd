using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;
using Uspihh.Models.Mappers;
using Uspihh.Services.Services;

namespace Uspihh.Controllers
{
    [AllowAnonymous]
    public class TestController : ApiController
    {
        private readonly ITestService testService;
        private readonly IMapper<TestEntity, TestDTO> testMapper;

        public TestController(ITestService testService, IMapper<TestEntity, TestDTO> testMapper)
        {
            this.testService = testService;
            this.testMapper = testMapper;
        }

        [Route("")]
        public IList<TestDTO> GetAll()
        {
            var result = testService.GetAll();
            return result.Select(testMapper.Map).ToList();
        }
    }
}
