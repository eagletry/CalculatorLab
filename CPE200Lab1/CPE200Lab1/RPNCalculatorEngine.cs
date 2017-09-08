using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            Stack mystack = new Stack();
            // split str to parts

            string[] parts = str.Split(' ');
             
            // loop each part
            for(int i = 0; i < parts.Length; i++)
            {
                if(isOperator(parts[i]))
                {
                    string firstoperand, secondoperand;
                    secondoperand = Convert.ToString(mystack.Pop());
                    firstoperand = Convert.ToString(mystack.Pop());
                    mystack.Push (calculate(parts[i], firstoperand, secondoperand,4));
                    
                }
                else
                {
                    if (isNumber(parts[i]))
                    {
                        mystack.Push(parts[i]);
                    }
                    
                }
                
            }
            return mystack.Pop().ToString();
            // if part is number
            // push to stack
            // if part is operator
            // pop two times => second, first operand
            // calculate(oerator, first, second) => result
            // push result to stack
            // return result;
            //jjguguj

        }
    }
}
