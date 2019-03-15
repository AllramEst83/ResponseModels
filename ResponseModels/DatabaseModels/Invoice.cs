using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResponseModels.DatabaseModels
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public double TotalSum { get; set; }
        public double Discount { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public Guid PatientJournalRelationalId { get; set; }
        //public PatientJournal PatientJournal { get; set; }
    }
}
