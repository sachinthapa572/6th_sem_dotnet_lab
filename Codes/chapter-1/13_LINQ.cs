class LINQExample
{
    public void DemonstrateLINQ()
    {

        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }

}