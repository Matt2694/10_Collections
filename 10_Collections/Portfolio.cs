using System;
using System.Collections.Generic;

namespace _10_Collections{

    internal class Portfolio : IAsset{

        private List<IAsset> stocks;

        public Portfolio(){

            stocks = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks){

            this.stocks = stocks;
        }

        internal double GetTotalValue(){

            double total = 0;
            foreach (IAsset instance in stocks){
                total += instance.GetValue();
            }
            return total;
        }

        internal void AddAsset(IAsset classInstance){

            stocks.Add(classInstance);
        }

        internal IList<IAsset> GetAssets(){

            return stocks.AsReadOnly();
        }

        public static double TotalValue(IAsset[] stocks){

            double total = 0;
            foreach (IAsset instance in stocks){
                total += instance.GetValue();
            }
            return total;
        }

        internal IAsset GetAssetByName(string name){

            IAsset element = null;
            foreach(IAsset asset in stocks){
                if (asset.GetName().Equals(name)){
                    element = asset;
                }
            }
            return element;
        }

        internal IList<IAsset> GetAssetsSortedByName(){

            stocks.Sort(new StockNameComparator());
            return stocks;
        }

        internal IList<IAsset> GetAssetsSortedByValue(){

            stocks.Sort(new StockValueComparator());
            return stocks;
        }

        public string GetName(){

            throw new NotImplementedException();
        }

        public double GetValue(){

            throw new NotImplementedException();
        }
    }
}