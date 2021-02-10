using System;

namespace dark_place_game
{
    
    public class Hero
    {
        public CurrencyHolder Purse {
            get;
            private set;
        }

        public string Name {
            get;
            private set;
        }

        public Hero(string name) {
            Purse = new CurrencyHolder("gold", 9999, 60);
            Name = name;
        }
    }
}
