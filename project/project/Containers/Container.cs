namespace project.Containers;


using project.Exceptions;
using project.Interfaces;


public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }

    protected Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }

    public void unload()
    {
        throw new NotImplementedException();
    }

    public void load()
    {
        throw new OverfillException();
    }
}