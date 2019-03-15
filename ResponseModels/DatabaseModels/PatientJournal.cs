using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.DatabaseModels
{
   public class PatientJournal
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AnimalSSN { get; set; }
        public Insurance Insurance { get; set; }
        public Clinic Clinic { get; set; }
        public List<MedicalService> MedicalServices { get; set; }
        public List<Owner> Owners { get; set; }
    }
}
