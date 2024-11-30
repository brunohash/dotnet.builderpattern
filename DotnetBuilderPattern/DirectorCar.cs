namespace DotnetBuilderPattern;

public class DirectorCar
{
    private IConstructorCar _constructor;

    public DirectorCar(IConstructorCar constructorCar)
    {
        _constructor = constructorCar;
    }
    
    public void ConstructCar(string model, string brand, int year)
    {
        _constructor.SetModel(model);
        _constructor.SetBrand(brand);
        _constructor.SetYear(year);
    }
}