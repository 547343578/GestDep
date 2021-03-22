// PARA ENTREGAR A LOS ALUMNOS
//
// Hay que copiarlo al proyecto GestDepLib en la carpeta correspondiente
///

using GestDep.Entities;
using GestDep.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Services
{
    public class GestDepService : IGestDepService
    {
        private readonly IDAL dal;
        public Gym gym;
        public CityHall cityHall; 

        public GestDepService(IDAL dal)
        {
            this.dal = dal;
            this.gym = new Gym();
            this.cityHall = new CityHall();
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void AddCityHall(CityHall city)
        {
            dal.Insert<CityHall>(city);
            dal.Commit();
        }


        public void AddGym(Gym gym)
        {
            dal.Insert<Gym>(gym);
            dal.Commit();
        }

        public void AddRoom(Room room)
        {
            dal.Insert<Room>(room);
            dal.Commit();
        }

        public void AddInstructor(Instructor m)
        {
            dal.Insert<Instructor>(m);
            dal.Commit();
        }

        public void AddActivity(Activity a)
        {
            dal.Insert<Activity>(a);
            dal.Commit();
        }

        public void AddUser(User u)
        {
            foreach (User user in dal.GetAll<User>()) {

                if (u.Id == user.Id) throw new ServiceException("Usuario ya existente.");
            
            }
            dal.Insert<User>(u);
            dal.Commit();
        }

        public void AddEnrollment(Enrollment e)
        {
            dal.Insert<Enrollment>(e);
            dal.Commit();
        }

        public CityHall FindCityHallByName(string name)
        {
            foreach (CityHall c in dal.GetAll<CityHall>())
            {
                if (c.Name == name) { return c; }
            }
            return null;
        }

        public Instructor FindInstructorById(string id)
        {
            foreach (Instructor i in dal.GetAll<Instructor>())
            {
                if (i.Id == id) { return i; }
            }
            return null;
        }

        public User FindUserById(string id)
        {
            foreach (User u in dal.GetAll<User>())
            {
                if (u.Id == id) { return u; }
            }
            return null;
        }
        public Gym FindGymByName(string name)
        {
            foreach (Gym g in dal.GetAll<Gym>())
            {
                if (g.Name == name) { return g; }
            }
            return null;
        }
        public Activity FindActivityByName(string name)
        {
            foreach (Activity a in dal.GetAll<Activity>())
            {
                if (a.Description == name) { return a; }
            }
            return null;
        }

        public ICollection<Enrollment> GetAllEnrollments()
        {
            ICollection<Enrollment> lista = new List<Enrollment>();
            foreach (Enrollment e in dal.GetAll<Enrollment>())
            {
                lista.Add(e);
            }
            return lista;
        }
        public ICollection<Gym> GetAllGyms()
        {
            ICollection<Gym> lista = new List<Gym>();
            foreach (Gym g in dal.GetAll<Gym>())
            {
                lista.Add(g);
            }
            return lista;
        }
        public ICollection<Instructor> GetAllInstructors()
        {
            ICollection<Instructor> lista = new List<Instructor>();
            foreach (Instructor i in dal.GetAll<Instructor>())
            {
                lista.Add(i);
            }
            return lista;
        }
        public ICollection<CityHall> GetAllCityHalls()
        {
            ICollection<CityHall> lista = new List<CityHall>();
            foreach (CityHall c in dal.GetAll<CityHall>())
            {
                lista.Add(c);
            }
            return lista;
        }
        public ICollection<Activity> GetAllActivities()
        {
            ICollection<Activity> lista = new List<Activity>();
            foreach (Activity a in dal.GetAll<Activity>())
            {
                lista.Add(a);
            }
            return lista;
        }
 

        public void AddNewActivity(Days days, String description, TimeSpan duration, DateTime finishDate,
            int maximumEnrollments, int minimumEnrollments, double price, DateTime startDate, DateTime startHour, ICollection<int> rooms)
        {
            if (finishDate < startDate)
            {
                throw new ServiceException("Fecha finalización no válida");
            }
            if (startDate < DateTime.Now || finishDate < DateTime.Now)
                throw new ServiceException("Fecha inicio no válida");
            if (duration < TimeSpan.Zero)
                throw new ServiceException("Duración incorrecta");
            if (rooms.Any<int>())
                throw new ServiceException("No hay salas");
            if (price < 0)
                throw new ServiceException("Precio no apto");
            if (minimumEnrollments < 0 || maximumEnrollments < 0 || minimumEnrollments > maximumEnrollments)
                throw new ServiceException("Número de inscripciones incorrecto");
            if (days == Days.None)
                throw new ServiceException("Dias incorrectos");

            Activity a = new Activity(days, description, duration, finishDate, maximumEnrollments, minimumEnrollments, price, startDate, startHour);


            foreach (int sala in rooms)
            {

                if (gym.AvailableRoom(sala, days, duration, startDate, finishDate, startHour))
                {

                    GetRoomById(sala).Activities.Add(a);
                    gym.Activities.Add(a);
                }
                break;

            }
            this.Commit();
        }
        public ICollection<int> GetListAvailableRoomsIds(Days days, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour)
        {
            if (finishDate < startDate)
            {
                throw new ServiceException("Fecha de finalización no válida");
            }
            if (startDate < DateTime.Now && finishDate < DateTime.Now)
            {
                throw new ServiceException("Fecha inicio no válida");
            }
            if (duration < TimeSpan.Zero)
            {
                throw new ServiceException("Duración incorrecta");
            }
            if (days == Days.None)
            {
                throw new ServiceException("Dias incorrectos");
            }

            ICollection<int> availableRoomsIds = new List<int>();
            foreach (Room r in dal.GetAll<Room>()) // ¿    gym.Rooms      ????????????
            {
                bool res = true;
                foreach (Activity a in r.Activities)
                {
                    if (!(a.StartDate > finishDate || a.FinishDate < startDate))
                    {
                        if ((a.ActivityDays & days) != 0)
                        {
                            if (!(a.StartHour > (startHour + duration)
                                  || (a.StartHour + a.Duration) < startHour))
                            {
                                res = false;
                                break;
                            }
                        }
                    }
                }
                if (res) { availableRoomsIds.Add(r.Id); }
            }
            return availableRoomsIds;
        }

        public Activity FindActivityById(int id)
        {
            foreach (Activity a in dal.GetAll<Activity>())
            {
                if (a.Id == id) { return a; }
            }
            return null;
        }

        public void AssignInstructorToActivity(int activityId, string instructorId)
        {
            if (activityId < 0)
            {
                throw new ServiceException("Identificador de actividad negativo");
            }
            if (FindActivityById(activityId) == null)
            {
                throw new ServiceException("El identificador de actividad no se corresponde con ninguna actividad");
            }
            if (FindInstructorById(instructorId) == null)
            {
                throw new ServiceException("El identificador de instructor no se corresponde con ningún instructor");
            }
            Activity a = FindActivityById(activityId);
            Instructor i = FindInstructorById(instructorId);
            foreach (Activity act_existente in i.Activities)  // Se comprueba que la actividad no se solape con las que ya tenia el instructor
            {
                if (!(act_existente.StartDate > a.FinishDate || act_existente.FinishDate < a.StartDate))
                {
                    if ((act_existente.ActivityDays & a.ActivityDays) != 0)
                    {
                        if (!(act_existente.StartHour > (a.StartHour + a.Duration)
                              || (act_existente.StartHour + act_existente.Duration) < a.StartHour))
                        {
                            throw new ServiceException("El instructor no se encuentra disponible para impartir la actividad");
                        }
                    }
                }
            }
            a.SetInstructor(i);
            i.Activities.Add(a);
            dal.Commit();
        }
        public void GetActivityDataFromId(int activityId, out Days activityDays, out string description, out TimeSpan duration,
               out DateTime finishDate, out int maximumEnrollments, out int minimumEnrollments, out double price, out DateTime startDate,
               out DateTime startHour, out ICollection<int> enrollmentIds, out string instructorId, out ICollection<int> roomIds)
        {
            if (activityId < 0)
            {
                throw new ServiceException("Identificador de actividad negativo");
            }
            if (FindActivityById(activityId) == null)
            {
                throw new ServiceException("El identificador de actividad no se corresponde con ninguna actividad");
            }
            Activity a = FindActivityById(activityId);
            activityDays = a.ActivityDays;
            description = a.Description;
            duration = a.Duration;
            finishDate = a.FinishDate;
            maximumEnrollments = a.MaximumEnrollments;
            minimumEnrollments = a.MinimumEnrollments;
            price = a.Price;
            startDate = a.StartDate;
            startHour = a.StartHour;
            enrollmentIds = new List<int>();
            foreach (Enrollment e in a.Enrollments)
            {
                enrollmentIds.Add(e.Id);
            }
            instructorId = a.Instructor.Id;
            roomIds = new List<int>();
            foreach (Room r in a.Rooms)
            {
                roomIds.Add(r.Id);
            }
        }
        public ICollection<int> GetAllActivitiesIds()
        {
            ICollection<int> activitiesIds = new List<int>();
            foreach (Activity a in dal.GetAll<Activity>())
            {
                activitiesIds.Add(a.Id);
            }
            return activitiesIds;
        }
        public ICollection<string> GetAvailableInstructorsIds(Days days, TimeSpan duration, DateTime finishDate,
                DateTime startDate, DateTime startHour)
        {
            if (days == Days.None)
            {
                throw new ServiceException("Los días especificados no son válidos");
            }
            if (duration.CompareTo(new TimeSpan(0, 0, 0)) < 0)
            {
                throw new ServiceException("La duración no puede ser negativa");
            }
            if (finishDate < startDate)
            {
                throw new ServiceException("La fecha de fin de la actividad no puede ser anterior a la de inicio");
            }
            if (finishDate < DateTime.Today && startDate < DateTime.Today)
            {
                throw new ServiceException("Las fechas de inicio y fin de la actividad ya han pasado");
            }
            ICollection<string> instructorsIds = new List<string>();
            foreach (Instructor i in dal.GetAll<Instructor>())
            {
                bool res = true;
                foreach (Activity a in i.Activities)
                {
                    if (!(a.StartDate > finishDate || a.FinishDate < startDate))
                    {
                        if ((a.ActivityDays & days) != 0)
                        {
                            if (!(a.StartHour > (startHour + duration)
                                  || (a.StartHour + a.Duration) < startHour))
                            {
                                res = false;
                                break;
                            }
                        }
                    }
                }
                if (res) { instructorsIds.Add(i.Id); }
            }
            return instructorsIds;
        }
        public void GetInstructorDataFromId(string instructorId, out string instructorAddress, out string instructorIBAN,
                out string instructorName, out int instructorZipcode, out string instructorSsn,
                out ICollection<int> instructorActivitiesIds)
        {
            if (FindInstructorById(instructorId) == null)
            {
                throw new ServiceException("El identificador de instructor no se corresponde con ningún instructor");
            }
            Instructor i = FindInstructorById(instructorId);
            instructorAddress = i.Address;
            instructorIBAN = i.IBAN;
            instructorName = i.Name;
            instructorZipcode = i.ZipCode;
            instructorSsn = i.Ssn;
            instructorActivitiesIds = new List<int>();
            foreach (Activity a in i.Activities)
            {
                instructorActivitiesIds.Add(a.Id);
            }
        }
        public void GetRoomDataFromId(int RoomId, out int roomNumber, out ICollection<int> roomActivityIds) {

            if (RoomId < 0) throw new ServiceException("Sala invalida");
            if (RoomId >= dal.GetAll<Room>().Last().Id + 1) throw new ServiceException("Sala no apta");
            Room r = GetRoomById(RoomId);
            roomNumber = r.Id;
            roomActivityIds = new List<int>();
            foreach (Activity a in r.Activities)
            {
                roomActivityIds.Add(a.Id);
            }

        }

        public void AddNewUser(string address, string iban, string id, string name, int zipCode, DateTime birthDate, bool retired) {
            if (address == "")
            {
                throw new ServiceException("La dirección no puede estar vacía");
            }

            if (iban == "")
            {
                throw new ServiceException("El IBAN no puede estar vacío");
            }

            if (id == "")
            {
                throw new ServiceException("El id no puede estar vación");
            }

            if (id.Length > 9)
            {
                throw new ServiceException("El id tiene mas de 9 digitos");
            }

            if (id.Length < 9)
            {
                throw new ServiceException("El id tiene menos de 9 digitos");
            }

            if (!Char.IsLetter(id.Last<char>()))
            {
                throw new ServiceException("El id no es válido.Falta la letra");
            }

            if (name == "")
            {
                throw new ServiceException("El nombre no puede estar vacío");
            }

            if (zipCode == 0)
            {
                throw new ServiceException("El zipCode no puede ser igual a 0");
            }

            if (zipCode < 0)
            {
                throw new ServiceException("El zipCode no puede estar vacío");
            }

            if (birthDate > DateTime.Now)
            {
                throw new ServiceException("Fecha de nacimiento incorrecta");
            }

            if (cityHall.HayUsuario(id))
            {
                throw new ServiceException("El usuario ya existe");
            }

            //hcityHall.AddUser(new User(address, iban, id, name, zipCode, birthDate, retired));
            this.Commit();

        }
        public Room GetRoomById(int id)
        {
            foreach (Room r in dal.GetAll<Room>())
            {
                if (r.Id == id) { return r; }
            }
            return null;
        }

        public int EnrollUserInActivity(int id, string userId)
        {
            if (id < 0)
            {
                throw new ServiceException("El id no puede ser negativo");
            }
            if (userId == "")
            {
                throw new ServiceException("El id no puede estar vación");
            }

            if (userId.Length > 9)
            {
                throw new ServiceException("El id tiene mas de 9 digitos");
            }

            if (userId.Length < 9)
            {
                throw new ServiceException("El id tiene menos de 9 digitos");
            }

            if (!Char.IsLetter(userId.Last<char>()))
            {
                throw new ServiceException("El id no es válido.Falta la letra");
            }
            if (FindActivityById(id) == null)
            {
                throw new ServiceException("La actividad no existe");
            }
            if (FindInstructorById(userId) == null)
            {
                throw new ServiceException("El usuario no existe");
            }
            if (userId == "")
            {
                throw new ServiceException("El id del usuario no puede ser vacio");
            }
            Instructor i = FindInstructorById(userId);
            if (i != null)
            {
                foreach (Activity a in i.Activities)
                {
                    if (a.Id == id)
                    {
                        throw new ServiceException("El usuario ya esta incribido en la actividad");
                    }
                }
            }
            foreach (Enrollment e in dal.GetAll<Enrollment>())
            {
                if (e.Activity.Id == id)
                {
                    if (e.User.Id == userId)
                    {
                        return e.Id;
                    }
                }
            }

            return -1;

        }

        public ICollection<int> GetAllRunningOrFutureActivitiesIds()
        {
            ICollection<int> activitiesId = new List<int>();
            foreach (Activity a in dal.GetAll<Activity>())
            {
                activitiesId.Add(a.Id);
            }
            if (activitiesId == null)
            {
                throw new ServiceException("No hay actividades");
            }
            return activitiesId;
        }
        public void GetEnrollmentDataFromIds(int activityId, int enrollmentId, out DateTime? cancelacionDate, out DateTime enrollmentDate,
           out DateTime? returnedFirstCuotaIfCancelledActivity, out ICollection<int> paymentId, out string userId)
        {
            if (activityId < 0)
            {
                throw new ServiceException("El id de la actividad no puede ser negativo");
            }
            if (FindActivityById(activityId) == null)
            {
                throw new ServiceException("La actividad no existe");
            }
            bool check = false;
            Enrollment res = new Enrollment();
            foreach (Enrollment e in dal.GetAll<Enrollment>())
            {
                if (e.Id == enrollmentId)
                {
                    check = true;
                    res = e;
                }
            }
            if (check == false)
            {
                throw new ServiceException("El enrollment no existe");
            }
            if (enrollmentId < 0)
            {
                throw new ServiceException("El id de enrollment no puede ser negativo");
            }

            cancelacionDate = res.CancellationDate;
            enrollmentDate = res.EnrollmentDate;
            returnedFirstCuotaIfCancelledActivity = res.ReturnedFirstCuotaIfCancelledActivity;
            userId = res.User.Id;
            paymentId = new List<int>();
            foreach (Payment p in dal.GetAll<Payment>())
            {
                paymentId.Add(p.Id);
            }


        }
        public void GetPaymentDataFromId(int id, out DateTime date, out string description, out double quantity)
        {
            if (id < 0)
            {
                throw new ServiceException("El id de payment no puede ser negativo");
            }
            bool check = false;
            Payment res = new Payment();
            foreach (Payment p in dal.GetAll<Payment>())
            {
                if (p.Id == id)
                {
                    check = true;
                    res = p;
                }
            }
            if (check == false)
            {
                throw new ServiceException("El payment no existe");
            }
            date = res.Date;
            description = res.Description;
            quantity = res.Quantity;

        }
        public void GetUserDataFromId(string userId, out string userAddress, out string userIBAN, out string userName, out int userZipcode,
           out DateTime userBirthDate, out bool retired, out ICollection<int> enrollmentIds)
        {
            if (userId == "")
            {
                throw new ServiceException("El id no puede estar vación");
            }

            if (userId.Length > 9)
            {
                throw new ServiceException("El id tiene mas de 9 digitos");
            }

            if (userId.Length < 9)
            {
                throw new ServiceException("El id tiene menos de 9 digitos");
            }

            if (!Char.IsLetter(userId.Last<char>()))
            {
                throw new ServiceException("El id no es válido.Falta la letra");
            }
            bool check = false;
            User res = new User();
            foreach (User u in dal.GetAll<User>())
            {
                if (u.Id == userId)
                {
                    check = true;
                    res = u;
                }
            }
            if (check == false)
            {
                throw new ServiceException("El usuario no existe");
            }
            ICollection<int> enrollmentIdsDeUser = new List<int>();
            foreach (Enrollment e in res.Enrollments)
            {
                enrollmentIdsDeUser.Add(e.Id);
            }
            userAddress = res.Address;
            userIBAN = res.IBAN;
            userName = res.Name;
            userBirthDate = res.BirthDate;
            userZipcode = res.ZipCode;
            retired = res.Retired;
            enrollmentIds = enrollmentIdsDeUser;

        }
        public double GetUserDataNotInActivityAndFirstQuota(int activityId, string userId, out string address, out string iban,
                out string name, out int zipCode, out DateTime birthDate, out bool retired, out ICollection<int> enrollmentIds)
        {
            if (userId == "")
            {
                throw new ServiceException("El id no puede estar vación");
            }

            if (userId.Length > 9)
            {
                throw new ServiceException("El id tiene mas de 9 digitos");
            }

            if (userId.Length < 9)
            {
                throw new ServiceException("El id tiene menos de 9 digitos");
            }

            if (!Char.IsLetter(userId.Last<char>()))
            {
                throw new ServiceException("El id no es válido.Falta la letra");
            }
            bool check = false;
            User user1 = new User();
            foreach (User u in dal.GetAll<User>())
            {
                if (u.Id == userId)
                {
                    check = true;
                    user1 = u;
                }
            }
            if (check == false)
            {
                throw new ServiceException("El usuario no existe");
            }
            foreach (Enrollment e in user1.Enrollments)
            {
                if (e.Activity.Id == activityId)
                {
                    throw new ServiceException("El usuario ya esta en la actividad");
                }
            }
            address = user1.Address;
            iban = user1.IBAN;
            name = user1.Name;
            zipCode = user1.ZipCode;
            birthDate = user1.BirthDate;
            retired = user1.Retired;
            ICollection<int> enrollmentIdsDeUser = new List<int>();
            foreach (Enrollment e in user1.Enrollments)
            {
                enrollmentIdsDeUser.Add(e.Id);
            }
            enrollmentIds = enrollmentIdsDeUser;
            Gym gym1 = new Gym();
            Activity activity1 = new Activity();
            foreach (Gym g in dal.GetAll<Gym>())
            {
                foreach (Activity a in g.Activities)
                {
                    if (a.Id == activityId)
                    {
                        gym1 = g;
                        activity1 = a;
                    }
                }
            }
            if (retired && (gym1.ZipCode == user1.ZipCode))
            {
                return activity1.Price - (activity1.Price * gym1.DiscountRetired / 100)
                                       - (activity1.Price * gym1.DiscountLocal / 100);
            }
            if (retired) { return activity1.Price - (activity1.Price * gym1.DiscountRetired / 100); }
            if (gym1.ZipCode == user1.ZipCode) { return activity1.Price - (activity1.Price * gym1.DiscountLocal / 100); }

            return activity1.Price;
        }
        public Gym FindGymById(int id)
        {
            foreach (Gym g in dal.GetAll<Gym>())
            {
                if (g.Id == id) { return g; }
            }
            return null;
        }

        public void GetGymData(out int gymId, out DateTime closingHour, out int discountLocal,
            out int discountRetired, out double freeUserPrice, out String name, out DateTime openingHour,
            out int zipCode, out ICollection<int> activityIds, out ICollection<int> roomIds)
        {
            if (dal.GetAll<Gym>().Count() == 0)
            {
                throw new ServiceException("No hay gimasios disponibles");
            }
            Gym g = dal.GetAll<Gym>().First();
            gymId = g.Id;
            closingHour = g.ClosingHour;
            discountLocal = g.DiscountLocal;
            discountRetired = g.DiscountRetired;
            freeUserPrice = g.FreeUserPrice;
            name = g.Name;
            openingHour = g.OpeningHour;
            zipCode = g.ZipCode;
            activityIds = new List<int>();
            foreach (Activity a in g.Activities)
            {
                activityIds.Add(a.Id);
            }
            roomIds = new List<int>();
            foreach (Room r in g.Rooms)
            {
                roomIds.Add(r.Id);
            }
        }
        public Dictionary<DateTime, int> GetListAvailableRoomsPerWeek(DateTime startOfWeek)
        {
            if (startOfWeek.DayOfWeek != DayOfWeek.Monday)
            {
                throw new ServiceException("El día no es lunes");
            }
            DateTime inicio = new DateTime(startOfWeek.Year, startOfWeek.Month, startOfWeek.Day, this.gym.OpeningHour.Hour, 0, 0);
            int turnos = ((this.gym.ClosingHour.Hour - this.gym.OpeningHour.Hour) * 60 / 45) * 7;
            Dictionary<DateTime, int> horarioDisponibilidad = new Dictionary<DateTime, int>();

            while (inicio.Hour < (this.gym.ClosingHour.Hour))
            {
                DateTime franjaHoraria = inicio;
                for (int i = 1; i < 7; i++)
                {
                    int numeroSalasDisponibles = this.gym.Rooms.Count();
                    Days diaActual;
                    switch (i)
                    {
                        case 1: diaActual = Days.Mon; break;
                        case 2: diaActual = Days.Tue; break;
                        case 3: diaActual = Days.Wed; break;
                        case 4: diaActual = Days.Thu; break;
                        case 5: diaActual = Days.Fri; break;
                        case 6: diaActual = Days.Sat; break;
                        default: diaActual = Days.Mon; break;
                    }
                    foreach (Room r in this.gym.Rooms)
                    {
                        foreach (Activity a in r.Activities)
                        {
                            if (franjaHoraria > a.StartDate && franjaHoraria < a.FinishDate)
                            {
                                if ((a.ActivityDays & diaActual) != 0)
                                {
                                    if (franjaHoraria.TimeOfDay >= a.StartHour.TimeOfDay
                                          && franjaHoraria.TimeOfDay < (a.StartHour.TimeOfDay + a.Duration))
                                    {
                                        numeroSalasDisponibles--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    horarioDisponibilidad.Add(franjaHoraria, numeroSalasDisponibles);
                    franjaHoraria = franjaHoraria.AddDays(1);
                }
                inicio = inicio.AddMinutes(45);
            }
            return horarioDisponibilidad;
        }

        public bool AvailableRoom(int numSala, Days days, TimeSpan duration, DateTime startDate, DateTime finishDate, DateTime startHour)
        {

            return true;
        }
    }
}