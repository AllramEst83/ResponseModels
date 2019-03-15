using System;

namespace ResponseModels.DatabaseModels
{
    public class Owner
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adress Adress { get; set; }
        public long SSN { get; set; }
    }
}