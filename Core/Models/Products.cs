namespace Core.Models
{
    public class Products
    {
        private string _name;
        private double _price;
        private string _isbn;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string ISBN
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
            }
        }
        public Products(string name, double price, string isbn)
        {
            Name = name;
            Price = price;
            ISBN = isbn;
        }
    }
}
