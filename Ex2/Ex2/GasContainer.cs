namespace Ex2;

public class GasContainer : Container, IHazardNotifier
{
    private double _pressure;

    public GasContainer(double pressure, double height, double weightContainer, double depth, double maxWeight) 
        : base('G', height, weightContainer, depth, maxWeight)
    {
        _pressure = pressure;
    }

    public double UnLoad()
    {
        double temp = base.Unload();
        base.Load(temp * 0.05);

        return temp * 0.95;
    }
    
    private bool _dangerousSituation = false;
    public string? IsDangerousSituation()
    {
        return _dangerousSituation? Serial : null;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" 
            + "Pressure: " + _pressure;
    }
}