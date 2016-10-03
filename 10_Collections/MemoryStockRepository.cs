﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections{

    internal class MemoryStockRepository : IStockRepository{

        private long CurrentID = 0;

        Dictionary<long, Stock> Database = new Dictionary<long, Stock>();

        public long NextId(){

            this.CurrentID++;
            return CurrentID;
        }

        public void SaveStock(Stock Stock){

            Database.Add(CurrentID, Stock);
            this.NextId();
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