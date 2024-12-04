using System;
using DesafioPOO.Models;

Console.WriteLine("SmartPhone Iphone");
 
Smartphone iphone = new Iphone("98459977", "a14", "12112124455", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagran");

Console.WriteLine("\nSmartPhone Nokia");
 
Smartphone nokia = new Nokia("98459988", "N22", "12112124488", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");