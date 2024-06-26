﻿namespace Ex2;

public class RefrigeratedContainer : Container
{

    private string _product;
    public double Temperature;
    
    public RefrigeratedContainer(double height, double weightContainer, double depth, double maxWeight, string productType, double containerTemperature) 
        : base('C', height, weightContainer, depth, maxWeight)
    {
        _product = productType;
        Temperature = containerTemperature;
    }

    public void Load(String product, double weight, double temperature)
    {
        if (_product.Equals(product) && Temperature >= temperature)
            base.Load(weight);
        else
            Console.WriteLine("this product can't be load on this container");
    }

    public override string ToString()
    {
        return base.ToString() + "\n"
            + "Product type: " + _product + "\n"
            + "temperature in container: " + Temperature;
    }
}