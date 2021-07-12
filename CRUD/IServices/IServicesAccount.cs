using System.Collections.Generic;
using CRUD.models;
using CRUD.Services;

namespace CRUD.IServices
{
    public interface IServicesAccount
    {
        string addAccount(Accounts accounts);//chức năng thêm
        string edit(Accounts accounts);//chức năng thêm
        string remove( int id);// xóa
        Accounts findAccounts(int id);//tim 1 dối tượng
        List<Accounts> getlst();// phươn thức lấy danh sach
        List<Accounts> getlstAcCountByAccounts(string acc);
        // Phương thức đổ dữ liệu từ file về Service
        void fillDataFormtoService(List<Accounts> listAccounts);
        string[] getYearofBirth();//PHương thức Lấy Danh Sách Năm Sinh


    }

    
}