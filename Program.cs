using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
//resolvido
Iphone iphone = new Iphone("88888", "iphone6", "1111", 70);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whasts");
 
 Nokia nokia = new Nokia("222", "tijolo", "2222", 64);
 nokia.InstalarAplicativo("telegram");
 nokia.Ligar();

