using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace twowayapproach
{
    public partial class UniveristyDetails
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public int? NumberofStaff { get; set; }
    }
}
