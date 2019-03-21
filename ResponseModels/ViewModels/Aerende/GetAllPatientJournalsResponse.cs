using ResponseModels.DatabaseModels;
using ResponseModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseModels.ViewModels.Aerende
{
  public  class GetAllPatientJournalsResponse : ResponseModelBase
    {
        public GetAllPatientJournalsResponse()
        {

        }

        public GetAllPatientJournalsResponse(
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
        public GetAllPatientJournalsResponse(

            List<PatientJournal> _patientJournals,

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
            PatientJournals = _patientJournals;
        }

        public List<PatientJournal> PatientJournals { get; set; }
    }
}
