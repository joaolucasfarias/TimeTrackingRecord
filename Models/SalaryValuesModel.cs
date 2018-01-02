namespace Models
{
    public class SalaryValuesModel
    {
        public decimal Month { get; set; }
        public decimal Hour { get; set; }
        public decimal Overtime { get; set; }
        public decimal FullOvertime => Hour * 2;
    }
}
