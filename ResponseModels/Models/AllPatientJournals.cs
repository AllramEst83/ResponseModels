using ResponseModels.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.Models
{
    public class AllPatientJournals
    {
        public AllPatientJournals()
        {

        }
        public AllPatientJournals(List<PatientJournal> _patientJournals)
        {
            PatentJournals = _patientJournals;
        }

        public List<PatientJournal> PatentJournals { get; set; }
        public bool IsNull
        {
            get
            {
                if (PatentJournals == null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
