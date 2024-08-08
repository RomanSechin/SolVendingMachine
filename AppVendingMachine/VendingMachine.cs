namespace AppVendingMachine
{
    class VendingMachine { 
        public virtual string Item { get; }
        protected virtual bool CheckAmount(decimal money) {
            return false;
        }

        public string Dispence(decimal money) {
            if (CheckAmount(money)) { return Item; }
            else return "Please, enter the right amount";
        }
    }
}
