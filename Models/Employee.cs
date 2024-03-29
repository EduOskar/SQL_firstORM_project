﻿using System;
using System.Collections.Generic;

namespace Labb3_databas_AhlingsSchoolProject.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Classes = new HashSet<Class>();
        }

        public int EmployeeId { get; set; }
        public string Title { get; set; } = null!;
        public int FkClassId { get; set; }
        public int? FkPersonIdEmployee { get; set; }

        public virtual PersonalInformation? FkPersonIdEmployeeNavigation { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
