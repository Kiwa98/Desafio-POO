using DesafioPOO.Models;

Nokia nokia1 = new Nokia("1545412");
Iphone iphone1 = new Iphone("8465155");

nokia1.InstalarAplicativo("WhatsApp");

iphone1.InstalarAplicativo("Instagram");

nokia1.Ligar();

nokia1.ReceberLigacao();

iphone1.ReceberLigacao();
iphone1.Ligar();