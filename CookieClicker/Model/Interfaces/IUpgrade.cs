using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker.Model.Interfaces
{
    public interface IUpgrade
    {
        string Name { get; }
        int ID { get; }

        void CPSAffecter();
        void OtherAffecter();
    }
}
