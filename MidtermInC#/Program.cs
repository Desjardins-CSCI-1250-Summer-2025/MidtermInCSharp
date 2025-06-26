namespace MidtermInC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Question 1
            Console.Write("Give me side 1 for your triangle. ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Give me side 2 for your triangle. ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Give me side 3 for your triangle. ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(TriangleType(a, b, c));
            */

            //Console.WriteLine(CountVowels("fkldjshalfkjdshajhgvcxjhbvfdjashfgeran,mrneqwgdskjvb,mcsnbgkjhfewtklfdnsa,mvbnsdlakjf;lewkn vjckgrfnewtgmnfdsvb ,mrnelkwhvdxsnblkvgjfdskjfgbewkbtjrkjewhf,mndsbgdskjfbrewkbvcxzkhfiyqbrfasbjkdfhkfjdbsafgdsafda"));
            /*
            int[] numbers = [1, 2, 3, 4, 5];
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Sum("6", "5"));
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2));
            */
            Console.Write("What grade letter did you receive in class? ");
            char letter = Console.ReadLine().Trim()[0];
            //c
            switch (letter)
            {
                case 'a':
                case 'A':
                case 'B':
                case 'b':
                    Console.WriteLine("You did great in this class!");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("You passed, but you need practice!");
                    break;
                default:
                    Console.WriteLine("You did not pass! Try again!");
                    break;
            }

            
        }
            /*
            if (letter == 'A' || letter == 'a' || letter == 'B' || letter == 'B')
            {
                Console.WriteLine("You did great in this class!");
            }
            else if (letter == 'C' || letter == 'c')
            {
                Console.WriteLine("You passed, but you need practice!");
            }
            else
            { 
                Console.WriteLine("You did not pass! Try again!");
            }
            */
        }

        //def triangle_type(a, b, c):
        public static string TriangleType(int a, int b, int c)
        {
            if(a == b && b == c)
            {
                return "equilateral";
            }
            else if (a != b && a != c && b != c)
            {
                return "scalene";
            }
            else
            {
                return "isosceles";
            }

        }

        //def count_vowels(text):
        public static int CountVowels(string text)
        {
            int counter = 0;

            char[] vowels = ['A','a','E','e','I','i','O','o','U','u'];

            /*
            foreach(char c in text)
            { 
                if(c == 'A' || c == 'a' || c == 'E' || c == 'e' || c == 'I' || c == 'i' || c == 'O' || c == 'o' || c == 'U' || c == 'u')
                {
                    counter++;
                    //counter += 1;
                    //counter = counter + 1;
                }
            }
            */
            //fkldjshalfkjdshajhgvcxjhbvfdjashfgeran,mrneqwgdskjvb,mcsnbgkjhfewtklfdnsa,mvbnsdlakjf;lewkn vjckgrfnewtgmnfdsvb ,mrnelkwhvdxsnblkvgjfdskjfgbewkbtjrkjewhf,mndsbgdskjfbrewkbvcxzkhfiyqbrfasbjkdfhkfjdbsafgdsafda
            foreach (char c in text)
            {
                foreach (char v in vowels)
                {
                    if(c == v)
                    {
                        counter++; 
                    }
                }
            }

            return counter;
        }


        //def sum_list(lst):

        //[ 1 2 3 4 5]
        public static int Sum(int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                counter += numbers[i];
            }

            return counter;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        
        public static int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    

    }
}
