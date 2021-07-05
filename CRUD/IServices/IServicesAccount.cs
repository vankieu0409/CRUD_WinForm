using System.Collections.Generic;
using CRUD.models;
using CRUD.Services;

namespace CRUD.IServices
{
    public interface IServicesAccount
    {
        string addAccount(Accounts accounts);//chuwsch năng thêm
        string edit(Accounts accounts);//chuwsch năng thêm
        string remove( int id);// xóa
        Accounts findAccounts(int id);//tim 1 dối tượng
        List<Accounts> getlst();// phươn thức lấy danh sach
        List<Accounts> getlstAcCountByAccounts(string acc);
        // Phươn gthuws đỏ dữ liệu rừ file vè Service
        void fillDataFormtoService(List<Accounts> listAccounts);
        string[] getYearofBirth();//PHương thức laasdanh sach Năm Sinh


    }

    
}