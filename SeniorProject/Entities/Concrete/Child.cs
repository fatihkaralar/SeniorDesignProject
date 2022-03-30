using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Child : IEntity
    {
        public int ChildId { get; set; }

        public int ParentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentityNumber { get; set; }

        public string Image { get; set; }

        public DateTime DateOfBirth { get; set; }



    }
}
