using System;

namespace ResponseModels.DatabaseModels
{
    public class Insurance
    {
        public Guid Id { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
        public TypeOfInsuranceWrapper TypeOfInsuranceWrapper { get; set; }
    }
}