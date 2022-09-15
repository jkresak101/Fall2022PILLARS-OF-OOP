using PILLARSOFOOP;

Car car = new Car();
car.TopSpeed = 5000;

// Cannot create vehicle (or any abstract class) objects, but we can use them as variables
Vehicle vehicle = new Bike();
//When in a variable of the parent class, the child only has access to the properties and methods
//of the parent meaning we cant do vehicle.Brand
//but we can do vehicle.ToStringRepresentation();
Console.WriteLine(vehicle.ToStringRepresentation()); ;

//Polymorphism allows us to store both cars and bikes into this list of vehicles because they both inherit
// the abstract class vehicle
//Any car objects take on the form of vehicle while in the vehicle list
List <Vehicle> vehicles = new List<Vehicle>();