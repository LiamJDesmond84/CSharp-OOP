using System;

//* Make sure to include the Vehicle class separate from the Program class
public class Vehicle {

    //# Fields
    private int maxNumPassengers;
    private string color;

    
    //# Constructors

    //* Accessibility of class members is defaulted to private
    //* so we must add the public keyword to anything we
    //* want to allow outside access to.
        public Vehicle(int maxPass, string col)
    {
        //* Notice the Constructor function doesn't need
        //* a return type or the static keyword

        maxNumPassengers = maxPass;
        color = col;
    }



    public int MaxNumPassengers
    {
        get { return maxNumPassengers; }
    }
    public string Color
    {
        get { return color; }
        set { Color = value;}
    }

    //# Properties(Getters & Setters)

    //todo - sets "Color" field
    public string ColorProp
    {
        get
        {
            //* Simply referencing the property will invoke the "getter", such as:
            //* Console.WriteLine(vehicleObject.ColorProp);
            //* and will return the following:

            return $"This thing is {Color}";
        }
        set
        {
            //* Assigning a value to a property, such as:
            //* vehicleObject.ColorProp = "Blue";
            //* will invoke the "setter", and the "value" keyword will become the assigned value
            //* ("Blue" in this example)

            Color = value;
        }
    }






    //# Methods

    //* vehicleObject.MakeNoise("HOOONK!") will invoke this one
    public void MakeNoise(string noise)
    {
        Console.WriteLine(noise);
    }
    
    //* vehicleObject.MakeNoise() will invoke this one
    public void MakeNoise()
    {
        Console.WriteLine("BEEP!");
    }

    

    //# Auto-Implemented Properties

    public string Name {get;set;}
}

