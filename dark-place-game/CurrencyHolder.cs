using System;

namespace dark_place_game
{

    [System.Serializable]
    /// Une Exeption Custom
    public class CapacityReachedException : Exception {}
    public class CantWithDrawMoreThanCurrentAmountExeption : Exception {
        public CantWithDrawMoreThanCurrentAmountExeption(string message) { }
    }
    public class CurrencyHolderArgumentsException : ArgumentException {
        public CurrencyHolderArgumentsException(string message) { }
    }
    public class StoreCurrencyArgumentsException : ArgumentException {
        public StoreCurrencyArgumentsException(string message) { }
    }

    public class WithdrawCurrencyArgumentsException : ArgumentException
    {
        public WithdrawCurrencyArgumentsException(string message) { }
    }
    public class CantCreateCurrencyHolderWithNegativeAmount
    {

    }

    public class CurrencyHolder
    {
        public static readonly string CURRENCY_DEFAULT_NAME = "Unnamed";

        /// Le nom de la monnaie
        public string CurrencyName {
            get { return currencyName; }
            private set {
                currencyName = value;
            }
        }
        // Le champs interne de la property
        private string currencyName = CURRENCY_DEFAULT_NAME;

        /// Le montant actuel
        public int CurrentAmount {
            get { return currentAmount; }
            private set {
                currentAmount = value;
            }
        }
        // Le champs interne de la property
        private int currentAmount = 0;

        /// La contenance maximum du conteneur
        public int Capacity {
            get { return capacity; }
            private set {
                capacity = value;
            }
        }
        // Le champs interne de la property
        private int capacity = 0;

        public CurrencyHolder(string name, int capacity, int amount) {
            if (amount < 0)
            {
                throw new CurrencyHolderArgumentsException("Currency holder Initial amount cannot be negative");

            } else if (capacity < 1)
            {
                throw new CurrencyHolderArgumentsException("Currency holder capacity cannot be less than 1");
            } else if (name == null || name == "")
            {
                throw new CurrencyHolderArgumentsException("Currency holder name canot be empty");
            } else if (name.Length < 4 || name.Length > 10)
            {
                throw new CurrencyHolderArgumentsException("Can't Create Currency Holder With Name Less Than 4 Or Greater Than 10 Characters");

            } else if (name.StartsWith('a') || name.StartsWith('A'))
            {
                throw new CurrencyHolderArgumentsException("Name of CurrencyHolder cannot start with A");

            } else if (capacity < amount) 
            {
                throw new CurrencyHolderArgumentsException("Amount of CurrencyHolder created cannot be less than it's capacity");

            }
            else
            {
                Capacity = capacity;
                CurrencyName = name;
                CurrentAmount = amount;
            }
        }

        public bool IsEmpty() {
            if(CurrentAmount == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsFull() {
            if (CurrentAmount == Capacity)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Store(int amount) {
            CurrentAmount += amount;
            if(CurrentAmount > Capacity)
            {
                CurrentAmount -= amount;
                throw new CapacityReachedException();
            }
            if(amount < 0 || amount == 0)
            {
                throw new StoreCurrencyArgumentsException("Amount stored cannot be negative or zero");
            }
        }

        public void Withdraw(int amount) {
            if(amount > CurrentAmount)
            {
                throw new CantWithDrawMoreThanCurrentAmountExeption("Amount insufficient for required withdrawal");
            } else
            {
                if(amount == 0 || amount < 0)
                {
                    throw new WithdrawCurrencyArgumentsException("Amount to withdraw cannot be neagtive or zero");
                } else
                {
                    CurrentAmount -= amount;
                }
            }
        }
    }
}
