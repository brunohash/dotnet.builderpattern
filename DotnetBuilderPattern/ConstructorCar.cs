namespace DotnetBuilderPattern;

public class ConstructorCar : IConstructorCar // Concrete Builder
{
    private Car _car = new Car();
    
    public void SetModel(string model)
    {
        _car.Model = model;
    }

    public void SetBrand(string brand)
    {
        _car.Brand = brand;
    }

    public void SetYear(int year)
    {
        _car.Year = year;
    }

    public Car GetCar()
    {
        return _car;
    }
}