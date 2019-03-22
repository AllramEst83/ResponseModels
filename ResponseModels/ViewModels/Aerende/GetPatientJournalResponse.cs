using ResponseModels.DatabaseModels;
using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels.Aerende
{
   public class GetPatientJournalResponse : ResponseModelBase
    {
        public GetPatientJournalResponse()
        {

        }
        public GetPatientJournalResponse(
            int _statusCode,
            string _error,
            string _description,
            string _code
            ) : base(
                _statusCode,
                _error,
                _description,
                _code
                )
        {

        }
        public GetPatientJournalResponse(
            
            PatientJournal _patientJournal,

            int _statusCode,
            string _error,
            string _description,
            string _code
            ) : base(
                _statusCode,
                _error,
                _description,
                _code
                )
        {
            PatientJournal = _patientJournal;
        }

        public PatientJournal PatientJournal { get; set; }
    }
}
