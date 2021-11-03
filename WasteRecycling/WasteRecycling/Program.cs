using System;

namespace WasteRecycling
{
    class Program
    {
        static void Main(string[] args)
        {
            Dustbin bin = new Dustbin("Green");
            Garbage leftOver = new Garbage("Rotten food");
            PlasticGarbage bottle = new PlasticGarbage("Soda", true);
            PaperGarbage box = new PaperGarbage("TV-box", false);
            
            bin.throwOutGarbage(leftOver);
            if (!box.Squeezed)
            {
                box.Squeeze();
            }
            bin.throwOutGarbage(box);
            if (!bottle.Clean)
            {
                bottle.CleanMethod();
            }
            bin.throwOutGarbage(bottle);
            bin.displayContents();
            bin.emptyContents();
            bin.displayContents();
        }
    }
}