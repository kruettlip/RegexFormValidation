using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormValidation
{
    public static class RegexTypes
    {
        public const string NAME = @"^[a-zA-Zäöü]{2,}\s?[a-zA-Zäöü\s]*$";
        public const string EMAIL = @"[a-zA-Z]+\.?[a-zA-Z]+\@[a-zA-Z]{2,}\.[a-zA-Z]{2,3}";
        public const string PHONENR = @"(\d{3}\s?|\+\d{1,3}\s?\d{2})(\s?\d{3}\s?\s?\d{2}\s?\d{2})$";
    }
}
