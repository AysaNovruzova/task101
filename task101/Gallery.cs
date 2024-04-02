using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task101
{
    internal class Gallery
    {
        private Car[] cars;
        private int carCount;
        private int maxSize;

        public Gallery(int maxSize)
        {
            this.maxSize = maxSize;
            cars = new Car[maxSize];
            carCount = 0;
        }

        public void AddCar(Car car)
        {
            if (carCount < maxSize)
            {
                cars[carCount] = car;
                carCount++;
            }
            else
            {
                Console.WriteLine("Qaleria doludur. actomobil elave etmek mumkun deyil.");
            }
        }

        public void ShowAllCars()
        {
            for (int i = 0; i < carCount; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"ID: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, Car Code: {car.CarCode}");
            }
        }

        public Car[] GetAllCars()
        {
            Car[] allCars = new Car[carCount];
            Array.Copy(cars, allCars, carCount);
            return allCars;
        }

        public Car FindCarById(int id)
        {
            for (int i = 0; i < carCount; i++)
            {
                Car car = cars[i];
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            for (int i = 0; i < carCount; i++)
            {
                Car car = cars[i];
                if (car.CarCode == carCode.ToUpper())
                {
                    return car;
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] result = new Car[maxSize];
            int resultIndex = 0;
            for (int i = 0; i < carCount; i++)
            {
                Car car = cars[i];
                if (car.Speed >= minSpeed && car.Speed <= maxSpeed)
                {
                    result[resultIndex] = car;
                    resultIndex++;
                }
            }
            Array.Resize(ref result, resultIndex);
            return result;
        }
    }
}