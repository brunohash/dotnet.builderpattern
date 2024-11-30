namespace DotnetBuilderPattern;

public interface IConstructorCar // Builder
{
    void SetModel(string model);
    void SetBrand(string brand);
    void SetYear(int year);
    
    Car GetCar();
}