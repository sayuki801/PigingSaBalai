using MyProject1.Database.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Database
{
    public class Repo : IRepo
    {
        #region Default

        private DataContext _db;

        public Repo(DataContext db)
        {
            _db = db;
        }

        public static Repo Create()
        {
            return new Repo(new DataContext());
        }

        public bool SaveAll()
        {
            return _db.SaveChanges() > 0;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
        #endregion
    }
}
