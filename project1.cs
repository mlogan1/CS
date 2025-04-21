/* Galactic Travel Agency
You are tasked with managing passenger profiles for a Galactic Travel Agency. 
Each passenger has a name, age, ticket type, and preferred planet to visit. 
Using C#, you’ll start by creating these variables, manipulating them for different operations, and applying data conversions where needed.
*/

using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Variable definition
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";
    // Output Variables
    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);
    // Increment passengerAge by 1 to correct age
    passengerAge++;
    Console.WriteLine(passengerAge);
    // Explicit conversion
    double passengerAgeDouble = (double) passengerAge;
    Console.WriteLine(passengerAgeDouble);
    // Implicit conversion
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);
    // String conversion
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);
  }
}
