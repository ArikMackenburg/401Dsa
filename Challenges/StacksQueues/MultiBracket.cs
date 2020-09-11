using System;
using DataStructures.StacksQueues;
using System.Text;

namespace Challenges.StacksQueues
{
    public class MultiBracket
    {
        Stack<char> brackets = new Stack<char>();

        public bool CheckBrackets(string input)
        {
            
            foreach (char c in input)
            {
                if(CheckLeftBracket(c) == true )
                {
                    brackets.Push(c);
                }
                if(CheckRightBracket(c) == true )
                {
                    if (MatchCheker(c) != true)
                    {
                        return false;
                    }
                    continue;
                }
                continue;
            }
            return true;
        }
        public bool CheckLeftBracket(char c)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                return true;
            }
            return false;
        }

        public bool CheckRightBracket(char c)
        {
            if (c == ')' || c == '}' || c == ']')
            {
                return true;
            }
            return false;
        }
       

        public bool MatchCheker(char type)
        {
            char c;

            if (type == ')')
            {
                c = '(';
                return Helper(c);
            }
                
            if (type == '}')
            {
                c = '{';
                return Helper(c);
            }

            if (type == ']')
            {
                c = '[';
                return Helper(c);
            }
            return false;

        }

        public bool Helper(char c)
        {
            if (brackets.Pop() == c)
            {
                return true;
            }
            return false;
        }
    }

    
}
