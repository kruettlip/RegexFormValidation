using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormValidation
{
    static class RegexValidator
    {
        public static bool ValidateField(string regex, String content, Control item)
        {
            if (content.Trim().Length != 0)
            {
                if (Regex.IsMatch(content, regex))
                {
                    item.Background = Brushes.LightGreen;
                    return true;
                }
                else
                {
                    item.Background = Brushes.LightSalmon;
                }
            }
            else
            {
                item.Background = Brushes.White;
            }
            return false;
        }
    }
}
