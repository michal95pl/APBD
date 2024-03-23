namespace Ex2;

public class Ship
{
    private List<Container> _containers = new List<Container>();
    private double _maxSpeed;
    private int _maxContainers;
    private double _maxContainersWeight;

    public Ship(double maxSpeed, int maxContainers, double maxContainersWeight)
    {
        _maxSpeed = maxSpeed;
        _maxContainers = maxContainers;
        _maxContainersWeight = maxContainersWeight;
    }

    public void LoadContainer(Container container)
    {
        _containers.Add(container);
    }

    public void UnloadContainer(Container container)
    {
        _containers.Remove(container);
    }

    public void LoadContainers(List<Container> containers)
    {
        this._containers.AddRange(containers);
    }

    public Container? ReplaceContainer(String serial, Container container)
    {
        for (int i = 0; i < _containers.Count; i++)
        {
            if (_containers[i].Serial.Equals(serial))
            {
                Container temp = _containers[i];
                _containers[i] = container;
                return temp;
            }
        }
        return null;
    }

    public override string ToString()
    {
        String inf = "Max speed: " + _maxSpeed + " Max containers: " + _maxContainers + " Max weight of containers: " +
                     _maxContainersWeight + "\nContainers: \n";

        foreach (Container container in _containers)
        {
            inf += container + "\n";
        }

        return inf;
    }
}