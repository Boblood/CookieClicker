using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using CCModel.Model;

namespace CCModel.Controller
{
    public class CurserManager : IBuildingManager
    {
        public int BasePrice
        {
            get
            {
                return 15;
            }
        }

        public BigInteger CurrentPrice
        {
            get
            {
                return GetNewPrice(NumberOfBuildings, NumberOfBuildings + 1);
            }
        }

        public int NumberOfBuildings { get; set; }

        public void Buy(int number)
        {
            throw new NotImplementedException();
        }

        public BigInteger GetNewPrice(int currentNumberOfBuildings, int desiredNumberOfBuildings)
        {
            return (BigInteger)Math.Ceiling((BasePrice * (Math.Pow(1.15, desiredNumberOfBuildings) - Math.Pow(1.15, currentNumberOfBuildings))) / .15);
        }

        public void Sell(int number)
        {
            throw new NotImplementedException();
        }

        public void SellAll()
        {
            Sell(NumberOfBuildings);
        }
    }
}
