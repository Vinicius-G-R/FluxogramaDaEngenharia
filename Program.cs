 bool movendo;
  bool deveria;
    
  Console.WriteLine("--- Fluxograma da Engenharia ---\n");

  Console.Write("O objeto está se movendo (S/N)? ");
    movendo = Console.ReadLine().ToUpper() == "S";
    
Console.Write("Deveria? ");    
    deveria = Console.ReadLine().ToUpper() == "S";
    
if (movendo && deveria)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("\nÓtimo.");
  Console.ResetColor();
}
    
else if (movendo && !deveria)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("\nUse Silver Tape.");  
  Console.ResetColor();
}
    
else if (!movendo && deveria)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nUse WD-40.");
Console.ResetColor();
}
    
else
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("\nÓtimo.");
  Console.ResetColor();
}
      