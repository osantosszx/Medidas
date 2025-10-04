double m, cm, km;
Console.Write("Entre com a medida (em metros):");


m = Convert.ToDouble(Console.ReadLine());
cm = m * 100;
km = m / 1000;
Console.WriteLine("---equivalente---");
Console.Write(cm);
Console.WriteLine(" cm");
Console.Write(m);
Console.WriteLine(" m");
Console.Write(km);
Console.WriteLine(" km");

