using DesignPatterns.ObserverPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class CurrentConditionDisplay : IDisplay
    {
        private float temperature;
        private float pressure;
        private float humidity;
        WeatherData weather;

        public CurrentConditionDisplay(WeatherData weather)
        {
            this.weather = weather;
            temperature = weather.getTemperature();
            pressure = weather.getPressure();
            humidity = weather.getHumidity();
            display();
        }

        public void update()
        {
            temperature = weather.getTemperature();
            pressure = weather.getPressure();
            humidity = weather.getHumidity();
            display();
        }

        public void display()
        {
            Console.WriteLine("Current Conditions: ");
            Console.WriteLine($"Temp: {temperature} degrees");
            Console.WriteLine($"Humidity: {humidity} ");
            Console.WriteLine($"pressure: {pressure} ");
            Console.WriteLine();
        }

    }
}
