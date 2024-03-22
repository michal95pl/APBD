namespace Ex2;

public class RefrigeratedContainer : Container
{

    private string _product;
    private double _temperature;
    
    public RefrigeratedContainer() : base('C')
    {
        
    }

    void Load(String product, double weight, double temperature)
    {
        if (_product.Equals(product) && _temperature >= temperature)
            base.Load(weight);
    }
}