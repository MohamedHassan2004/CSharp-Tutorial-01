using System;
public class StockPriceChangedEventArgs : EventArgs
{
    public string StockSymbol { get; set; }
    public decimal OldPrice { get; set; }
    public decimal NewPrice { get; set; }
}
public class Stock
{
    private decimal _price;
    public string Symbol { get; }
    public decimal Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                decimal oldPrice = _price;
                _price = value;
                OnPriceChanged(oldPrice, _price);
            }
        }
    }

    public Stock(string symbol, decimal initialPrice)
    {
        Symbol = symbol;
        _price = initialPrice;
    }

    // Define the event using EventHandler<T>
    public event EventHandler<StockPriceChangedEventArgs> PriceChanged;

    // Method to raise the event
    protected virtual void OnPriceChanged(decimal oldPrice, decimal newPrice)
    {
        PriceChanged?.Invoke(this, new StockPriceChangedEventArgs
        {
            StockSymbol = Symbol,
            OldPrice = oldPrice,
            NewPrice = newPrice
        });
    }
}

public class Trader
{
    public string Name { get; }

    public Trader(string name)
    {
        Name = name;
    }

    // Event handler method (the method will be called when the event happen)
    public void OnStockPriceChanged(object sender, StockPriceChangedEventArgs e)
    {
        Console.WriteLine($"{Name} notified of {e.StockSymbol} price change: {e.OldPrice:C} -> {e.NewPrice:C}");
    }
}

class BestPractice
{
    static void Main()
    {
        // Create stock
        Stock appleStock = new Stock("AAPL", 150.00m);

        // Create traders
        Trader trader1 = new Trader("Alice");
        Trader trader2 = new Trader("Bob");

        // Subscribe to the stock price change event
        appleStock.PriceChanged += trader1.OnStockPriceChanged;
        appleStock.PriceChanged += trader2.OnStockPriceChanged;

        // Simulate stock price changes
        appleStock.Price = 155.00m;
        appleStock.Price = 160.00m;

        // Unsubscribe a trader
        appleStock.PriceChanged -= trader1.OnStockPriceChanged;

        // Simulate another stock price change
        appleStock.Price = 165.00m;
    }
}
