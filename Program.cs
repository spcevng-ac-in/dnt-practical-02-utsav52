namespace practical_3
{
    class CourierCompany
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the weight of parcel: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of distance");
            int distance = Convert.ToInt32(Console.ReadLine());

            int charge = 0;

            if (distance <= 100)
            {
                charge = 50;
            }
            else if (distance <= 200)
                charge = 65;
            else if (distance <= 300)
                charge = 90;
            else
                charge = 120;

            int total_amount = weight * charge;

            Console.WriteLine("Total Amount =" +
                " " + total_amount);

            Console.Read();
        }
    }
}