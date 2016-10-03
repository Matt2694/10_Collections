using System;
using System.Collections.Generic;

namespace _10_Collections{

    internal class StockValueComparator : IComparer <IAsset>{

        public int Compare(IAsset instance1, IAsset instance2){

            return instance2.GetValue().CompareTo(instance1.GetValue());
        }
        
    }
}