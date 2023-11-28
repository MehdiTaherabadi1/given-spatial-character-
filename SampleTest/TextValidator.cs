namespace SampleTest
{
    internal class TextValidator
    {
        public static bool isValid(string text)
        {
            int length = text.Length;
            char[] charArray = text.ToCharArray();
          
            if (length == 0) 
                return true;
            
            Stack<char> charactersStack = new Stack<char>();
            for (int i = 0; i < length; i++)
            {
                if (charArray[i] is '(' or '{' or '[')
                {
                    charactersStack.Push(charArray[i]);
                }
                switch (charArray[i])
                {
                    case ')':  case '}': case ']':
                        {
                            if (charactersStack.Count == 0) 
                                return false;

                            char character = charactersStack.Pop();
                            if ((character != '(' || charArray[i] != ')') && (character != '{' || charArray[i] != '}') && (character != '[' || charArray[i] != ']'))
                            {
                                return false;
                            }
                            else
                            {
                                continue;
                            }
                        }
                }
            }
            if (charactersStack.Count != 0)
                return false;
            return true;
        }
    }
}
