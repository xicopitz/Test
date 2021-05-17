using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class DBValues : Data.Contracts.CRM
    {
        public Task<bool> ValueTwo()
        {
            // Call nother services ( ex: Database)
            return Task.FromResult(true);
        }
    }
}
