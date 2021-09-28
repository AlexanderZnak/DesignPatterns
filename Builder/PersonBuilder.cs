namespace Builder
{
    public class PersonBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _height;
        private int _weight;

        public Person Build() => new (_firstName, _lastName, _height, _weight);

        public PersonBuilder FirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }
        
        public PersonBuilder LastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }
        
        public PersonBuilder Height(int height)
        {
            _height = height;
            return this;
        }
        
        public PersonBuilder Weight(int weight)
        {
            _weight = weight;
            return this;
        }
    }
}