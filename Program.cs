using System;
using System.ComponentModel;

public class Dog
{
    private static string she;

    String name;
    String breed;
    int age;
    String color;
    //Constructor
    /* public Dog()
     {
         this.name = name;
         this.breed = breed;
         this.age = age;
         this.color = color;
     } */

    public Dog(String Name, String Breed,
                   int Age, String Color)
    {
        name = Name;
        breed = Breed;
        age = Age;
        this.color = Color;
    }

    public String GetName()
    {
        return name;
    }

    
    public String GetBreed()
    {
        return breed;
    }

    
    public int GetAge()
    {
        return age;
    }

    
    public String GetColor()
    {
        return color;
    }

    
    public String ToString()
    {
        return ("Hi my name is " + this.GetName()
                + ".\nMy breed, age and color are " + this.GetBreed()
                + ", " + this.GetAge() + ", " + this.GetColor());
    }

    
   /* public static void Main(String[] args)
    {

        // Creating object
        Dog tuffy = new Dog();

        tuffy.name = "tuffy";
        tuffy.breed = "papillon";
        tuffy.age = 5;
        tuffy.color = "white";
         Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
         Console.WriteLine(tuffy.ToString());
    }*/

    class Person
    {
         // field

        public string She   // property
        {
            get { return she; }   // get method
            set { she = value; }  // set method
        }
        //public void A()
        public  void A()
        {
            Console.WriteLine("HII this is A");
        }
        public static void Main(String[] args)
        {
            Person ob = new Person();
            
            ob.A();
            //A();
           // Person.A();
          Dog tuffy = new Dog("tuffy","papillon",5,"white");
          Console.WriteLine(tuffy.ToString());
        }
    }
}

