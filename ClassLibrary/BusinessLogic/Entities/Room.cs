using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Room
    {

            public Room()
            {
                Activities = new List<Activity>();
            }

            public Room(int number) : this()
            {
                Number = number;
                this.Activities = new List<Activity>();
            }
        }

    }

