using DrivingSchool.Repository.models;

namespace DrivingSchool.Repository
{
    public interface ICandidateRepository
    {
        List<Candidate> GetAllCandidate();
    }
}