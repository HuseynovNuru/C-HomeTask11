using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CHomeTask11
{
    internal class Product
    {
        private string _no;
        public string Category;
        public double Price;

        public string No
        {
            get => _no; 
            set
            {
                if(HasProductByNo(value))
                    _no= value;
            }
        }
        public static bool HasProductByNo(string str)
        {
            if(string.IsNullOrWhiteSpace(str)) 
                return false;
            if (!char.IsUpper(str[0]) || !char.IsLower(str[0]))
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
    }
}
