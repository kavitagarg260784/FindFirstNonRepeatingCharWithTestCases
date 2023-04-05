

    namespace Utility
    {
        public class NonRepChar
        {

            public static Tuple<bool, char> FindNonRepetitiveCharachers(string InputString)
            {
                int i;
                int j;
                bool found = false;
                //char c;
                for (i = 0; i < ((InputString.Length - 1)); i++)
                {

                    found = false;

                    for (j = 0; j < InputString.Length; j++)
                    {
                        if (i == j)
                        {

                            continue;

                        }
                        else if (InputString[i] == (InputString[j]))
                        {
                            //Console.WriteLine("firstRepeatedCharacter is " + InputString[i]);
                            found = true;
                            break; // if character is repeating come out of loop & set found = true

                        }
                    }

                    if (found == false)
                    {
                        Console.WriteLine("first non Repeated Character is " + InputString[i]); // if found = false then printing 
                        break;
                    }


                }
                if (found == true)
                {

                    Console.WriteLine("first non Repeated Character is not found");

                }
                return new Tuple<bool, char>(found, InputString[i]);

            }

        }
    }
