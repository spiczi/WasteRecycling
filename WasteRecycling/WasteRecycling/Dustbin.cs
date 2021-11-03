using System;
using System.Collections;
using System.Collections.Generic;

namespace WasteRecycling
{
    public class Dustbin
    {
        public String color;
        public List<Garbage> house = new List<Garbage>();
        public List<Garbage> paper = new List<Garbage>();
        public List<Garbage> plastic = new List<Garbage>();

        public Dustbin(string color)
        {
            this.color = color;
        }

        public void throwOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage)
            {
                if (((PlasticGarbage) garbage).Clean)
                {
                    plastic.Add(garbage);
                }
                else
                {
                    throw new DustbinContentException("The plastic is not clean!");
                }
            } else if (garbage is PaperGarbage)
            {
                if (((PaperGarbage) garbage).Squeezed)
                {
                    paper.Add(garbage);
                }
                else
                {
                    throw new DustbinContentException("The paper is not squeezed!");
                }
            }
            else
            {
                house.Add(garbage);
            }
        }

        public void displayContents()
        {
            Console.WriteLine("House waste content: " + house.Count + " item(s)");
            foreach (Garbage garbage in house)
            {
                Console.WriteLine(garbage);
            }
            
            Console.WriteLine("Paper waste content: " + paper.Count + " item(s)");
            foreach (Garbage garbage in paper)
            {
                Console.WriteLine(garbage);
            }
            
            Console.WriteLine("Plastic waste content: " + plastic.Count + " item(s)");
            foreach (Garbage garbage in plastic)
            {
                Console.WriteLine(garbage);
            }
        }

        public void emptyContents()
        {
            house.Clear();
            plastic.Clear();
            paper.Clear();
        }

        public override string ToString()
        {
            return color + " dustbin!";
        }
    }
}