
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
  public  class Answers
    {
        public static void Question1()
        {
            List<int> numbers=new List<int>();
            double y = 0;
            bool check = true;
            while (check)
            {
                Console.Write("Enter a number: ");
                string nom = Console.ReadLine();
                int numb;
                bool t = int.TryParse(nom, out numb);

               if (!t||numb < 0)
                {
                    check = false;
                }
                numbers.Add(numb);
            }
            foreach (var n in numbers)
            {
                y += n;
            }
            Console.WriteLine(y/numbers.Count);
        }


        public static void Question2()
        {
            Stack<int> nums=new Stack<int>();
            Console.Write("Enter the length of numbers: ");
            int lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                nums.Push(num);
            }
            foreach (var p in nums)
            {
                Console.Write(p+", ");
            }
        }


        public static void Question3()
        {
            List<int> positive=new List<int>();
            bool check = true;
            while (check)
            {
                Console.Write("Enter a number: ");
                string num = Console.ReadLine();
                int nom;
                bool numb=int.TryParse(num,out nom);
                if (!numb)
                {
                    check = false;
                }
                if (nom > 0)
                {
                    positive.Add(nom);
                }
              
            }
            positive.Sort();
            foreach (var u in positive)
            {
                Console.WriteLine(u);   
            }
        }


        public static void Question4()
        {
            List<int> longest = new List<int>() { 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3};
            int count = 0;
            int y = 0;
            int d = 0;
            int a = 0;
            List<int> result=new List<int>();
            for (int i = 0; i < longest.Count; i++)
            {
                for (int j = 0; j < longest.Count; j++)
                {
                   
                    
                        if (longest[i] == longest[j])
                        {

                            count++;
                            a = count;
                        }
                        else
                        {
                            count = 0;
                        }

                        if (a > d)
                        {
                            d = a;
                            y = longest[i];

                        }
                    

                }
            }
            Console.WriteLine(d);
            for (int i = 0; i < d; i++)
            {
                result.Add(y);
            }

            foreach (var u in result)
            {
                Console.Write(u + ",");
            }


        }


        public static void Question5()
        {
            List<int> number=new List<int>(){19, -10, 12, -6, -3, 34, -2, 5};
            foreach (var h in number)
            {
                if (h > 0)
                {
                    Console.WriteLine(h);
                }
                
            }
           
        }


        public static void Question6()
        {
            List<int> numbers=new List<int>(){1,2,2};
            Hashtable myHashtable=new Hashtable();
            foreach (var r in numbers)
            {
                if (myHashtable.ContainsKey(r))
                {
                    myHashtable[r] = (int) myHashtable[r] + 1;
                }
                else
                {
                    myHashtable[r] = 1;
                }
            }
            foreach (DictionaryEntry entry in myHashtable)
            {
                if ((int) entry.Value % 2 == 0)
                {
                    for (int i = 0; i < (int) entry.Value; i++)
                    {
                        Console.Write(entry.Key + ", ");
                    }
                }
            }
        }


        public static void Question7()
        {
            List<int> numbers=new List<int>(){3, 4, 4, 2, 3, 3, 4, 3, 2};
            Hashtable myHashtable=new Hashtable();
            foreach (var r in numbers)
            {
                if (myHashtable.Contains(r))
                {
                    myHashtable[r] = (int) myHashtable[r] + 1;
                }
                else
                {
                    myHashtable[r] = 1;
                }
            }
            foreach (DictionaryEntry entry in myHashtable)
            {
                Console.WriteLine($"{entry.Key}-->{entry.Value} times");
            }
        }


        public static void Question8()
        {
            List<int> numbers=new List<int>(){2, 2, 3, 3, 2, 3, 4, 3, 3};
            Hashtable myHashtable=new Hashtable();
            foreach (var r in numbers)
            {
                if (myHashtable.Contains(r))
                {
                    myHashtable[r] = (int) myHashtable[r] + 1;
                }
                else
                {
                    myHashtable[r] = 1;
                }
            }

            int max = 0;
            foreach (DictionaryEntry entry in myHashtable)
            {
                if ((int)entry.Value >  max)
                {
                    max = (int) entry.Value;
                }
            }
            int c = 0;
            foreach (DictionaryEntry entry in myHashtable)
            {
                if ((int) entry.Value == max)
                {
                    c++;
                }

                if (c > 1)
                {
                    Console.WriteLine("There is no majorant");
                    break;
                }
                if( c   ==  1)
                {
                    Console.WriteLine(entry.Key);
                    break;
                }
            }

        }


        public static void Question9()
        {
            int N = 2;
            int y = 0;
            Queue<int> myInts=new Queue<int>();
          var d=new List<int>();
          d.Add(N);
          for (int i = 0; i <50/2; i++)
          {

              int p = d[i];
              d.Add(p + 1);
              d.Add(2*p+1);
              d.Add(p+2);
          }

          foreach (var a in d)
          {
              if (myInts.Count == 50)
              {
                  break;
              }

              Console.Write(a+", ");
              
          }
        }


        public static void Question10()
        {
            int N = 5;
            int M = 16;
            Queue<int> myInts=new Queue<int>();
            myInts.Enqueue(N);

            while (myInts.Count > 0)
            {
                int P = myInts.Dequeue();

             if ( P*2 > M)
             {
                 break;
             }

             
               if (!myInts.Contains(P+1) || !myInts.Contains(P+2) && !myInts.Contains((P+2)*2))
               {
                   if (!myInts.Contains(N))
                   {
                       myInts.Enqueue(N);
                   }
                   myInts.Enqueue(P + 1);
                   
                   myInts.Enqueue(P + 2);
                   
                   int y =( P + 2)*2;
                   if (y <= M)
                   {
                       myInts.Enqueue(y);
                   }
               }
            }
            foreach (var c in myInts)
            {
                Console.WriteLine(c);
                if (c==M)
                {
                    break;
                }
            }


        }


    }
}
