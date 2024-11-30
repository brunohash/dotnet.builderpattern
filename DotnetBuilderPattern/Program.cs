using DotnetBuilderPattern;

var constructCar = new ConstructorCar();
var directorCar = new DirectorCar(constructCar);

directorCar.ConstructCar("Model 3", "Tesla", 2021);

var car = constructCar.GetCar();

Console.WriteLine($"Created Car successfully: {car.Model} {car.Brand} {car.Year}");

