using System;
using System.Collections.Generic;
using System.Text;

namespace FFX_PostcodeParser
{
    class PrintResults
    {
        ///////////////////////////
        ///ATTRIBUTES
        ///////////////////////////
        private Postcode postcode;

        ///////////////////////////
        ///CONSTRUCTORs
        ///////////////////////////
        public PrintResults(Postcode postcode)
        {
            this.postcode = postcode;
            PrintPostcode();
            PrintOutwardCode();
            PrintOutwardLetter();
            PrintOutwardNumber();
            PrintInwardCode();
        }

        ///////////////////////////
        ///METHODS
        ///////////////////////////
        private void PrintPostcode()
        {
            Console.WriteLine("\n# POSTCODE: " + this.postcode.GetPostCode());
        }
        private void PrintOutwardCode()
        {
            Console.WriteLine("OUTWARD CODE: " + this.postcode.GetOutwardCode());
        }
        private void PrintOutwardLetter()
        {
            Console.WriteLine("OUTWARD LETTER: " + this.postcode.GetOutwardLetter());
        }
        private void PrintOutwardNumber()
        {
            Console.WriteLine("OUTWARD NUMBER: " + this.postcode.GetOutwardNumber());
        }
        private void PrintInwardCode()
        {
            Console.WriteLine("INWARD CODE: " + this.postcode.GetInwardCode());
        }
    }
}
