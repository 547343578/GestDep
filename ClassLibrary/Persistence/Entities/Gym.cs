using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Gym
    {
        public DateTime ClosingHour
        {
            get;
            set;
        }
        public int DiscountLocal
        {
            get;
            set;
        }

        public int DiscountRetired
        {
            get;
            set;
        }
        public double FreeUserPrice
        {
            get;
            set;
        }
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
        public DateTime OpeningHour
        {
            get;
            set;
        }
        public int ZipCode
        {
            get;
            set;
        }

        //Associations
        public virtual ICollection<Room> Rooms
        {
            get;
            set;
        }
        public virtual ICollection<Activity> Activities
        {
            get;
            set;
        }
    }
}
