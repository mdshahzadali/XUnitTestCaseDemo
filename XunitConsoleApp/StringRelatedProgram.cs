using System;
using System.Collections.Generic;
using System.Text;

namespace XunitConsoleApp
{
    public class StringRelatedProgram
    {
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                //Explanation 
                //Suppose input string is Hello
                //Then charArray[i] in first iteration will be H and
                //str[j] will be o so H will be replaced with o.
                //this line code H with o
                charArray[i] = str[j];
                //Suppose input string is Hello
                //Then charArray[j] in first iteration will be o and
                //str[i] will be o so H will be replaced with o.
                //this line of code replace o with H
                charArray[j] = str[i];
            }
            string reverseString = new string(charArray);
            return  reverseString;
        }
        
        public bool checkIsPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++,j--)
            {
                //Explantion
                //Suppose input is madam
                //In first iteration
                //Then initial str[i] = 0 containing value m and str[j]=4 containig value m
                //So here str[i] and str[j] containing same value
                //control will move to else block and make flag true

                //In second iteration
                //Then initial str[i] = 1 containing value a and str[j]=3 containig value a
                //So here str[i] and str[j] containing same value
                //control will move to else block and make flag true

                //In third iteration i value is 2 and that is not fullfilled the for loop block condition
                //i < str.length / 2 i.e 2 so 2 < 2 is false
                //control will jump to finally return block.
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else flag = true;
            }
            return flag;
        }

        public string ReverseWordOrder(string str)
        {
            //Algorithom explanation
            //Suppose input string is satish kumar
            //Step1-> Creating two variable responsible to take the length of input string.
            //Step2-> Getting one while loop responsible to iterate untill Start greater than 0
            //Step3-> under this while loop checking given string contain ' '
            //then creating one more inner while loop and storing all the value in 
            //one string builder object revereseSentence.
            //Step5-> finally one taking for loop and iterating previous index value.
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            //Here we are checking start and end length
            //Suppose input string is satish kumar then start and end would be 11
            int Start = str.Length - 1;
            int End = str.Length - 1;
            //this while loop will iterate untill Start greater than 0
            while (Start > 0)
            {
                //This if conditiona is responsible to check a perticular index of string contains ' ' empty char
                //if true then it will go inside if block.
                //for given string satish kumar str[6] i.e start 6 contains ' ' char
                if (str[Start] == ' ')
                {
                    //Here we are incrementing the i count with start+1
                    //so i would be 7 after first iteration.
                    i = Start + 1;
                    //Here we are checking i with End i value is 7 and End value 11
                    //so condition true it will goes under while block.
                    while (i <= End)
                    {
                        //Here we are appending value of perticular index in reverseSentence object.
                        //so here str[7] i.e k will append first
                        reverseSentence.Append(str[i]);
                        //Here incrementing the value of i
                        i++;
                        //final outcomes of the given sentence in this block is kumar
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                //else we are decrementing the start count.
                Start--;
            }
            //This for loop will check i value with end value
            //so for given string after first iteration
            //end value would be 5
            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
                //after this for loop iteration reverseSentece would be kumar satish as a object
            }
            //here we are conveting the string builder object into string and returning the result.
            return reverseSentence.ToString();
        }
    }
}
