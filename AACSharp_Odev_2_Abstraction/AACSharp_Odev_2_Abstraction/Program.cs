// See https://aka.ms/new-console-template for more information
using AACSharp_Odev_2_Abstraction.Odev1;
using AACSharp_Odev_2_Abstraction.Odev2;
using AACSharp_Odev_2_Abstraction.Odev3;
using BMW = AACSharp_Odev_2_Abstraction.Odev3.BMW;


AACSharp_Odev_2_Abstraction.Odev1.BMW bmw = new AACSharp_Odev_2_Abstraction.Odev1.BMW();
bmw.carName = "BMW";

Console.Write(bmw.carName + " : ");
bmw.GoesFast();
bmw.Swim();
bmw.Flies();

Console.WriteLine();

AACSharp_Odev_2_Abstraction.Odev1.Mercedes mercedes = new AACSharp_Odev_2_Abstraction.Odev1.Mercedes();
mercedes.carName = "Mercedes";

Console.Write(mercedes.carName + " : ");
mercedes.Swim();
mercedes.Flies();

Console.WriteLine() ;
AACSharp_Odev_2_Abstraction.Odev1.Porsche porsche = new AACSharp_Odev_2_Abstraction.Odev1.Porsche();
porsche.carName = "Porsche";

Console.Write(porsche.carName + " : ");
porsche.Flies();


Console.WriteLine();
Console.WriteLine();


GenelMudur genelMudur = new GenelMudur();
genelMudur.calisanTip = "Genel Müdür";
Console.WriteLine(genelMudur.calisanTip + " -> " + genelMudur.MaasinizNedir());

Mudur mudur = new Mudur();
mudur.calisanTip = "Müdür";
Console.WriteLine(mudur.calisanTip + " -> " + mudur.MaasinizNedir());

Programcı programcı = new Programcı();
programcı.calisanTip = "Programcı";
Console.WriteLine(programcı.calisanTip + " -> " + programcı.MaasinizNedir());

Stajyer stajyer = new Stajyer();
stajyer.calisanTip = "Stajyer";
Console.WriteLine(stajyer.calisanTip + " -> " + stajyer.MaasinizNedir());

double toplamMaas = 0;

toplamMaas += genelMudur.MaasinizNedir();
toplamMaas += mudur.MaasinizNedir();
toplamMaas += programcı.MaasinizNedir();
toplamMaas += stajyer.MaasinizNedir();


Console.WriteLine("Toplam maaş : "+toplamMaas);

Console.WriteLine();
Console.WriteLine();


AACSharp_Odev_2_Abstraction.Odev3.BMW BMW3 = new AACSharp_Odev_2_Abstraction.Odev3.BMW();
BMW3.arabaAd= "BMW";
Console.WriteLine(BMW3.arabaAd + " -> " + BMW3.Yakit()+ "L");

AACSharp_Odev_2_Abstraction.Odev3.Mercedes mercedes3 = new AACSharp_Odev_2_Abstraction.Odev3.Mercedes();
mercedes3.arabaAd = "Mercedes";
Console.WriteLine(mercedes3.arabaAd + " -> " + mercedes3.Yakit() + "L");

AACSharp_Odev_2_Abstraction.Odev3.Porsche porsche3 = new AACSharp_Odev_2_Abstraction.Odev3.Porsche();
porsche3.arabaAd = "Porsche";
Console.WriteLine(porsche3.arabaAd + " -> " + porsche3.Yakit() + "L");


double toplamYakit = 0;
toplamYakit += BMW3.Yakit();
toplamYakit += mercedes3.Yakit();
toplamYakit += porsche3.Yakit();

Console.WriteLine("Toplam yakıt : "+toplamYakit);

Console.ReadLine();

// Ödev 4 ;
// Array : Önceden belirlenen türde değerleri indexler yardımıyla tutan bir veriyapısıdır.
