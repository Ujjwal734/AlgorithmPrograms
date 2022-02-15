using AlgorithmPrograms;
Console.WriteLine("Hello, Welcome to Algorithm Programe...!");
/*StringPermut stringPermut = new StringPermut();
String str = "ABC";
int n = str.Length;
stringPermut.Permutation(str, 0, n - 1);
StringBinarys stringBinarys = new StringBinarys();
String[] arr = { "LMO", "ABC", "DEF" };
String x = "ABC";
int results = stringBinarys.Search(arr, x);
if (results == -1)
{
    Console.WriteLine("Not Present");
}
else
{
    Console.WriteLine("Found " + "at index " + results);
}
Insertation insertation = new Insertation();
string[] names = { "ajj", "uru", "vhi" };
insertation.InsertSort(names);
foreach (var item in names)
{
    Console.WriteLine(item);
}*/
BubblesSort bubblesSort = new BubblesSort();
int[] arry = { 1, 4, 3, 9, 5, 7 };
bubblesSort.Bubbles(arry);
Console.WriteLine("Your Sorted Array");
bubblesSort.Display(arry);


