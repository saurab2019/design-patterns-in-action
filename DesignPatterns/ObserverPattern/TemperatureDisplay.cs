using DesignPatterns.ObserverPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class TemperatureDisplay : IDisplay
    {
        private float temperature;
        WeatherData weather;

        public TemperatureDisplay(WeatherData weather)
        {
            this.weather = weather;
            temperature = weather.getTemperature();
            display();
        }

        public void update()
        {
            temperature = weather.getTemperature();
            display();
        }

        public void display()
        {
            Console.WriteLine("Current Temperature: ");
            Console.WriteLine($"Temp: {temperature} degree");
            Console.WriteLine();
        }
    }
}
