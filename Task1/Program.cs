using Task1.Models.Cars.Abstract;
using Task1.Models.Cars.Concrete;
using Task1.Models.Races.Concrete;

var car1 = new RegularCar(270,40)
{
    Manufacturer = "Renault",
    Model = "Megan"
};

var car2 = new RegularCar(240, 35)
{
    Manufacturer = "Renault", 
    Model = "Clio"
};

var car3 = new RegularCar(280, 45)
{
    Manufacturer = "Kia", 
    Model = "Ceed"
};

var car4 = new RegularCar(260, 50)
{
    Manufacturer = "Kia", 
    Model = "Sportage"
};

var car5 = new SportCar(355, 20)
{
    Manufacturer =  "McLaren", 
    Model = "Senna"
};

var car6 = new SportCar(400, 15)
{
    Manufacturer =  "Ferrari", 
    Model = "599xx evo"
};

var car7 = new SportCar(320, 30)
{
    Manufacturer =  "Porsche", 
    Model = "Taycan"
};

var car8 = new JeepCar(240, 90)
{
    Manufacturer =  "Land Rover", 
    Model = "Discovery"
};

var car9 = new JeepCar(220, 95)
{
    Manufacturer =  "Jeep", 
    Model = "Wrangler"
};

var car10 = new JeepCar(150, 85)
{
    Manufacturer = "LuAZ",   
    Model = "969M"
};

//TODO: коли виправиш зауваження в класах Race, City, Rally - можна буде використовувати ефект поліморфізму
var race1 = new City()
{
    NameRace = "Kiev",
    PassabilityRace = 50
};

var race2 = new Rally()
{
    NameRace = "Galicia",
    PassabilityRace = 100
};

race1.StartRace(new Car[] { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 });

car8.Tune(40, 10);
car10.Tune(45,10);

race2.StartRace(new Car[] { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 });