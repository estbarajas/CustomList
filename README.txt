The add function will join two instances of the class.

public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
{
	return CustomList<T>
}

CustomList<int> theListOne = new CustomList<int>() {1,2,3};
CustomList<int> theListTwo = new CustomList<int>() {4,5,6};

CustomList<int> AddTwoLists = theListOne + theListTwo;
string printAddTwoLists = AddTwoLists.ToString();
Console.WriteLine(printAddTwoLists);

output: 1 2 3 4 5 6



The remove function will check for equal index values from two lists. If the values are equal then it will remove that value from the a list.

public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
{
	return CustomList<T>
}

CustomList<int> theListOne = new CustomList<int>() {1,2,3};
CustomList<int> theListTwo = new CustomList<int>() {4,5,6};

CustomList<int> RemoveFromTheTwoLists = theListOne - theListTwo;
string prinRemoveFromTheTwoLists = RemoveFromTheTwoLists.ToString();
Console.WriteLine(prinRemoveFromTheTwoLists);

output: 1 3 

