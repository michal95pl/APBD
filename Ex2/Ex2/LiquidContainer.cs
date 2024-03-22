namespace Ex2;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _dangerous;

    public LiquidContainer(double height, double weightContainer, double depth, double maxWeight)
        : base('L', height, weightContainer, depth, maxWeight)
    {
        
    }

    private bool _dangerousSituation = false;
    
    public void Load(bool dangerous, double payload)
    {
        _dangerous = dangerous;
        
        _dangerousSituation = payload > MaxWeight * (_dangerous ? 0.5 : 0.9);
        
        base.Load(payload);
        
    }

    public string? IsDangerousSituation()
    {
        return _dangerousSituation? base.Serial : null;
    }
}