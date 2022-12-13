using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmis ededi verilmis quvvete yukselden metod

            Console.WriteLine("nece eded olacaq");
            var countStr = Console.ReadLine();
            var count = Convert.ToInt32(countStr);
            int[] nums = new int[count];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin:");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                nums[i] = number;

            }


            




        }

        // verilmis ededi verilmis quvvete yukselden metod
        static int eded(int num1, int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }
            return result;

        }

        ////Verilmis 3 ededden en boyuyunu tapan metod
        static int say(int num1, int num2, int num3)
        {
            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    return num1;
                }

            }
            else if (num2 >= num3)
            {
                if (num2 >= num1)
                {
                    return num2;
                }
            }
            else if (num3 >= num1)
            {
                return num3;
            }
            //verilmis ededler siyahisindaki en boyuk ededi tapan metod
            static int metod(int[] numbers)
            {


                var maximum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > maximum)
                    {
                        maximum = numbers[i];
                    }


                }

                return maximum;

            }

            Console.WriteLine("==================== EVE VERILENLER BASLAYIR==================================================");

            //Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

            static int boyukededindeks(int[] numbers)
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        max = i;
                    }
                    
                }

                return max[i];
            }



            //Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.
            //Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın

            static string Siyahi(String[] word)
            {
                string index = word;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word)
                    {
                        index = word[i];
                        return index;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }

            //Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array
            //qaytaran metod.Yəni metodu işə salın {4,-5,3,-2,6}
            //ədədlərindən ibarət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır

            static int musbet(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0 )
                    {
                        return numbers[i];

                    }
                    else
                    {
                        break;
                    }

                }
            }


            //Verilmiş yazıda rəqəm olub olmadığını qaytaran metod

            static bool letters(int words)
            {
                bool reqemdirse = false;

                for (int i = 0; i < words.Length; i++)
                {
                    if (char.IsDigit(words[i]))
                    {
                        reqemdirse = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                

            }


            //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod


            
            static bool  verilen(string siyahi)
            {
                var has = false;
                for (int i = 0; i < siyahi.Length; i++)
                {
                    if ((char.IsDigit(siyahi[i])))
                    {
                        has = true;
                        return siyahi[i];

                    }
                    else
                    {
                        has = false;
                    }
                }
                return result;


            }




        }


    }
        
}


    


