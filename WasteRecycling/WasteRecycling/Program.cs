using System;

namespace WasteRecycling
{
    class Program
    {
        static void Main(string[] args)
        {
            Dustbin bin = new Dustbin("Green");
            Garbage leftOver = new Garbage("Rotten food");
            PlasticGarbage bottle = new PlasticGarbage("Soda", false);
            PaperGarbage box = new PaperGarbage("TV-box", false);
            
            bin.ThrowOutGarbage(leftOver);
            if (!box.Squeezed)
            {
                box.Squeeze();
            }
            bin.ThrowOutGarbage(box);
            if (!bottle.Clean)
            {
                bottle.CleanMethod();
            }
            bin.ThrowOutGarbage(bottle);
            bin.DisplayContents();
            bin.EmptyContents();
            bin.DisplayContents();
        }
    }
}