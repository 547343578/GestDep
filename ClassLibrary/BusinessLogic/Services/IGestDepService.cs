using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestDep.Entities;

namespace GestDep.Services
{
    public interface IGestDepService
    {
        void RemoveAllData();
        void Commit();
        void AddCityHall(CityHall city);
        void AddGym(Gym gym);
        void AddRoom(Room room);
        void AddInstructor(Instructor m);
        void AddActivity(Activity a);
        void AddUser(User u);
        void AddEnrollment(Enrollment e);
        CityHall FindCityHallByName(string name);
        Instructor FindInstructorById(string id);
        User FindUserById(string id);
        Activity FindActivityByName(string name);
        Gym FindGymByName(string name);
        ICollection<Activity> GetAllActivities();
        ICollection<Gym> GetAllGyms();
        ICollection<Instructor> GetAllInstructors();
        ICollection<Enrollment> GetAllEnrollments();
        ICollection<CityHall> GetAllCityHalls();
    }
}
