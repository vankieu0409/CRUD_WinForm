namespace CRUD.IServices
{
    public interface ICheck
    {
        bool CheckAcc(string acc);

        bool CheckYearofBirth(string year);
        bool checkMK(string Pass);
        bool checkNull(string text);
    }
}