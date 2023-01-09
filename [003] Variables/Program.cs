
#region Variables Int

//this is a comment
/*
 * multi line comment
 * */

/*HDD
 *Perminent
 *Slow
 *Large
 *
 *RAM(Stack,Heap)
 *Temporary
 *Fast
 *Small
 */

//1. Declaration [<DataType> <Identfier>;]
//int num;
// int -> Value Type Stored in Stack

// 2.Assignment [<Identfier>]= <Value>;]
//num = 5;

// 3. Inialization [<DataType> <Identfier> = <Initial Value>]
//int num2 = 5;
#endregion

#region Variables String

// string Reference Type
//string s1;// Refrence Stored in Stack
//s1 = "Mohamed"; // Value Stored in Heap
//// Value Type Limited for all Data Type
//// Refrence Open

//string s2 = "A,";
//// regular concatination (Plus sign)
//string s3 = s1 + " " + s2;
//Console.WriteLine(s3);// Mohamed A.

////string interpolation
//string s4 = $"{s1} {s2}";
//Console.WriteLine(s4);// Mohamed A.

//Console.WriteLine($"int: [{int.MinValue} -  {int.MaxValue}]");//int: [-2147483648 -  2147483647]
#endregion

#region other Variables
// var
//var s1 = "Mohamed";

//var f = 0f;//float
//var d = 0d;//double
//var m = 0m;//decimal
//var u = 0u;//uint
//var l = 0l;//long
//var ul = 0ul;//ulong

//int oneMillion = 1_000_000;

//var result = 200 / 3; // int
//var result1 = 200 / 3.0; // double


////dynamic
//dynamic x = 9;
//x = "abc";
//x = 10m;

//char letter = 'A';//value type stored in stack ASCI
//System.Console.WriteLine(letter);
#endregion

#region Ex
//var id = 1000;
//var fname = "Mohamed";
//var lname = "A.";
//var salary = 1000d;
//var gender = "Male";
//var address = "Montereal,Canada";

//System.Console.WriteLine("Employee");
//System.Console.WriteLine("----------");
//System.Console.WriteLine($"Id: {id}");
//System.Console.WriteLine($"Id: {fname}");
//System.Console.WriteLine($"Id: {lname}");
//System.Console.WriteLine($"Id: {salary}");
//System.Console.WriteLine($"Id: {gender}");
//System.Console.WriteLine($"Id: {address}");
#endregion