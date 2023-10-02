namespace Registration.Models
{
    public class Student
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public List<Address> Addresses { get; set; }

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
