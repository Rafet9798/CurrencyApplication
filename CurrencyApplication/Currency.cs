using System;
using System.Collections.Generic;

namespace CurrencyApplication
{
    class Currency
    {
        public static Dictionary<string, decimal> currencies =new Dictionary<string, decimal>()
        {
            {
                "Dollar",1M
            },
            {
                "Manat",1.7M
            },
            {
                "Tl",5.7M
            },
            {
                "Euro",0.9M
            }
        };
    
        public static Dictionary<string,decimal> Convert(decimal inputValue,string inputCurrency)
        {
            Dictionary<string, decimal> displayCurrency = new Dictionary<string, decimal>();

            decimal n =inputValue/currencies[inputCurrency];

            foreach (var item in currencies)
            {
                if(item.Key!=inputCurrency)
                displayCurrency.Add(item.Key, n * item.Value);
            }
            return displayCurrency;
        }
    }
}
