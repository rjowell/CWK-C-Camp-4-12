using System;

namespace csharp_cwk
{
    
    
    
    class Calculator
    {
        //Add

        public int DoMath(int numberOne, int numberTwo, char operation)
        {
            if(operation == '+')
            {
                return numberOne + numberTwo;
            }
            else if(operation == '-')
            {
                return numberOne - numberTwo;
            }
            else if(operation == '*' || operation == 'x')
            {
                return numberOne * numberTwo;
            }
            else
            {
                return -56;
            }
        }


        public int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        //Subtract
        //Multiply
        //Divide
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    class Engine
    {
        int horsepower;
        int engineBlockSize;
        int gasMileage;

        public Engine()
        {
            horsepower = 100;
            engineBlockSize = 25;
            gasMileage = 30;
        }
    }



    




    class Car
    {
        
       
        
        
        int wheels = 4;
        public int gasTankSize = 20;
        int currentFuel = 7;
        int wheelSize;

        bool isRunning;

        public void Start()
        {
            if(isRunning == true)
            {
                Console.WriteLine("This car is already running");
            }
            else
            {
                isRunning = true;
            }
        }

        public void Stop()
        {
            if(isRunning == false)
            {
                Console.WriteLine("This car is already stopped");
            }
            else
            {
                isRunning = false;
            }
        }

        public void Refuel(int howMuchFuel)
        {
            
            if(currentFuel + howMuchFuel > gasTankSize)
            {
                Console.WriteLine("That's too much!");
            }
            else
            {
                currentFuel += howMuchFuel;
                //currentFuel = currentFuel + howMuchFuel;
                Console.Write("Your car was refueled!");
            }
        }

        public void drive()
        {
            
            if(isRunning == false)
            {   
                Console.WriteLine("You're car isn't started yet!");
            }
            else if(currentFuel >= 1)
            {
                Console.WriteLine("We're driving down the road!");
                currentFuel--;
            }
            
            else
            {
                Console.WriteLine("You don't have enough fuel. Please add more");
            }
            
            
        }

        public void speedUp()
        {
            Console.WriteLine("Zoom Zoom");
        }

        public void turn()
        {
            Console.WriteLine("turningg!!");
        }

        int numberOfSeats;
        string bodyColor;
        //Red "Blue" "Green" "Pink"
        string model;
        float horsepower;

        Engine carsEngine;

        bool isElectric;
        bool hasGPS;
        //SUV Limo Truck

        //Constructor Method - Waiter
        public Car(int wheelSizeInput,string modelTheyWant,string whatColor,int howManySeats, float howMuchHP,bool electric, Engine inputEngine, bool GPS)
        {
            wheelSize = wheelSizeInput;
            model = modelTheyWant;
            numberOfSeats = howManySeats;
            bodyColor = whatColor;
            carsEngine = inputEngine;
            horsepower = howMuchHP;
            isElectric = electric;
            hasGPS = GPS;
        }

        /*static void Main(string[] args)
        {
            /*Engine myEngine = new Engine();
            
            Car evansCoolCar = new Car(18,"SUV","Blue",10,420.6f,true,myEngine,true);
            Console.WriteLine("Evan's car is really cool. It is a "+evansCoolCar.bodyColor+" "+evansCoolCar.model);

            evansCoolCar.Start();
            evansCoolCar.drive();
            evansCoolCar.drive();evansCoolCar.drive();evansCoolCar.drive();evansCoolCar.drive();evansCoolCar.drive();evansCoolCar.drive();
            evansCoolCar.Refuel(11);
            Console.WriteLine("Your current fuel "+evansCoolCar);
            evansCoolCar.drive();

            Calculator myCalc = new Calculator();

            Console.WriteLine(myCalc.DoMath(100,20,'%'));


            
            
            
            
            
          
            
        }*/

        
        


    }

    
}

/**


What is a Blueprint?


What can you customize on a pickup truck
Camper / Gem Tops
Bed Length
Crew Cab
Gas/Diesel



What Do You Need To Build A Car? - Class
Instructions
Metal
Shaped Metal
Computer Parts
Screen
Seats
Wheels
Steering Wheel
Equipment and Tools for Assembly
Engine
Engine Coolant

What are some types of cars - Instances / Objects
Hybrid
Electric
Internal Combustion car
Limos
Convertibles
Sedans 
Coupes
Vans
Trucks
SUVs

How Can You Customize A Car? - Parameters (Adjectives)
Paint Color
Interior Materials / Style
Phone Caddy
Cup Holders
GPS
AC/Heat
Custom Wheels
Wheel Size
MAke/Model
Gas/Electric
Hood Ornament
4WD

What Can A Car Do? - Methods or Functions (verbs)
Transport People/Cargo
Cool Down/Heat Up
Makeshift Generator
Drive - Forward/Backward
Turn - LEft/Right
Speed Up Slow Down
Do a Stunt


*/
