using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestDep.Services;

namespace GestDep.Entities
{
    public partial class Gym
    {
        public Gym()
        {
            Rooms = new List<Room>();
            Activities = new List<Activity>();
        }
        public Gym(DateTime closingHour, int discountLocal, int discountRetired,
                    double freeUserPrice, string name, DateTime openingHour, int zipCode) : this()
        {
            ClosingHour = closingHour;
            DiscountLocal = discountLocal;
            DiscountRetired = discountRetired;
            FreeUserPrice = freeUserPrice;
            //Id is managed by EE
            Name = name;
            OpeningHour = openingHour;
            ZipCode = zipCode;
        }

        public void AddRoom(Room room)
        {
            this.Rooms.Add(room);
        }

        public Room FindRoom(int n)
        {
            foreach (Room r in this.Rooms)
            {
                if (r.Number == n) { return r; }
            }
            return null;
        }

        public void AddActivity(Activity a)
        {
            if (a.FinishDate < a.StartDate)
            {
                throw new ServiceException("La fecha de fin de una actividad no puede ser" + 
                    " posterior a la de inicio");
            }
            if ( a.StartDate < DateTime.Today.AddDays(1))
            {
                throw new ServiceException("La fecha de inicio de una actividad no puede ser" +
                    " anterior al dia de hoy");
            }
            bool disponibilidad = false;
            foreach (Room sala in this.Rooms)
            {
                bool res = true;
                foreach (Activity act_existente in sala.Activities)
                {
                    if (!(act_existente.StartDate > a.FinishDate || act_existente.FinishDate < a.StartDate))
                    {
                        if ((act_existente.ActivityDays & a.ActivityDays) != 0)
                        {
                            if (!(act_existente.StartHour > (a.StartHour + a.Duration)
                                  || (act_existente.StartHour + act_existente.Duration) < a.StartHour))
                            {
                                res = false;
                                break;
                            }
                        }
                    }
                }
                if (res)
                {
                    disponibilidad = true;
                    break;
                }
            }
            if (!disponibilidad)
            {
                throw new ServiceException("Alguna de las salas no se encuentra disponible");
            }
            this.Activities.Add(a);
        }

        public Activity FindActivityByName(string name)
        {
            foreach (Activity a in this.Activities)
            {
                if (a.Description == name) { return a; }
            }
            return null;
        }

        public int GetFreeRooms(DateTime tiempoInicio, Days dia)
        {
            int res = this.Rooms.Count;
            foreach (Room r in this.Rooms)
            {
                foreach (Activity a in r.Activities)
                {
                    if (tiempoInicio.Date >= a.StartDate && tiempoInicio.Date < a.FinishDate)
                    {
                        if((dia & a.ActivityDays) != 0)
                        {
                            if (tiempoInicio.TimeOfDay >= a.StartHour.TimeOfDay
                                  && tiempoInicio.TimeOfDay < (a.StartHour.TimeOfDay + a.Duration))
                            {
                                res--;
                                break;
                            }
                        }
                    }
                }
            }
            return res;
        }
        public Room GetRoomById(int id)
        {
            if (id < 0) throw new ServiceException("Identificador incorrecto");
            foreach (Room r in Rooms)
            {
                if (r.Id == id) return r;

            }
            return null;
        }
        public bool AvailableRoom(int numSala, Days days, TimeSpan duration, DateTime startDate, DateTime finishDate, DateTime startHour)
        {

            return false;
        }
    }
}
