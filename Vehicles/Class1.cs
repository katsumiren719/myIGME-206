using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author :- Raj Barot
// Purpose :- Write code in a class library project (.NET .DLL) called Vehicles that implements the Vehicle family of objects
// as outlined below (_424DoubleBogey as the class identifier). There are nine objects and two interfaces
// (IPassengerCarrier and IHeavyLoadCarrier) that require implementation.  The virtual method should be an empty function:
namespace Vehicles
{
    // This program just shows basic inheritance and abstract classes following the diagram, i dont see need for commeents
    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }  //The virtual method should be an empty function:

    }
    public abstract class Car : Vehicle
    {
    }
    public abstract class Train : Vehicle
    {
    }
    public interface IPassengerCarrier
    {
        public virtual void LoadPassenger()   //The virtual method should be an empty function:
        { }
    }
    public interface IHeavyLoadCarrier
    {
    }
    public class SUV : Car, IPassengerCarrier
    {
    }
    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
    }
    public class Compact : Car, IPassengerCarrier
    {
    }
    public class PassengerTrain : Train, IPassengerCarrier
    {
    }
    public class FreightTrain : Train, IHeavyLoadCarrier
    {
    }
    public class T424DoubleBogey : Train, IHeavyLoadCarrier
    {
    }
}