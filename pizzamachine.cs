using System;

namespace pizzamachine
{
    
    class Pizza
    {
        public string typeOfPizza;
        public bool isGlutenFree;
        public int size;

        public Pizza(string typeInput, bool glutenInput, int sizeIn)
        {
            typeOfPizza = typeInput;
            isGlutenFree = glutenInput;
            size = sizeIn;
        }

        //Constructor
    }
    
    
    class PizzaMaker
    {
        public int dough,sauce,cheese,mushrooms;
        
        
        
        public PizzaMaker(int doughIn,int sauceIn, int cheeseIn, int shroomsIn)
        {
            dough = doughIn;
            sauce = sauceIn;
            cheese = cheeseIn;
            mushrooms = shroomsIn;
        }
        
        
        
        
        
        public Pizza MakePizza(string whatKindOfPizza, bool glutenFree, int whatSize)
        {
            
            

            if(CanIMakeThisPizza(whatKindOfPizza) == true)
            {
                
                if(whatKindOfPizza == "Mushroom")
                {
                    dough = dough - 1;
                    sauce = sauce - 1;
                    cheese = cheese - 2;
                    mushrooms = mushrooms - 1;

                    return new Pizza("Mushroom",glutenFree,whatSize);
                    
                }
                else if(whatKindOfPizza == "Crimini")
                {
                    dough = dough - 1;
                    sauce = sauce - 1;
                    cheese = cheese - 8;
                    mushrooms = mushrooms - 4;
                    

                    return new Pizza("Cremini",glutenFree,whatSize);
                   
                }
                
                else
                {
                    return new Pizza("Cheese",false,24);
                }
            }
            else
            {
                return null;
            }
        }



        static void Main(string[] args)
        {
            PizzaMaker myMachine = new PizzaMaker(10,6,20,15);
            Console.WriteLine("Welcome to Mr. Russ Pizza Parlor!");
            Console.WriteLine("What kind of Pizza do you want?");
            string orderType = Console.ReadLine();
            Console.WriteLine("Great choice! Do you want Gluten Free?");
            string orderGlutenFree = Console.ReadLine();
            bool glutenStatus;
            if(orderGlutenFree == "yes")
            {
                glutenStatus = true;
            }
            else
            {
                glutenStatus = false;
            }
            Console.WriteLine("Okay, how big do you want it?");
            int sizeInput =  Int32.Parse(Console.ReadLine());

            if(myMachine.MakePizza(orderType,glutenStatus,sizeInput) != null)
            {
                Pizza myPizza = myMachine.MakePizza(orderType,glutenStatus,sizeInput);
                Console.WriteLine("Congratulations, here is your "+myPizza.typeOfPizza+" and is size:"+myPizza.size);
            }
            //Console.WriteLine(myMachine.isThisNumberLessThanTen(4) );
        }
        //fdfsdfsdfsdfsdf
        public bool CanIMakeThisPizza(string typeOfPizza)
        {
            if(typeOfPizza == "Mushroom")
            {
                if(dough < 1 || sauce < 1 || cheese < 2 || mushrooms < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
         
            }
            //else if type == cremini
            //else if type == andrea

            return true;
        }
        
        /*Dough Type/Thickeness

        //

        
        
        Dough
        Sauce
        Cheese
        Mushrooms
        Olive Oil
        Basil
        Onions
        Anchovies
        
        
        FILL THE MACHINE
        Mushroom - $5.50
        -1 Dough
        -1 Sauce
        -2 Cheese
        -0.5 mushrooms

        Cremini - $10
        -1 Dough
        -8 cheese
        -4 mushroom
        -2 Olive Oil

        Andrew Special - $5.25
        -1 Dough
        -1 Sauce
        -2 basil
        -1 mushroom
        -3 cheese

        Mr Russ Special - $20.50
        -1 Dough
        -1 Sauce
        -1 Cheese
        -2 Onions
        -3 Mushroom
        -2 Anchovies
        */

    }
}