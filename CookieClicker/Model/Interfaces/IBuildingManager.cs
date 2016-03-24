using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker.Model.Interfaces
{
    public interface IBuildingManager
    {
        double BasePrice { get; }
        double CurrentPrice { get; }
        int NumberOfBuildings { get; }

        double GetNewPrice();
        void Buy1();
        void Buy10();
        void Buy100();
        void Sell1();
        void Sell10();
        void Sell100();
        void SellAll();
    }
}
