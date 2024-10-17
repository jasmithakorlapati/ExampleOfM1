namespace ExampleOfM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int d = 0;
            int ch = 1;

            while (ch != -1)
            {
                Console.WriteLine("Enter your choice (-1) Exit else Contine to Divide numbers");
                ch = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("Enter divider value");
                    d = int.Parse(Console.ReadLine());
                    int result = Div(n, d);
                    Console.WriteLine(result);

                }
                catch (CapgException ex) {
                    Console.WriteLine(ex.Message);
                }
                catch ( DivideByZeroException ex)
                {
                    Console.WriteLine("Please enter valid input 1-100");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Some Internal Error");
                }

            }




            Console.ReadLine();
        }

        private static int Div(int n, int d)
        {
            int ans = 0;
            try
            {
                ans = n / d;

            }
            catch (Exception ex)
            {

                throw new CapgException("Internal error");
            }


            return n / d;
        }
    }
}
