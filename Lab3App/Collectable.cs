using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	public abstract class Collectable : Displayable
    {
        // A public property to hold the description of the collectable item.
        public string Description { get; set; }

        // A public property that will hold a reference to a CollectionBoard object.
        public CollectionBoard Board { get; set; }

        // A protected constructor for the Collectable class that sets the Description property.
        // It can only be called by this class or classes that inherit from this class.
        protected Collectable(string description)
        {
            Description = description;
        }

        // An abstract method called Display that must be implemented by inheriting classes.
        public abstract void Display();

        // A method that takes a list of Collectable items.
        // add to or remove from the list and prints the description of the collectable and stating that it was added or removed
        public virtual void AddMe(List<Collectable> list)
        {
            if (list.Contains(this))
            {
                list.Remove(this);
                Console.WriteLine($"{Description} is Used");
            }
            else
            {
                list.Add(this);
                Console.WriteLine($"{Description} Collected, Congrats!!!!");
            }

        }
    }




}

