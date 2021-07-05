using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CRUD.IServices
{
    public interface IServiceFile
    {
        //PHương thức Lưu File
        string SaveFile<T>(string path, T lssttemp);
        List<T> OpenFile<T>(string path);
    }
}