using System;

namespace _10_Collections{

    public class Stock : IAsset{

        public double NumShares { get; set; }
        public double PricePerShare { get; set; }
        public string Symbol { get; set; }
        public long Id { get; set; }

        public Stock() { }

        public Stock(string symbol, double pricePerShare, double numShares){

            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
            Id = 0;
        }

        public double GetValue(){

            return PricePerShare * NumShares;
        }

        public override string ToString(){

            return "Stock[symbol=" + Symbol + ",pricePerShare="
                    + PricePerShare + ",numShares=" + NumShares + "]";
        }

        public override int GetHashCode(){

            return base.GetHashCode();
        }

        public override bool Equals(object obj){

            Stock Compareobject = (Stock)obj;
            return ((Compareobject.Symbol == Symbol) &&
                    (Compareobject.PricePerShare == PricePerShare) &&
                    (Compareobject.NumShares == NumShares));
        }

        public string GetName(){

            return Symbol;
        }
    }
}