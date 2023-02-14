namespace GreatestProductOfAdjacentNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate greatest product : ");
            decimal number = Convert.ToDecimal(Console.ReadLine());

            Program p = new Program();

            int product = p.GreatestProduct(number);
            Console.WriteLine($"The greatest product of 4 adjacent numbers of the number {number} is = {product}");
        }


        /// <summary>
        /// The method takes an input number and calculates the greatest product of 4 adjacent numbers in that number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>the greatest product of 4 adjacent numbers</returns>
        public int GreatestProduct(decimal number)
        {
            if (number % 1000 == number)  //checking whether the number consits atleast 4 digits or not
            {
                Console.WriteLine("The number must be minimum of 4 digits ");
                return 0;
            }

            int product = 0;    //declaring the initial product to zero

            while (number > 0)
            {
                decimal tempProduct = 1;        //stores the temporary product of 4 adjacent numbers

                decimal updated = number;
                int index = 0;
                while (index < 4)
                {
                    tempProduct *= updated % 10;
                    updated = Math.Floor(updated / 10);
                    index++;
                }
                if (tempProduct > product)          //Comparing the previous calculated product to find the greatest of all the products
                    product = (int)tempProduct;
                number = Math.Floor(number / 10);
            }

            return product;
        }
    }
}