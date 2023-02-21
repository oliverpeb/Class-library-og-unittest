using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_library_og_unittest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Class_library_og_unittest;

namespace Class_library_og_unittest.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car = new Car { id = 5, model = "123456", price = 4, licenseplate = "12345" };
        private Car carmodelnameshort = new Car { id = 1, model = "123", price = 0, licenseplate = "12345" };
        private Car carpriceislessthanzero = new Car { id = 2, model = "12345", price = -5, licenseplate = "12345" };
        private Car carlicenseplateistooshort = new Car { id = 3, model = "12345", price = 2, licenseplate = "12" };



        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentException>(() => carmodelnameshort.ValidateModel());
        }
        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carpriceislessthanzero.ValidatePrice());
        }
        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carlicenseplateistooshort.ValidateLicensePlate());
        }


    }
}