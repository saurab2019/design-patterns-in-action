using DesignPatterns.ObserverPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private  float _temperature;
        private  float _pressure;
        private  float _humidity;

        private List<IObserver> observerList;

        public WeatherData()
        {
            observerList = new List<IObserver>();
            _temperature = 0.0f;
            _pressure = 0.0f;
            _humidity = 0.0f;
        }

        public void registerObserver(IObserver observer)
        {
            if(!observerList.Contains(observer))
            {
                observerList.Add(observer);
                Console.WriteLine("Observer registration successful");
            }
            else
            {
                Console.WriteLine("Observer is already registered");
            }
        }

        public void removeObserver(IObserver observer)
        {
            if(observerList.Contains(observer))
            {
                observerList.Remove(observer);
                Console.WriteLine("Observer is successfully unregistered.");
            }
            else
            {
                Console.WriteLine("Observer is already unregistered.");
            }
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observerList)
            {
                observer.update();
            }
            Console.WriteLine("Observers are successfully notified");
        }

        public float getTemperature()
        {
            return _temperature;
        }
        public float getPressure() 
        {
            return _pressure;
        }

        public float getHumidity()
        {
            return _humidity;
        }

        public void setMeasurements(float temp, float pressure, float humidity)
        {
            _temperature = temp;
            _pressure = pressure;
            _humidity = humidity;

            measurementChanged();
        }

        public void measurementChanged()
        {
            notifyObservers();
        }
    }
}
