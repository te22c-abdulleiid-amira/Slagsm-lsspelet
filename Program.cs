using System;

int p1Hp = 127;
int p2Hp = 127;

string p1Name = "player 1";
string p2Name = "player 2";

Random generator = new Random();

while (p1Hp > 0 && p2Hp > 0)
{
  Console.WriteLine("!! FIGHT !!");
  Console.WriteLine($"{p1Name}: {p1Hp}  {p2Name}: {p2Hp}\n");

  int heroDamage = generator.Next(20);
  p2Hp -= heroDamage;
  p2Hp = Math.Max(0, p2Hp);
  Console.WriteLine($"{p1Name} throws shade at {p2Name} minus {heroDamage} braincells");

  int villainDamage = generator.Next(20);
  p1Hp -= villainDamage;
  p1Hp = Math.Max(0, p1Hp);
  Console.WriteLine($"{p2Name} DRAGGS {p1Name} minus {p1Name} hairstrands");

  Console.WriteLine("slå keyboarden för att fortsätta");
}

Console.WriteLine("!! FREEZE !!");
Console.WriteLine("Resultatet är...");

if (p1Hp == 0 && p2Hp == 0)
{
  Console.WriteLine("a tie?");
}
else if (p1Hp == 0)
{
  Console.WriteLine($"{p2Name} wins total drama island!");
}
else
{
  Console.WriteLine($"{p1Name} is this seasons winner of rupauls drag race!");
}

Console.WriteLine("du kan gå nu");
Console.ReadKey();