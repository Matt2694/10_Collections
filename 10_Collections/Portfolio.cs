using System;
using System.Collections.Generic;

namespace _10_Collections{

    public class Portfolio : IAsset{

        private List<IAsset> assets;

        public Portfolio(){

            assets = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks){

            this.assets = stocks;
        }

        public double GetTotalValue(){

            double total = 0;
            foreach (IAsset instance in assets){
                total += instance.GetValue();
            }
            return total;
        }

        public void AddAsset(IAsset classInstance){

            assets.Add(classInstance);
        }

        public IList<IAsset> GetAssets(){

            return assets.AsReadOnly();
        }

        public static double TotalValue(IAsset[] stocks){

            double total = 0;
            foreach (IAsset instance in stocks){
                total += instance.GetValue();
            }
            return total;
        }

        public IAsset GetAssetByName(string name){

            IAsset element = null;
            foreach(IAsset asset in assets){
                if (asset.GetName().Equals(name)){
                    element = asset;
                }
            }
            return element;
        }

        public IList<IAsset> GetAssetsSortedByName(){

            assets.Sort(new StockNameComparator());
            return assets;
        }

        internal IList<IAsset> GetAssetsSortedByValue(){

            assets.Sort(new StockValueComparator());
            return assets;
        }

        public string GetName(){

            throw new NotImplementedException();
        }

        public double GetValue(){

            throw new NotImplementedException();
        }
    }
}