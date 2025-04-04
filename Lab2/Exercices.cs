namespace Lab2
{
    internal class Ex1
    {
        public static void start()
        {
            Console.WriteLine("Type a number: ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0 && n % 3 == 0 && n % 5 != 0)
                Console.WriteLine("The number is even and divisible by 3 but not by 5");
            else Console.WriteLine("The number is even and divisible by 3 and by 5");
        }
    }

    internal class Ex2
    {

        public static bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void start()
        {
            Console.WriteLine("Type a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            foreach (int i in Enumerable.Range(0, n))
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                if (isPrime(temp))
                    sum += temp;
            }
            Console.WriteLine("The sum of the prime numbers is: " + sum);
        }
    }

    internal class Ex3
    {
        public static void start()
        {
            Console.WriteLine("Type a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            int copy = n;
            while (copy > 0)
            {
                int digit = copy % 10;
                reversed = reversed * 10 + digit;
                copy /= 10;
            }
            if (n == reversed)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }
        }
    }

    internal class Ex4
    {
        public static void start()
        {
            Console.WriteLine("Type a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            words.OrderByDescending(w => w.Length);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }

    internal class Ex5
    {
        public static void start()
        {
            Console.WriteLine("Type the size of the first array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            foreach (int i in Enumerable.Range(0, n))
            {
                Console.WriteLine("Type the element: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Type the size of the second array: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];
            foreach (int i in Enumerable.Range(0, m))
            {
                Console.WriteLine("Type the element: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            arr1.OrderBy(x => x);
            arr2.OrderBy(x => x);
            Console.WriteLine("The first array is: ");
            foreach (int i in arr1)
                Console.Write(i + " ");
            foreach (int i in arr2)
                Console.Write(i + " ");

            foreach (int i in arr1)
            {
                if (arr2.Contains(i))
                    Console.WriteLine("The number " + i + " is in both arrays");
                else
                    Console.WriteLine("The number " + i + " is not in both arrays");
            }
        }
    }

    public class Dreptunghi
    {
        protected int Lungime;
        protected int Latime;

        public Dreptunghi(int lungime, int latime)
        {
            Lungime = lungime;
            Latime = latime;
        }

        public virtual int CalculeazaArie()
        {
            return Lungime * Latime;
        }

        public virtual int CalculeazaPerimetru()
        {
            return 2 * (Lungime + Latime);
        }

        public void getLungime()
        {
            Console.WriteLine(Lungime);
        }
        public void getLatime()
        {
            Console.WriteLine(Latime);
        }
        public void setLungime(int lungime)
        {
            Lungime = lungime;
        }
        public void setLatime(int latime)
        {
            Latime = latime;
        }
    }

    public class Patrat : Dreptunghi
    {
        public Patrat(int l) : base(l, l)
        {
        }
        public override int CalculeazaArie()
        {
            return Lungime * Lungime;
        }
        public override int CalculeazaPerimetru()
        {
            return 4 * Lungime;
        }
    }

    public abstract class Item
    {
        public int ID;
        public string Name;
        public double Price;
        public enum ItemType { Product, Ticket, Laptop }
    }

    public class Product : Item
    {
        DateTime ExpirationDate;
    }

    public class Venue
    {
        int capacity;
        string location;
        string name;
    }

    public class Ticket : Item
    {
        Venue venue;
        DateTime date;
    }

    public class Laptop : Item
    {
        (int, int) DisplaySize;
        double weight;
    }

    public class Cart
    {
        double TotalPrice;
        List<Item> items = new List<Item>();

        public void AddToCart(Item item)
        {
            items.Add(item);
        }

        public void RemoveFromCart(int id)
        {
            items.RemoveAll(i => i.ID == id);
        }

        public void ComputeTotalPrice()
        {
            TotalPrice = items.Sum(i => i.Price);
        }

        public void SortCartItems(int ord)
        {
            if (ord == 0)
            {
                items = items.OrderBy(i => i.Price).ToList();
            }
            else if (ord == 1)
            {
                items = items.OrderByDescending(i => i.Price).ToList();
            }
        }
        public void DisplayByType(int type)
        {
            if (type == 0)
            {
                foreach (var item in items.OfType<Product>())
                {
                    Console.WriteLine(item.ToString);
                }
            }
            else if (type == 1)
            {
                foreach (var item in items.OfType<Ticket>())
                {
                    Console.WriteLine(item.ToString);
                }
            }
            else if (type == 2)
            {
                foreach (var item in items.OfType<Laptop>())
                {
                    Console.WriteLine(item.ToString);
                }
            }
        }
    }
}
