using System.Collections.Generic;
using System.Linq;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Services.Services.Impl
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public GroupService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        public GroupEntity GetById(long id)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                
                var query = from groupRepo in uow.GroupRepository.Get()
                            join subjectRepo in uow.SubjectRepository.Get()
                            on groupRepo.SubjectId equals subjectRepo.SubjectId
                            join groupStudentRepo in uow.GroupStudentRepository.Get()
                            on groupRepo.GroupId equals groupStudentRepo.GroupId into groupLeft
                            from groupStudentRepo in groupLeft.DefaultIfEmpty()
                            join studentRepo in uow.StudentRepository.Get()
                            on groupStudentRepo.StudentId equals studentRepo.StudentId into studentLeft
                            from studentRepo in studentLeft.DefaultIfEmpty()
                            join groupTeacherRepo in uow.GroupTeacherRepository.Get()
                            on groupRepo.GroupId equals groupTeacherRepo.GroupId into groupTeacherLeft
                            from groupTeacherRepo in groupTeacherLeft.DefaultIfEmpty()
                            join teacherRepo in uow.TeacherRepository.Get()
                            on groupTeacherRepo.TeacherId equals teacherRepo.TeacherId into teacherLeft
                            from teacherRepo in teacherLeft.DefaultIfEmpty()
                            where groupRepo.GroupId == id
                            select new { groupRepo, groupStudentRepo, subjectRepo, studentRepo, teacherRepo, groupTeacherRepo};
                var group = query.ToList().
                    Select(x => x.groupRepo).Distinct().SingleOrDefault();

                if (group == null)
                {
                    return null;
                }
                
                group.Students = group.GroupStudents.Select(x => x.Student).ToList();
                group.Teachers = group.GroupTeachers.Select(x => x.Teacher).ToList();
                return group;
            }
        }

        public IList<GroupEntity> GetAll()
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var query = from groupRepo in uow.GroupRepository.Get()
                            join subjectRepo in uow.SubjectRepository.Get()
                            on groupRepo.SubjectId equals subjectRepo.SubjectId
                            select new { groupRepo, subjectRepo };
                var result = query.ToList().Select(x => x.groupRepo).ToList();
                return result;
            }
        }

        public void Create(GroupEntity group)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.GroupRepository.Insert(group);
                uow.Save();
            }
        }

        public void Delete(GroupEntity entity)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.GroupRepository.Delete(entity);
                uow.Save();
            }
        }
    }
}
