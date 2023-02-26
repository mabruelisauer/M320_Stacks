using System.Security.Cryptography.X509Certificates;

namespace M320_SmartHome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            
            var wettersensor = new Wettersensor();
            var wohnung = new Wohnung(wettersensor);
            
            wohnung.SetTemperaturvorgabe("BadWC", 23);
            wohnung.SetTemperaturvorgabe("Kueche", 22);
            wohnung.SetTemperaturvorgabe("Schlafen", 19);
            wohnung.SetTemperaturvorgabe("Wohnen", 22);
            wohnung.SetTemperaturvorgabe("Wintergarten", 20);

            wohnung.SetPersonenImZimmer("Kueche", true);
            wohnung.SetPersonenImZimmer("Schlafen", false);
            wohnung.SetPersonenImZimmer("Wohnen", true);
            wohnung.SetPersonenImZimmer("Wintergarten", true);

            //Act
            wettersensor.GetWetterdatenFake(20, 80, true);

            //Assert
            
    }
    }
}