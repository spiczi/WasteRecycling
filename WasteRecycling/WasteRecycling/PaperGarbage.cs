using System;

namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        private bool squeezed;
        //private String name;

        public PaperGarbage(String name, bool squeezed) : base(name)
        {
            this.squeezed = squeezed;
        }

        public bool Squeezed
        {
            get => squeezed;
        }

        public void Squeeze()
        {
            if (!Squeezed)
            {
                squeezed = true;
            }
        }
    }
}