namespace TheTheoryFarmAPI.Models.Domain
{
    public class Theory
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string TheoryBody { get; set; }

        public DateTime TheoryDate { get; set; } // google this
    }
}
