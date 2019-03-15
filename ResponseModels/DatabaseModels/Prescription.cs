using System;

namespace ResponseModels.DatabaseModels
{
    public class Prescription
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}