using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections{

    internal class MemoryStockRepository : IStockRepository{

        private long currentID = 0;

        public long CurrentID { get { return currentID; } set { currentID = value; } }

        Dictionary<long, Stock> Database = new Dictionary<long, Stock>();

        public long NextId(){

            CurrentID++;
            return CurrentID;
        }

        public void SaveStock(Stock Stock){

            Database.Add(CurrentID, Stock);
            NextId();
        }

        public Stock LoadStock(long id){

            if (Database.ContainsKey(id)){
                return Database[id];
            }
            else{
                return null;
            }
        }

        public ICollection FindAllStocks(){

            return Database;
        }

        public void Clear(){

            Database.Clear();
        }
    }
}