using System;

namespace ResponseModels.DatabaseModels
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeOfDoctorWrapper TypeOfDoctorWrapper { get; set; }
    }
}