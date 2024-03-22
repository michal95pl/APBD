namespace Ex2;

public abstract class Container
{
    private double _weightPayload;
    private double _height;
    private double _weightContainer;
    private double _depth;
    public string Serial;
    protected double MaxWeight;

    private static int _lastSerialNumber = 0;
    
    protected Container(char type, double height, double weightContainer, double depth, double maxWeight)
    {
        Serial = "KON-" +
                 type + "-" +
                 _lastSerialNumber++;

        _height = height;
        _weightContainer = weightContainer;
        _depth = depth;
        MaxWeight = maxWeight;
        
        _weightPayload = 0;
    }

    protected double Unload()
    {
        double temp = _weightPayload;
        _weightPayload = 0;
        
        return temp;
    }

    protected void Load(double payload)
    {
        if (payload > MaxWeight)
            throw new OverfillException("weight is out of limit");
        
        _weightPayload = payload;
    }

    public override string ToString()
    {
        return "Serial: " + Serial + "\n"
               + "Container high: " + _height + "\n"
               + "Container depth: " + _depth + "\n"
               + "Container max payload weight: " + MaxWeight + "\n"
               + "Weight of container (without payload): " + _weightContainer + "\n"
               + "Weight payload: " + _weightPayload;
    }
}