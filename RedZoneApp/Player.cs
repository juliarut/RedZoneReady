using System;

public class Player
{    
    public required string Name { get; set; }
    public string CyclePhase { get; set; } = "";
    public DateTime CycleStartDate { get; set; }
    public int CycleLength { get; set; }

    public string GetCurrentPhase()
    {
        int daysSinceStart = (DateTime.Now - CycleStartDate).Days % CycleLength;

        if (daysSinceStart >= 0 && daysSinceStart <= 5)
            return "Red Alert";
        if (daysSinceStart >= 6 && daysSinceStart <= 14)
            return "Build Phase";
        if (daysSinceStart >= 15 && daysSinceStart <= 16)
            return "Power Peak";
        
        return "Steady Phase";
    }
}
