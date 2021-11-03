using System;
using System.Transactions;

namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        private bool clean;
        //private String name;

        public PlasticGarbage(String name, bool clean) : base(name)
        {
            this.clean = clean;
        }

        public bool Clean
        {
            get => clean;
        }

        public void CleanMethod()
        {
            if (!Clean)
            {
                clean = true;
            }
        }
    }
}