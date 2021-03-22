﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Activity
    {
        public Days ActivityDays
        {
            get;
            set;
        }

        public bool Cancelled
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public TimeSpan Duration
        {
            get;
            set;
        }

        public DateTime FinishDate
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public int MaximumEnrollments
        {
            get;
            set;
        }

        public int MinimumEnrollments
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime StartHour
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

        public virtual ICollection<Enrollment> Enrollments
        {
            get;
            set;
        }

        public virtual Instructor Instructor
        {

            get;
            set;
        }

    }
}
