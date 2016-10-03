using System;
using System.Collections.Generic;

namespace _10_Collections{

    internal class StockNameComparator : IComparer <IAsset>{

        public int Compare(IAsset instance1, IAsset instance2){

            return instance1.GetName().CompareTo(instance2.GetName());
        }
    }
}