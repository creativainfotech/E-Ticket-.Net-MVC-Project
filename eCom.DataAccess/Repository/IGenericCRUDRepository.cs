using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccess.Repository
{
        
    public interface IGenericCRUDRepository<T> where T : class
    {
        IEnumerable<T> GetModelList();
        T GetModelById(int id);
        T GetModelDetails(int id);
        void CreateModel(T obj);
        bool UpdateModel(int id);
        bool DeleteModel(int id);
        bool ModelExists(int id);




    }
}
