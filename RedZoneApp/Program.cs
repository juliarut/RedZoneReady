using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var players = new List<Player>
        {
            new Player
            {
                Name = "Kosovare Asllani",
                CycleStartDate = new DateTime(2023, 11, 1),
                CycleLength = 28
            },
            new Player
            {
                Name = "Caroline Seger",
                CycleStartDate = new DateTime(2023, 10, 25),
                CycleLength = 29
            },
            new Player
            {
                Name = "Stina Blackstenius",
                CycleStartDate = new DateTime(2023, 11, 3),
                CycleLength = 27
            },
            new Player
            {
                Name = "Fridolina Rolfö",
                CycleStartDate = new DateTime(2023, 11, 6),
                CycleLength = 30
            },
            new Player
            {
                Name = "Magdalena Eriksson",
                CycleStartDate = new DateTime(2023, 10, 30),
                CycleLength = 26
            }
        };

        
        Console.WriteLine("Player Statuses:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name} is in phase: {player.GetCurrentPhase()}");
        }
    }
}

