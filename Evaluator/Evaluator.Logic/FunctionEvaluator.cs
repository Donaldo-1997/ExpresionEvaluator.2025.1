﻿using System.Globalization;

namespace Evaluator.Logic;

public class FunctionEvaluator
{
    public static double Evalute(string infix)
    {
        var postfix = ToPostfix(infix);
        return Calculate(postfix);
    }

    private static double Calculate(Queue<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var item in postfix)
        {
            if (IsOperator(item))
            {
                var operator2 = stack.Pop();
                var operator1 = stack.Pop();
                stack.Push(Result(operator1, item, operator2));
            }
            else
            {
                stack.Push(double.Parse(item, CultureInfo.InvariantCulture));
            }
        }
        return stack.Pop();
    }

    private static double Result(double operator1, string item, double operator2)
    {
        return item switch
        {
            "+" => operator1 + operator2,
            "-" => operator1 - operator2,
            "*" => operator1 * operator2,
            "/" => operator1 / operator2,
            "^" => Math.Pow(operator1, operator2),
            _ => throw new Exception("Invalid expresion"),
        };
    }

    private static Queue<string> ToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var digit = string.Empty;
        var postfix = new Queue<string>();

        foreach (var item in infix)
        {
            if (IsOperator(item))
            {
                if(digit != "")
                {
                    postfix.Enqueue(digit);
                    digit = string.Empty;
                }

                if (stack.Count == 0)
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == ')')
                    {
                        do
                        {
                            digit += stack.Pop();
                            postfix.Enqueue(digit);
                            digit = string.Empty;
                        } while (stack.Peek() != '(');
                        stack.Pop();
                    }
                    else
                    {
                        if (PriorityExpression(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            digit += stack.Pop();
                            postfix.Enqueue(digit);
                            digit = string.Empty;
                            stack.Push(item);
                        }
                    }
                }
            }
            else
            {
                digit += item;
            }
        }
        
        if(digit != "")
        {
            postfix.Enqueue(digit);
            digit = string.Empty;
        }

        do
        {
            digit += stack.Pop();
            postfix.Enqueue(digit);
        } while (stack.Count > 0);
        
        return postfix;
    }

    private static int PriorityStack(char item)
    {
        return item switch
        {
            '^' => 3,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 0,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static int PriorityExpression(char item)
    {
        return item switch
        {
            '^' => 4,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 5,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static bool IsOperator(char item) => "()^*/+-".IndexOf(item) >= 0;
    private static bool IsOperator(string item) => "()^*/+-".IndexOf(item) >= 0;
}