namespace POOConcepts
{
    public class BaseCommissionEmployee : CommissionEmpoyee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Base:C2}",15}";
        }
    }
}
