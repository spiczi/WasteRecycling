using System;
using System.Security.Cryptography;

namespace WasteRecycling
{
    public class Garbage
    {
        private readonly String name;

        public Garbage(String name)
        {
            this.name = name;
        }

        public String Name => name;

        public override String ToString()
        {
            return "Name: " + Name;
        }
    }
}