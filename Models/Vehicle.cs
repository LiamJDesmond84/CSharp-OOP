//* Make sure to include the Vehicle class separate from the Program class
public class Vehicle {
    //* Accessibility of class members is defaulted to private
    //* so we must add the public keyword to anything we
    //* want to allow outside access to.

    //* this unassigned integer will default to 0
    public int NumPassengers;

    //* Notice the Constructor function doesn't need
    //* a return type or the static keyword
    public Vehicle(int val) {
        NumPassengers = val;
    }
}

