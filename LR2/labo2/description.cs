namespace labo2
{
    public class description
    {
        private string name_;
        private double price_;
        private phone group_;

        public description(string name, int price, phone group)
        {
            name_ = name;
            price_ = price;
            group_ = group;
        }

        public description()
        {
        }

        public string GetName()
        {
            return name_;
        }

        public double GetPrice()
        {
            return price_;
        }

        public phone GetGroup()
        {
            return group_;
        }
    }
}
