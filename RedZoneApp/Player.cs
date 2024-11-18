using System;

public class Player
{    
    public string Name { get; set; }
    public string CyclePhase { get; set; } = "";
    public DateTime CycleStartDate { get; set; }
    public int CycleLengthInDays { get; set; }
    
    //public bool Consent { get; set; }
}
