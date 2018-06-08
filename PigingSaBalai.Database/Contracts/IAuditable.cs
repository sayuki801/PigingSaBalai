using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Database.Contracts
{
    public interface IAuditable
    {
        string CreatedBy { get; set; }
        string LastUpdatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? LastUpdatedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
