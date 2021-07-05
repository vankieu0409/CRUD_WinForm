namespace CRUD.models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Acc { get; set; }
        public string Pass { get; set; }
        public int Sex { get; set; }
        public int YearofBirth { get; set; }

        public bool Status { get; set; }
    }
}