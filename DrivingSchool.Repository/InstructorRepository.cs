using DrivingSchool.Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public InstructorRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public List<Instructor>? GetAllInstructor()
        {
            return _repositoryContext?.Instructors?.ToList();
        }
    }
}
