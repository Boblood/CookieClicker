using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CCModel.Model
{
    public interface IBuildingManager
    {
        int BasePrice { get; }
        BigInteger CurrentPrice { get; }
        int NumberOfBuildings { get; set; }

        BigInteger GetNewPrice(int currentNumberOfBuildings, int desiredNumberOfBuildings);
        void Buy(int number);
        void Sell(int number);
        void SellAll();
    }
}
