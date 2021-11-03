using System;

namespace WasteRecycling
{
    public class DustbinContentException : Exception
    {
        public DustbinContentException(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}