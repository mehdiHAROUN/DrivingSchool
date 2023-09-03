using DrivingSchool.Repository.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public CandidateRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public List<Candidate> GetAllCandidate()
        {
            return _repositoryContext.Candidates.ToList();
        }
    }

}
