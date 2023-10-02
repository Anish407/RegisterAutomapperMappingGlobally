using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Dtos
{
    public class Student
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public List<Address> Addresses { get; set; }

        public Orders Orders { get; set; }

    }

    public class Address
    {
        public int PinCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
    }

    public class Orders
    {
        public List<int> OrderIds { get; set; }
    }
}
