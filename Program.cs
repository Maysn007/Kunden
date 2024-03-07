using Kunden;

Kunde k1 = new();
Console.WriteLine($"Rabatt: {k1.GetRabatt()}");

VIP v1 = new();
Console.WriteLine($"Rabatt: {v1.GetRabatt()}");
