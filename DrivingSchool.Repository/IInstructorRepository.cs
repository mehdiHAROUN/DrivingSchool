using DrivingSchool.Repository.models;

namespace DrivingSchool.Repository
{
    public interface IInstructorRepository
    {
        List<Instructor>? GetAllInstructor();
    }
}