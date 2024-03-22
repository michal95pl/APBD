namespace Ex2;

public abstract class Container
{
    private double _weightPayload;
    private double _high;
    private double _weight;
    private double _depth;
    private string _serial;
    protected double _maxWeight;

    private static int _lastSerialNumber = 0;
    
    protected Container(char type)
    {
        this._serial = "KON-" +
                             type + "-" +
                             _lastSerialNumber++;
        
        Console.WriteLine(this._serial);
    }

    public double Unload()
    {
        double temp = this._weightPayload;
        this._weightPayload = 0;
        
        return temp;
    }

    public void Load(double peyload)
    {
        if (peyload > _maxWeight)
            throw new OverfillException("weight is out of limit");
        
        this._weightPayload = peyload;
    }

}