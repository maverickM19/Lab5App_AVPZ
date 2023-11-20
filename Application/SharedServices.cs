using static System.Net.WebRequestMethods;

namespace Lab5App.Application
{
    public class SharedServices
    {
        public List<RiskEvent> RiskEvents { get; set; }
        public List<RiskSource> RiskSources { get; set; }
        public List<Solution> Solutions { get; set; }
        public List<double> startingMoney {  get; set; }
        public List<double> finalMoney { get; set; }
        public enum Priority
        {
            Low,
            Medium,
            High,
            OutOfRange
        }
    }
}
