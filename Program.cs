using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO!!!

Nokia n1 = new Nokia("13156484798");
n1.Modelo = "NokiaNEVE";
n1.IMEI= "2898411215444-15";
n1.Memoria = 60;
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Orkut");

Iphone p1 = new Iphone("54684321684");
p1.Modelo = "AppleSpace1";
p1.IMEI= "2898411215444-15";
p1.Memoria = 180;
p1.Ligar();
p1.ReceberLigacao();
p1.InstalarAplicativo("Facebook");

