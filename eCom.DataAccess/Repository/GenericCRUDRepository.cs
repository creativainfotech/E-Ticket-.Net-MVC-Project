using eCom.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccess.Repository
{
    public class GenericCRUDRepository<T> : IGenericCRUDRepository<T> where T : class
    {
        private  ApplicationDBContext _db;
        private DbSet<T> modelName;

        public GenericCRUDRepository(ApplicationDBContext db)
        {

            this._db = db;
            modelName=_db.Set<T>();
        }
        public void CreateModel(T obj)
        {

            modelName.Add(obj);
        }

        public bool DeleteModel(int id)
        {
            T obj = modelName.Find(id);

            if (obj != null)
            {
                modelName.Remove(obj);
                return true;
            }
            else return false;

        }

        public T GetModelById(int id)
        {
            return modelName.Find(id);
        }

        public T GetModelDetails(int id)
        {
            return modelName.Find(id);
        }

        public IEnumerable<T> GetModelList()
        {
            return modelName;
        }

        public bool ModelExists(int id)
        {
            if (modelName.Find(id)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateModel(int id)
        {
            T obj = modelName.Find(id);

            if (obj != null)
            {
                modelName.Update(obj);
                return true;
            }
            else return false;
        }

       
    }
}
