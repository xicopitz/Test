using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Managers
{
    public class ValuesManager : Contracts.IValues
    {
        private readonly Data.Contracts.Values values;
        private readonly Data.Contracts.CRM crm;

        public ValuesManager(Data.Contracts.Values values, Data.Contracts.CRM crm)
        {
            this.values = values;
            this.crm = crm;
        }

        public async Task<bool> CallServices()
        {
            bool t = await values.ValueOne();
            bool tt = await crm.ValueTwo();
            return true;
        }
    }
}
