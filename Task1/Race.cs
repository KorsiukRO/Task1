namespace Task1;

public abstract class Race : Car
{
   private string? nameRace;
   private int passabilityRace;

   public string? NameRace
   {
      get => nameRace;
      set { nameRace = value; }
   }

   public int PassabilityRace
   {
      get => passabilityRace;
      set { passabilityRace = value; }
   }
}