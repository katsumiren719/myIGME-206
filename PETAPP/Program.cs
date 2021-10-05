using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETAPP
{
    // Author:Raj barot
    // Purpose : Create a console application called PetApp with the following schUML and design:


    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name //Getter method
        {
            get => name;
            set => name = value;
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();
        public Pet() //default constructor
        {
            this.name = "NULL";
            this.age = 0;
        }
        public Pet(string name, int age) // initialising constructor
        {
            this.name = name;
            this.age = age;
        }
    }

    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public class Cat : Pet, ICat
    {
        public override void Eat()
        {
            Console.WriteLine("Yuck, I don't like that!", this.Name);
        }

        public override void Play()
        {
            Console.WriteLine("Where's that mouse...", this.Name);
        }

        public override void GotoVet()
        {

        }

        public void Scratch()
        {
            Console.WriteLine("{ Hiss!", this.Name);
        }

        public void Purr()
        {
            Console.WriteLine("purrrrrrrrrrrrrrrrrrrr", this.Name);
        }

        public Cat()
        {

        }

    }

    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            //Console.WriteLine("{0}: Yummy, I will eat anything!", this.Name);
        }

        public override void Play()
        {
            //Console.WriteLine("{0}: Throw the ball, throw the ball!", this.Name);
        }

        public override void GotoVet()
        {
            // Console.WriteLine("{0}: Whimper, whimper, no vet!", this.Name);
        }

        public void Bark()
        {
            // Console.WriteLine("{0}: Woof woof!", this.Name);
        }

        public void NeedWalk()
        {
            //Console.WriteLine("{0}: Woof woof, I need to go out.", this.Name);
        }

        public Dog(string license, string name, int age) : base(name, age)
        {
            this.license = license;
            this.Name = name;
            this.age = age;
        }

        public class Pets
        {
            List<Pet> petList = new List<Pet>();   // NOTE 1
            public Pet this[int nPetEl]   // NOTE 2
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }


            public int Count()   //NOTE 3
            { 
                    return petList.Count;
                
            }

            public void Add(Pet pet)  // NOTE 4
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)  //NOTE 5
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)  // NOTE 6
            {
                petList.RemoveAt(petEl);
            }

            public string Name
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
            class Program
            {

                static void Main(string[] args)
                {
                    Pet thisPet = null;  //Question 1
                    Dog dog = null;
                    Cat cat = null;
                    IDog iDog = null;
                    ICat iCat = null;

                    Pets pets = new Pets();  //Question 2
                    Random rand = new Random();  //Question 3

                    for (int x = 0; x < 50; x++)  //Question 4a implementing for loop
                    {
                        if (rand.Next(1, 11) == 1)
                        {
                            if (rand.Next(0, 2) == 0)
                            {

                                // DOG

                                string name, inputAge, license;
                                int age = 0;

                                Console.Write("What is Dog's name? ");
                                name = Console.ReadLine();
                               
                                    Console.Write("What is Dog's age? ");
                                    inputAge = Console.ReadLine();
                                  

                                Console.Write("Whats your liscense? ");
                                license = Console.ReadLine();

                                dog = new Dog(license, name, age);
                                pets.Add(dog);
                            }
                            else    // CAT
                            {
                                
                                cat = new Cat();
                                
                                Console.Write("What is Cat's Name ");
                                cat.Name = Console.ReadLine();
                                Console.Write("what is Cat's Age");
                                pets.Add(cat);
                            }
                        }
                        else  // //Question 4b
                        {
                            
                            int ranPet = rand.Next(0, pets.Count());
                            thisPet = pets[ranPet];
                            if (thisPet == null)
                            {
                                continue;
                            }
                            else //
                            {
                                if (thisPet.GetType().Equals(typeof(Cat)))  // //Question 4c
                                {
                                    iCat = (ICat)thisPet;
                                    switch (rand.Next(0, 4))
                                    {
                                        case 0:
                                            iCat.Eat();
                                            break;
                                        case 1:
                                            iCat.Play();
                                            break;
                                        case 2:
                                            iCat.Purr();
                                            break;
                                        case 3:
                                            iCat.Scratch();
                                            break;      
                                    }
                                }
                                else if (thisPet.GetType().Equals(typeof(Dog))) // //Question 4c
                                {
                                    iDog = (IDog)thisPet;
                                    switch (rand.Next(0, 5))
                                    {
                                        case 0:
                                            iDog.Eat();
                                            break;
                                        case 1:
                                            iDog.Play();
                                            break;
                                        case 2:
                                            iDog.Bark();
                                            break;
                                        case 3:
                                            iDog.NeedWalk();
                                            break;
                                        case 4:
                                            iDog.GotoVet();
                                            break;
                                    }
                                }

                            }

                        }

                    }
                }

            }
        }
    }
}
    /*
    class Program
    {
        
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            //create random seed
            Random rand = new Random();

            
        }
    }*/




