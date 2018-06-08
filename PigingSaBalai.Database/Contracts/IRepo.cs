using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Database.Contracts
{
    public interface IRepo : IDisposable
    {
        bool SaveAll();

        Task<bool> SaveAllAsync();
    }
}
