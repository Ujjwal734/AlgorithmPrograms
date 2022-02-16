using AlgorithmPrograms;
/*Console.WriteLine("Hello, Welcome to Algorithm Programe...!");
StringPermut stringPermut = new StringPermut();
String str = "ABC";
int n = str.Length;
stringPermut.Permutation(str, 0, n - 1);
Console.WriteLine("*******************************************");
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
Console.WriteLine("*********************************************");
Insertation insertation = new Insertation();
string[] names = { "ajj", "uru", "vhi" };
insertation.InsertSort(names);
foreach (var item in names)
{
    Console.WriteLine(item);
}
Console.WriteLine("*********************************************");
BubblesSort bubblesSort = new BubblesSort();
int[] arry = { 1, 4, 3, 9, 5, 7 };
bubblesSort.Bubbles(arry);
Console.WriteLine("Your Sorted Array");
bubblesSort.Display(arry);

Console.WriteLine("*********************************************");
Anagramss anagramss = new Anagramss();
anagramss.Angram();

Console.WriteLine("*********************************************");
Console.WriteLine("Enter the List of Words Seperated By ','");
string given = Console.ReadLine();
string[] list = given.Split(',');
List<string> list1 = new List<string>();
List<string> list2 = new List<string>();
for (int i = 0; i < list.Length; i++)
    list1.Add(list[i]);
MergeSorts mergeSorts = new MergeSorts();
list2 = mergeSorts.MergeSort(list1);
foreach (string s in list2)
{
    Console.Write(s + " ");
}*/

Console.WriteLine("**********************************************");
PrimeNumber obj = new PrimeNumber();
Console.WriteLine("Enter number From Where to where You want to print Prime Number :- ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
obj.Prime(num1,num2);






