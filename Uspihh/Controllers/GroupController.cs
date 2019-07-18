using System.Linq;
using System.Web.Http;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;
using Uspihh.Models.Mappers;
using Uspihh.Services.Services;

namespace Uspihh.Controllers
{
    [Authorize]
    public class GroupController: ApiController
    {
        private readonly IGroupService groupService;
        private readonly IMapper<GroupEntity, GroupDTO> groupMapper;
        private readonly IMapper<GroupEntity, GroupDetailDTO> groupDetailMapper;

        public GroupController(IGroupService groupService, 
            IMapper<GroupEntity, GroupDTO> groupMapper, 
            IMapper<GroupEntity, GroupDetailDTO> groupDetailMapper)
        {
            this.groupService = groupService;
            this.groupMapper = groupMapper;
            this.groupDetailMapper = groupDetailMapper;
        }

        public IHttpActionResult GetGroupById([FromUri]long groupId)
        {
            var group = groupService.GetById(groupId);
            var groupDetailDTO = groupDetailMapper.Map(group);

            return Ok(groupDetailDTO);
        }

        public IHttpActionResult GetAllGroups()
        {
            var groups = groupService.GetAll();
            var groupsDTO = groups.Select(groupMapper.Map).ToList();
            return Ok(groupsDTO);
        }

        public IHttpActionResult CreateGroup([FromBody]GroupDTO student)
        {
            var group = groupMapper.Map(student);
            groupService.Create(group);
            return Ok();
        }
    }
}