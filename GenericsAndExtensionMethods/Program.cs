namespace GenericsAndExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** String extension method to return Right Substring *************************");
            string sampleStr = "GHOST";
            int count = 3;
            Console.WriteLine("String:" + sampleStr + "\nCount:" + count + "\nRightSubstring:" + sampleStr.RightSubstring(3));

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("*********** Generic method to check if two strings or integers are equal **************");

            int a = 2, b = 2;
            if(Generics.AreEqual(a, b)) 
            {
                Console.WriteLine(a + " and " + b + " are equal");
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are not equal");
            }

            string c = "GHOST", d = "GHOSTT";
            if (Generics.AreEqual(c, d)) 
            {
                Console.WriteLine(c + " and " + d + " are equal");
            }
            else 
            {
                Console.WriteLine(c + " and " + d + " are not equal");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

        }
    }
}
