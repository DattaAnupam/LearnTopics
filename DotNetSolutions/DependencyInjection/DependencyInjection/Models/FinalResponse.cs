namespace DependencyInjection.Models
{
    [Serializable]
    public class FinalResponse
    {
        public Guid AddSingleTonID_1 { get; set; }
        public Guid AddSingleTonID_2 { get; set; }

        public Guid AddScopedID_1 { get; set; }
        public Guid AddScopedID_2 { get; set; }

        public Guid AddTransientID_1 { get; set; }
        public Guid AddTransientID_2 { get; set; }
    }
}
