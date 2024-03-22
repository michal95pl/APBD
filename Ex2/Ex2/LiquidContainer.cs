namespace Ex2;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _dangerous;
    
    public LiquidContainer(bool dangerous) : base('L')
    {
        this._dangerous = dangerous;
    }

    public void Load(double peyload)
    {
        if (peyload > base._maxWeight * (_dangerous? 0.5 : 0.9))
                ;
        else
            base.Load(peyload);
        
    }
}