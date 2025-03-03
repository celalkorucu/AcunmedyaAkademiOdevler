// See https://aka.ms/new-console-template for more information

using AACSharpOdev_1_Inheritance;

Audi audi = new Audi();
audi.carName = "Audi";
audi.carGear = "Otomatik";
audi.Read(audi.carName , audi.carGear);

Mercedes mercedes = new Mercedes();
mercedes.carName = "Mercedes";
mercedes.carGear = "Otomatik";
mercedes.Read(mercedes.carName, mercedes.carGear);

Toyota toyota = new Toyota();
toyota.carName = "Toyota";
toyota.carGear = "Düz";
toyota.Read(toyota.carName, toyota.carGear);


Togg togg = new Togg();
togg.carName = "Togg";
togg.carGear = "Otomatik";
togg.Read(togg.carName, togg.carGear);


Porsche porsche = new Porsche();
porsche.carName = "Porsche";
porsche.carGear = "Otomatik";
porsche.Read(porsche.carName, porsche.carGear);


BMW bMW = new BMW();
bMW.carName = "BMW";
bMW.carGear = "Düz";
bMW.Read(bMW.carName, bMW.carGear);

Console.ReadLine();

// Abstract Class : Doğrudan nesne üretilmeyen ancak miras alınarak kullanılaiblen class'tır
// Abstraction : Bir nesnenin gerekli olan özellilerini kullanmak demektir.
// Polymorphism : Bir nesnenin veya metodun farklı biçimde davranabilmesidir.
