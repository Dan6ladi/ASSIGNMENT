namespace ASSIGNMENT
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Vehicle lexus = new Vehicle();
            lexus.IsdriversLicense = true;
            lexus.IssafetyInspection = true;
            lexus.IsinsuranceInfo = true;
            lexus.Istitle = true;
            lexus.vehicleColor = "red";

            Minivan minivan = new Minivan();
            minivan.Name = "jeep GlX";
            minivan.Description = "V12 Engine";
           


            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter your vehicle model");
            string description = Console.ReadLine();
            Console.WriteLine(lexus.FirstStep());
            Console.WriteLine(lexus.Next());
            Console.WriteLine(lexus.AlmostThere());
            Console.WriteLine(lexus.FinalStep());
            
            Console.ReadLine(); 
        }
        
    }
}