using System;

namespace ResponseModels.DatabaseModels
{
    public class KindOfIllness
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IllnessSeverityWrapper IllnessSeverity { get; set; }
    }
}