using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestDep.Services;

namespace GestDep.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            Rooms = new List<Room>();
            Enrollments = new List<Enrollment>();
        }

        public Activity(Days days, String description, TimeSpan duration, DateTime finishDate,
            int maximumEnrollments, int minimumEnrollments, double price, DateTime startDate, DateTime startHour) :this()
        {
            this.ActivityDays = days;
            this.Description = description;
            this.Duration = duration;
            this.FinishDate = finishDate;
            this.MaximumEnrollments = maximumEnrollments;
            this.MinimumEnrollments = minimumEnrollments;
            this.Price = price;
            this.StartDate = startDate;
            this.StartHour = startHour;
            this.Cancelled = false;
        }

        public void SetInstructor(Instructor i)
        {   
            foreach (Activity a in i.Activities)
            {
                if (!(a.StartDate > this.FinishDate || a.FinishDate < this.StartDate))
                {
                    if ((a.ActivityDays & this.ActivityDays) != 0)
                    {
                        if (!(a.StartHour > (this.StartHour + this.Duration)
                              || (a.StartHour + a.Duration) < this.StartHour))
                        {
                            throw new ServiceException("El instructor ya tiene otra actividad asignada en el horario sugerido");
                        }
                    }
                }
            }
            this.Instructor = i;
        }

        public void AddRoom(Room room)
        {
            foreach (Activity a in room.Activities)
            {
                if (!(a.StartDate > this.FinishDate || a.FinishDate < this.StartDate))
                {
                    if ((a.ActivityDays & this.ActivityDays) != 0)
                    {
                        if (!(a.StartHour > (this.StartHour + this.Duration)
                              || (a.StartHour + a.Duration) < this.StartHour))
                        {
                            throw new ServiceException("La sala ya tiene otra actividad asignada en el horario sugerido");
                        }
                    }
                }
            }
            this.Rooms.Add(room);
        }

        public double GetPriceForUser(Gym g, User u)
        {
            double price = this.Price;
            if (u.Retired) { price = price - (this.Price * g.DiscountRetired / 100); }
            if (g.ZipCode == u.ZipCode) { price = price - (this.Price * g.DiscountLocal / 100); }
            return price;
        }
    }
}
