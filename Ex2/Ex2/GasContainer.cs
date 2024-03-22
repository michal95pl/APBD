namespace Ex2;

public class GasContainer : Container
{
    private double _pressure;

    public GasContainer() : base('G')
    {
        
    }

    public double UnLoad()
    {
        double temp = base.Unload();
        base.Load(temp * 0.05);

        return temp * 0.95;
    }
}