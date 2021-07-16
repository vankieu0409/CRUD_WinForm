using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using CRUD.IServices;
using CRUD.models;

namespace CRUD.Services
{
    public class ServicesAcounts : IServicesAccount
    {
        private List<Accounts> _lstAccount;

        public ServicesAcounts()
        {
            _lstAccount = new List<Accounts>();
        }
        public string addAccount(Accounts accounts)
        {
            if (accounts == null) return "Không được Null";
            _lstAccount.Add(accounts);
            return " thêm thành Công";
        }

        public string edit(Accounts accounts)
        {
            int index = _lstAccount.FindIndex(c => c.Id == accounts.Id);
            if (index == -1) return " Không thấy đối tượng";
            _lstAccount[index] = accounts;
            return "Sửa Thành Công";
        }

        public string remove(int id)
        {
            if (id < 0) return "Xóa Không thành công";
            _lstAccount.RemoveAt(_lstAccount.FindIndex(c => c.Id == id));
            return " Xóa Thánh Công";
        }

        public Accounts findAccounts(int id)
        {
            if (id < 0) return null;
            return _lstAccount.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Accounts> getlst()
        {
            return _lstAccount;
        }

        public List<Accounts> getlstAcCountByAccounts(string acc)
        {
            return _lstAccount.Where(c => c.Acc.StartsWith(acc)).ToList();
        }

        public void fillDataFormtoService(List<Accounts> listAccounts)
        {
            _lstAccount = listAccounts;
        }

        public string[] getYearofBirth()
        {
            string[] temps = new string[2021 - 1900];
            int temp = 1900;
            for (int i = 0; i < temps.Length; i++)
            {
                temps[i] = temp.ToString();
                temp++;

            }

            return temps;
        }
    }
}