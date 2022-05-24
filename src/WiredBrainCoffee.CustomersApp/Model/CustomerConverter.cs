namespace WiredBrainCoffee.CustomersApp.Model
{
    public static class CustomerConverter
    {
        public static Customer CreateCustomerFromString(string input)
        {
            var values = input.Split(',');
            return new Customer
            {
                FirstName = values[0],
                LastName = values[1],
                IsDeveloper = bool.Parse(values[2]),
            };
        }
    }
}