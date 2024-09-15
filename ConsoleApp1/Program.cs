//Exercise 1

//Creating a list
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//Creating a dictionary
Dictionary<string, int> fact = new Dictionary<string, int>()
{
    {"Im", 1 },
    {"Eliza", 2 },
    {"Hrahsq", 3 },
    {"Es Du", 4 },
    {"Im gexeckuhi", 5 }
};

//Creating a queue
Queue<int> whatever = new Queue<int>();
whatever.Enqueue(1);
whatever.Enqueue(2);
whatever.Enqueue(3);
whatever.Enqueue(4);
whatever.Enqueue(5);

//Creating a stack
Stack<int> list_of_numbers = new Stack<int>();
list_of_numbers.Push(1);
list_of_numbers.Push(2);
list_of_numbers.Push(3);
list_of_numbers.Push(4);
list_of_numbers.Push(5);

//Exercise 2
//fastest way 
int sum = list_of_numbers.Sum();
Console.WriteLine(sum);

//O(N) way
int sum_longer = 0;
foreach (int number in list_of_numbers)
{
    sum_longer += number;
}

Console.WriteLine(sum_longer);


//fastest way, dict
int dict_sum = fact.Values.Sum();
Console.WriteLine(dict_sum);

//O(N)

int dict_sum_longer = 0;
foreach (var keys in fact.Keys)
{
    dict_sum_longer += fact[keys];
}
Console.WriteLine(dict_sum_longer);

//removing the elements from queue
whatever.Dequeue();
whatever.Dequeue();

foreach (int number in whatever)
{
    Console.WriteLine(number);
}

//operations with stack
list_of_numbers.Pop();
list_of_numbers.Pop();

foreach (int element in list_of_numbers)
{
    Console.WriteLine(element);
}

//Additional tasks
//printing elements of list
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//Largest from 3 digit number

int three_digit_number = 224;

int first_digit = three_digit_number / 100;
int second_digit = (three_digit_number / 10) % 10;
int third_digit = three_digit_number % 10;

int largest_digit = Math.Max(first_digit, Math.Max(second_digit, third_digit));
Console.WriteLine(largest_digit);

//Same for smallest, just another function
int smallest_digit = Math.Min(first_digit, Math.Min(second_digit, third_digit));
Console.WriteLine(smallest_digit);


//Even numbers sum in array
int[] array_of_numbers = { 5, 7, 12, 23, 656 };
int sumEvens = 0;

foreach (int number in array_of_numbers)
{
    if (number % 2 == 0)
    {
        sumEvens += number;
    }
}

Console.WriteLine("The sum is " + sumEvens);

//Average of elements
double average = array_of_numbers.Average();
Console.WriteLine("Average is " + average);