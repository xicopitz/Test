using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Services
{
    public class Values : Data.Contracts.Values
    {
        public Task<bool> ValueOne()
        {
            //Call CRM API here
            return Task.FromResult(true);
        }
    }
}
