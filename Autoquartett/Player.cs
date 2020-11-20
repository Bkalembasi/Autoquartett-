using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoquartett
{
    class Player
    {
        private LinkedList<object> cars = new LinkedList<object>();
        private int wins;
        private bool inGame;

        public void SetCar(LinkedList<object> cars)
        {
            this.cars = cars;
        }
        public void AddCar(object car)
        {
            cars.AddLast(car);
        }
        public int GetCarCount()
        {
            return System.Convert.ToInt32(cars.LongCount());
        }
        public void AddWin()
        {
            wins = wins + 1;
        }
        public void SetInGame(bool inGame)
        {
            this.inGame = inGame;
        }
        public void RemoveCard()
        {
            cars.Remove(0);
        }
        public object GetCard()
        {
            return cars.First();
        }
        public bool IsInGame()
        {
            return inGame;
        }
    }
}
