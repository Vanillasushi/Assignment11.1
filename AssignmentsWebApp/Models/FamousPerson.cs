using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentsWebApp.Models
{
    public class FamousPerson
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public ICollection<Accomplishment> Accomplishments { get; set; }
    }
}
