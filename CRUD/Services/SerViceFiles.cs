using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using CRUD.IServices;
using CRUD.models;

namespace CRUD.Services
{
    public class SerViceFiles : IServiceFile

    {
        private FileStream _fs;
        private BinaryFormatter _bf;


        public string SaveFile<T>(string path, T lssttemp)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lssttemp);
                _fs.Close();
                return "Ghi File Thanh Công";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _fs.Close();
                return "Ghi file thất bại";
            }
        }

        public List<T> OpenFile<T>(string path)
        {
            //try
            //{
                List<T> lstAccount = new List<T>();
            _fs = new FileStream(path, FileMode.OpenOrCreate);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);
            lstAccount = (List<T>)data;
            _fs.Close();
            return lstAccount;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    _fs.Close();
            //    return null;
            //}
        }
    }

}