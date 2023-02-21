using System;


namespace Class_library_og_unittest
    
{
    public class Car
    {
        //Test
        public int id { get; set; }
        public string model { get; set; }
        public int price { get; set; } 
        public string licenseplate { get; set; }

        public void Validateid()
        {
            if (id == null)
                throw new ArgumentException("id cannot be null");
        }

        public void ValidateModel()
        {
            
            if (model.Length < 4)
                throw new ArgumentException("The model name cannot be less than 4");

        }

        public void ValidatePrice()
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException("the price of the car cannot be less than 1" + price);
        }

        public void ValidateLicensePlate()
        {
            if (licenseplate.Length <= 2)
                throw new ArgumentOutOfRangeException("The licenseplate value must be between 2 and 7");
            if (licenseplate.Length >= 7)
                throw new ArgumentOutOfRangeException("The licenseplate value must be between 2 and 7");
        }

        public void Validate ()
        {
            Validateid();
            ValidateModel();
            ValidatePrice();
            ValidateLicensePlate();
        }
    }
}