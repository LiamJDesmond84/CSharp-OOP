using System;
class Human
{
    // Properties for Human
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    private int Health { get; set; }
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values

    public Human (string name = "Test"){

        Name = name;
        Strength = 74;
        Intelligence = 88;
        Dexterity = 45;
        Health = 100;
    }
     
    // Add a constructor to assign custom values to all fields

    public Human (string name, int str, int intel, int dex, int health){

        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }
     
    // Build Attack method
    public int Attack(Human target)
    {
        int dmg = Strength * 5;
        Console.WriteLine($"{target}'s Health is now:");
        return  Health - dmg;
    }
}

