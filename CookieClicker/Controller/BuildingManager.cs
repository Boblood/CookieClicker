using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker.Controller
{
    public class BuildingManager
    {
        private int _numberOfBuildings;

        public int NumberOfBuildings
        {
            get { return _numberOfBuildings; }
            set { _numberOfBuildings = value; }
        }

    }
}
