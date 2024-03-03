using Task1;

var car1 = new RegularCar(270,40, "Renault", "Megan");
var car2 = new RegularCar(240, 35, "Renault", "Clio");
var car3 = new RegularCar(280, 45, "Kia", "Ceed");
var car4 = new RegularCar(260, 50, "Kia", "Sportage");
var car5 = new SportCar(355, 20, "McLaren", "Senna");
var car6 = new SportCar(400, 15, "Ferrari", "599xx evo");
var car7 = new SportCar(320, 30, "Porsche", "Taycan");
var car8 = new JeepCar(240, 90, "Land Rover", "Discovery");
var car9 = new JeepCar(220, 95, "Jeep", "Wrangler");
var car10 = new JeepCar(150, 85, "ЛуАЗ", "969М");

var race1 = new City("Kiev", 50);
var race2 = new Rally("Galicia", 100);

race1.StartRace(new Car[] { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 });

car1.Tune(40, 8);
car3.Tune(45,10);

race2.StartRace(new Car[] { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10 });