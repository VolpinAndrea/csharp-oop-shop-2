// See https://aka.ms/new-console-template for more information
using CSharpShop2;

Acqua bottiglia = new("H2O", "Frizzante", 1.3, 0.2, 1.1, 6, "Monti Gialli");
bottiglia.StampaTutto();
bottiglia.Bevi(0.6);
bottiglia.StampaTutto();
bottiglia.Riempi(0.9);
bottiglia.StampaTutto();

List<string> fruttiEso = new List<string>() { "Papaya", "Mango", "Avicado" };
SacchettoFrutta SaccoUno = new("Tropical", "Fresca", 3.4, 0.9, "Jambo", fruttiEso);

SaccoUno.StampaTutto();
SaccoUno.AggiungiFrutto("Sasso");
SaccoUno.StampaTutto();
