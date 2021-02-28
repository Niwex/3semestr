using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class StringsFactory
    {
        public string text;
        
        public enum StringTypes
        {
            HEXSTRING,
            SYMBSTRING
        }

        public Strings GetStrings(StringTypes type, string str)
        {
            Strings toReturn = null;
            switch(type)
            {
                case StringTypes.HEXSTRING:
                    toReturn = new HexString(str);
                    break;
                case StringTypes.SYMBSTRING:
                    toReturn = new SymbString(str);
                    break;
                default:
                    throw new ArgumentException("wrong string type");
            }
            return toReturn;
        }

        
        
    }
}
