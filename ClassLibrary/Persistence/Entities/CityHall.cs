using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class CityHall
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        //Associations
        public virtual ICollection<Person> People
        {
            get;
            set;
        }

        public virtual ICollection<Payment> Payments
        {
            get;
            set;
        }

        public virtual ICollection<Gym> Gyms
        {
            get;
            set;
        }
    }
}
