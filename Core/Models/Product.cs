namespace Core.Models
{
    public class Product
    {
        public string _name;
        public double _price;
        public string _isbn;
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
        public Product(string name, double price, string isbn)
        {
            _name = name;
            _price = price;
            _isbn = isbn;
        }
    }
}
