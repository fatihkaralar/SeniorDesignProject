using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Expert : IEntity
    {
        public int ExpertId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string IdentityNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CV { get; set; }

        public string PhoneNumber { get; set; }

    }
}
