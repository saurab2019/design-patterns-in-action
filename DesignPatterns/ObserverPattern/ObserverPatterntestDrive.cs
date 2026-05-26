namespace DesignPatterns.ObserverPattern
{
    public class ObserverPatternTestDrive : TestDrive
    {
        public static void test()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay display1 = new CurrentConditionDisplay(weatherData);
            TemperatureDisplay display2 = new TemperatureDisplay(weatherData);
            Console.WriteLine();
            weatherData.setMeasurements(1, 2, 3);
            weatherData.registerObserver(display1);
            weatherData.setMeasurements(10, 20, 31);
            Console.WriteLine();
            weatherData.registerObserver(display2);
            weatherData.registerObserver(display1);
            weatherData.setMeasurements(11,21,34);
            weatherData.setMeasurements(32,20,45);
            weatherData.setMeasurements(56,11,11);
            weatherData.setMeasurements(28,45,78);
            Console.WriteLine();
            weatherData.removeObserver(display1);
            weatherData.setMeasurements(14,12,13);
            Console.WriteLine();
        }
    }
}