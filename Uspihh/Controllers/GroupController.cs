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

        public GroupController(IGroupService groupService, IMapper<GroupEntity, GroupDTO> groupMapper)
        {
            this.groupService = groupService;
            this.groupMapper = groupMapper;
        }

        public IHttpActionResult GetGroupById([FromUri]long groupId)
        {
            var group = groupService.GetById(groupId);
            var groupDTO = groupMapper.Map(group);

            return Ok(groupDTO);
        }

        public IHttpActionResult GetAllGroups([FromUri]long groupId)
        {
            var groups = groupService.GetAll();
            var groupsDTO = groups.Select(groupMapper.Map).ToList();
            return Ok(groupsDTO);
        }

        public IHttpActionResult CreateGroup([FromBody]GroupDTO student)
        {
            var group = groupMapper.Map(student);
            groupService.CreateGroup(group);
            return Ok();
        }
    }
}