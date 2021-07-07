using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FFX_PostcodeParser
{
    class Postcode
    {
        ///////////////////////////
        ///ATTRIBUTES
        ///////////////////////////
        private String postcode;
        private String outwardCode;
        private String outwardLetter;
        private String outwardNumber;
        private String inwardCode;

        ///////////////////////////
        ///CONSTRUCTORs
        ///////////////////////////

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postcode"></param>
        public Postcode(String postcode)
        {
            this.postcode = postcode.Trim().ToUpper();
            SplitCode();
            SplitOutwardCode();
        }

        ///////////////////////////
        ///METHODS
        ///////////////////////////
        private void SplitCode()
        {
            int i = this.postcode.Length;
            this.inwardCode = this.postcode.Substring(i - 3);
            this.outwardCode = this.postcode.Substring(0, i - 3).Trim();

            this.postcode = this.outwardCode + this.inwardCode;
        }
        private void SplitOutwardCode()
        {            
            Regex reg = new Regex("(?<Alpha>[A-Z]*)(?<Numeric>[0-9]*[A-Z]*)");
            Match match = reg.Match(this.outwardCode);
            this.outwardLetter = match.Groups["Alpha"].Value;
            this.outwardNumber = match.Groups["Numeric"].Value;
        }
        public String GetPostCode()
        {
            return this.postcode;
        }
        public String GetOutwardCode()
        {
            return this.outwardCode;
        }
        public String GetOutwardLetter()
        {
            return this.outwardLetter;
        }
        public String GetOutwardNumber()
        {
            return this.outwardNumber;
        }
        public String GetInwardCode()
        {
            return this.inwardCode;
        }
    }    
}
