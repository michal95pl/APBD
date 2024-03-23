// See https://aka.ms/new-console-template for more information

using Ex2;

List<IHazardNotifier> dangerousSituations = new List<IHazardNotifier>();

void IsDangerousSituation()
{
    foreach (IHazardNotifier ver in dangerousSituations)
    {
        if (ver.IsDangerousSituation() != null)
            Console.WriteLine("Dangerous situation on: " + ver.IsDangerousSituation());
    }
}


Ship ship1 = new Ship(30, 3, 100);

RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(10, 3, 20, 100, "chocolate", 15);

refrigeratedContainer.Load("chocolate", 10, 16);
refrigeratedContainer.Load("chocolate", 10, 14);

ship1.LoadContainer(refrigeratedContainer);

LiquidContainer liquidContainer = new LiquidContainer(10, 3, 20, 10);
dangerousSituations.Add(liquidContainer);

List<Container> containerList1 = new List<Container>();

liquidContainer.Load(true, 8);
containerList1.Add(liquidContainer);



GasContainer gasContainer = new GasContainer(20, 3, 20, 100, 15);
dangerousSituations.Add(gasContainer);

gasContainer.Load(10);
containerList1.Add(gasContainer);

ship1.LoadContainers(containerList1);

double payload = gasContainer.UnLoad();

IsDangerousSituation();


RefrigeratedContainer refrigeratedContainer1 = new RefrigeratedContainer(10, 3, 20, 100, "eggs", 19);
ship1.ReplaceContainer("KON-G-2", refrigeratedContainer1);


// move container between ship
Ship ship2 = new Ship(35, 10, 100);
ship1.UnloadContainer(refrigeratedContainer1);
ship2.LoadContainer(refrigeratedContainer1);


Console.WriteLine(ship1);
Console.WriteLine(ship2);