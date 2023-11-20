namespace Lab5App.Application
{
    public class RiskEvent
    {
        public string? Tag { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }
        public List<double> RiskProbability { get; set; }
        public double ER { get; set; }
        public double LRER { get; set; }
        public double RiskMoney { get; set; }
        public double AdditionalCost { get; set; }
        public double FullPrice { get; set; }
        public double VRER { get; set; }
        public Priority Priority { get; set; }
        public string SelectedSolution { get; set; }
    }
    public enum Priority
    {
        Low,
        Medium,
        High,
        OutOfRange
    }
}
