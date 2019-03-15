using System;
using System.Collections.Generic;

namespace ResponseModels.DatabaseModels
{
    public class Clinic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}