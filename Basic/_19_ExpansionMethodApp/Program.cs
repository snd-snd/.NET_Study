using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ExpansionMethodApp
{
    public static class Util
    {
        public static String ToChangeCace(this String target)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in target)
            {
                if (ch >= 'A' && ch <= 'Z')
                    sb.Append((char)(ch + 32));
                else if (ch >= 'a' && ch <= 'z')
                    sb.Append((char)(ch - 32));
                else
                    sb.Append(ch);
            }
            return sb.ToString();            
        }
        public static int FindIndex(this String target, char ch)
        {
            return target.IndexOf(ch);
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            String text = "Lorem Ipsum Dolor Sit Amet, Consectetuer Adipiscing Elit.";

            String result = text.ToChangeCace();
            Console.WriteLine(result);

            int index = text.FindIndex('m');
            Console.WriteLine(index);
        }
    }
}
