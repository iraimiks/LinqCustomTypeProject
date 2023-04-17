using System.Text;

namespace LinqCustomTypeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("VW Golf", 270952);
            Car car2 = new Car("Opel Astra", 56079);
            Car car3 = new Car("Audi A4", 52493);
            Car car4 = new Car("Ford Focus", 51677);
            Car car5 = new Car("Seat Leon", 42125);
            Car car6 = new Car("VW Passat", 97586);
            Car car7 = new Car("VW Polo", 69867);
            Car car8 = new Car("Mercedes C-Class", 67549);


            var cars = new List<Car> {
                    car1, car2, car3, car4, car5, car6, car7, car8 };

            var listCars = from car in cars select car.Name;

            foreach (var car in listCars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("-----------------------------------");

            var listUnitsSold = from car in cars select car.UnitsSold;

            foreach (var car in listUnitsSold)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("-----------------------------------");

            var listWithExpresion = from car in cars
                                    where car.UnitsSold > 60000
                                    orderby car.UnitsSold descending
                                    select car;
            Console.WriteLine("-----------------------------------");

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var car in listWithExpresion)
            {
                stringBuilder.AppendLine($"{car.Name} - {car.UnitsSold}");
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine("-----------------------------------");

            int[] someNumbers = { 4, 3, 2, 1 };

            var processedValues = someNumbers
                .Select(x => x * 2);

            ShowElements(processedValues);
        }

        static void ShowElements(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}