using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models.Cheese
{
    public class CheeseData
    {
        private static List<Cheese> cheeses = new List<Cheese>();
        private static int nextId = 1;

        public static List<Cheese> GetAll()
        {
            List<Cheese> cheeseList = new List<Cheese>();
            cheeseList.AddRange(cheeses);
            return cheeseList;
        }

        public static Cheese GetById(int cheeseId)
        {
            return cheeses.SingleOrDefault(chs => chs.Id == cheeseId);
        }

        public static void Add(Cheese newCheese)
        {
            newCheese.Id = nextId++;
            cheeses.Add(newCheese);
        }

        public static void Remove(int cheeseId)
        {
            //cheeses.RemoveAll(chs => chs.Id == cheeseId);
            Cheese cheeseToRemove = GetById(cheeseId);
            cheeses.Remove(cheeseToRemove);
        }

        public static void Remove(Cheese cheese)
        {
            Remove(cheese.Id);
        }

        public static void Update(Cheese cheeseToUpdate)
        {

        }

        public static void AddOrUpdate(Cheese cheese)
        {

        }
    }
}
