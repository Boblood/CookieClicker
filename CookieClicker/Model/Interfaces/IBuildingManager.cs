using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker.Model.Interfaces
{
    public interface IBuildingManager
    {
        int BasePrice { get; }
        double CurrentPrice { get; }
        int NumberOfBuildings { get; }

        double GetNewPrice(int currentNumberOfBuildings, int desiredNumberOfBuildings);
        void Buy(int number);
        void Sell(int number);
        void SellAll();
    }
}
