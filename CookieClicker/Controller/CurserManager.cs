using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookieClicker.Model;
using CookieClicker.Model.Interfaces;

namespace CookieClicker.Controller
{
    public class CurserManager : IBuildingManager
    {
        public double BasePrice
        {
            get
            {
                return 10;
            }
        }

        public double CurrentPrice
        {
            get
            {
                return GetNewPrice();
            }
        }

        public int NumberOfBuildings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Buy1()
        {
            throw new NotImplementedException();
        }

        public void Buy10()
        {
            throw new NotImplementedException();
        }

        public void Buy100()
        {
            throw new NotImplementedException();
        }

        public double GetNewPrice()
        {
            return Math.Ceiling(BasePrice * Math.Pow(1.15, NumberOfBuildings));
        }

        public void Sell1()
        {
            throw new NotImplementedException();
        }

        public void Sell10()
        {
            throw new NotImplementedException();
        }

        public void Sell100()
        {
            throw new NotImplementedException();
        }

        public void SellAll()
        {
            throw new NotImplementedException();
        }
    }
}
