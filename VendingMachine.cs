using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    public class VendingMachine
    {
        private Cash cash = new Cash();
        private Drink cola = new Drink("cola", 3.49);
        private Drink fanta = new Drink("fanta", 3.89);
        private Drink sprite = new Drink("sprite", 3.29);
        private Drink monster = new Drink("monster", 6.69);
        private Drink lipton = new Drink("lipton", 4.20);
        private Drink water = new Drink("water", 2.80);

        public void addCash (double cash)
        {
            this.cash.addCash(cash);
        }

        public void subtractCash (double cash)
        {
            this.cash.subtractCash(cash);
        }

        public double getCash()
        {
            return this.cash.amount;
        }

        public double getColaPrice()
        {
            return cola.price;
        }
        public double getFantaPrice()
        {
            return fanta.price;
        }
        public double getSpritePrice()
        {
            return sprite.price;
        }
        public double getMonsterPrice()
        {
            return monster.price;
        }
        public double getWaterPrice()
        {
            return water.price;
        }
        public double getLiptonPrice()
        {
            return lipton.price;
        }

        public Drink buyDrink(Drink drink)
        {
            cash.subtractCash(drink.price);
            //dodaj drinka do DB
            //sprawdz czy starczy siana jesli nie wyswietl komunikat
            return drink;
        }

        public void drinkOne() { }
        public void drinkAll() { }


    }
}
