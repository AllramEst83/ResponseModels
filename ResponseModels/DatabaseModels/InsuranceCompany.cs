using System;

namespace ResponseModels.DatabaseModels
{
    public class InsuranceCompany
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Adress Adress { get; set; }
    }
}