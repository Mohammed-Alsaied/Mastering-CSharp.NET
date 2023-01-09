#region Primary Expression  Return Value
//var amount = Math.Cos(30) + 1;//Math -> Member Lookup, Cos ->Method Call return value
//Console.WriteLine(amount);
#endregion

#region Void Expression Not Return Value
//System.Console.WriteLine("Mohamed") + 1;

#endregion

#region Assignment Statment
//var x = 2;
////x = x = 10;
//var y = 5;

// Binary Operator pricedense from left to right
// Assignment Statment & Comparison Opertaot pricedense from right to left

//System.Console.WriteLine($"x + y = {x + y}");
//System.Console.WriteLine($"x - y = {x - y}");
//System.Console.WriteLine($"x / y = {x / y}");
//System.Console.WriteLine($"x * y = {x * y}");
//System.Console.WriteLine($"x % y = {x % y}");

//var z = 8 / 4 / 2;//1
//System.Console.WriteLine(z);

//var z = 8 / (4 / 2);//4
//System.Console.WriteLine(z);

//var s1 = "";
//var s2 = "";
//var s2 = s1 = s2 = "Mohamed";

#endregion

#region Null Coalescing Operator
////var s1 = null; // Error
//string s1 = null; //  no Error
//s1 = s1 ?? "Mohamed"; // ?? -> check on s1 value is null or not
//s1 = s1 ?? "someoneelse";


//System.Console.WriteLine(s1);

#endregion

#region Conditional Null ?
//string s1 = null; // s1 = ""
////string s2 = "";
////var s2 = s1.ToUpper(); //abc =ABC System.NullReferenceException
//var s2 = s1?.ToUpper();// Conditional Null ?
//System.Console.WriteLine(s2); // return null
//var s3 = s1 is null ? null : s1.ToUpper();
//System.Console.WriteLine(s3);
#endregion

#region  Blocks Statment
//System.Console.WriteLine("hi");//1
//{
//    System.Console.WriteLine("hi");//2
//    System.Console.WriteLine("hello");//3
//};
#endregion

#region Declaration Statment
//int x;

#endregion

#region Expression Statment
// 1. cjange state
//var name = "Mohamed";
//// 2.Assignment
//name = name + "A.";

//// 3.call something that change the state
//name = name.ToUpper();
//System.Console.WriteLine(name);
#endregion

#region Increment & Decrement
//var totalfrinds = 150;
//++totalfrinds;
//System.Console.WriteLine(totalfrinds);

//--totalfrinds;
//System.Console.WriteLine(totalfrinds);

//var x = 2;
//System.Console.WriteLine(x++);//22 Post Increment
//System.Console.WriteLine(x);//3


#endregion

#region Object Instansiation
//Object o = new Object();

#endregion


#region Selection Statment If ,If else 
// IF
//var mark = 90;
//if (mark >= 90)
//{
//    System.Console.WriteLine("Excellent");
//}

//if else
//var mark = 55;
//if (mark >= 60)
//{
//    System.Console.WriteLine("Pass");
//}
//else if (mark >= 55)
//{
//    System.Console.WriteLine("you have a chance in a make up exame");
//}
//else
//{
//    System.Console.WriteLine("Fail");
//}

//if (mark >= 60)
//{
//    if (mark >= 85)
//    {
//        System.Console.WriteLine("Excellent");
//    }
//}
//else if (mark >= 55)
//{
//    System.Console.WriteLine("you have a chance in a make up exame");
//}
//else
//{
//    System.Console.WriteLine("Fail");
//}

#endregion


#region Selection Statment Switch
//switch
//var amountJod = 100;
//var currType = "EUR";
//var output = 0d;

//// JOD => USD =1.41, JOD => EUR = 1.19, JOD => CAD =1.78
//var JODTOUSD = 1.41d;
//var JODTOEUR = 1.19d;
//var JODTOCAD = 1.78d;

//switch (currType)
//{
//    case "USD":
//        output = amountJod * JODTOUSD;
//        System.Console.WriteLine($"{amountJod} JOD = {output} USD");
//        break;
//    case "EUR":
//        output = amountJod * JODTOEUR;
//        System.Console.WriteLine($"{amountJod} JOD = {output} EUR");


//        break;
//    case "CAD":
//        output = amountJod * JODTOCAD;
//        System.Console.WriteLine($"{amountJod} JOD = {output} CAD");
//        break;

//    default:
//        System.Console.WriteLine("Unknown Currency Type");
//        break;
//}
//System.Console.WriteLine($"");

//var num = 3;

//switch (num)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 9:

//        System.Console.WriteLine("ODD");
//        break;

//    case 2:
//    case 4:
//    case 6:
//    case 8:
//        System.Console.WriteLine("Even");
//        break;

//}

// Switch on Types
//object o = 3;
//object o = "Mohamed";

//switch (o)
//{
//    case int i:
//        System.Console.WriteLine($"Its int, sqr of {i} = {i * i}");
//        break;

//    case string i:
//        System.Console.WriteLine($"Its string, capitalization of {i} = {i.ToUpper()}");
//        break;
//    default:
//        break;
//}

//bool isVip = true;
//Pridicate

//switch (isVip)
//{
//    case bool i when i == true:
//        System.Console.WriteLine("yes");
//        break;
//    case bool i:
//        System.Console.WriteLine("no");
//        break;
//    default:
//        break;
//}

// Switch Expression C#8
//var cardNo = 13;
//string v = cardNo switch
//{
//    1 => "ACE",
//    13 => "KINO",
//    12 => "QUEEN",
//    10 => "JACK",
//       => cardNo.ToString()

//};
//string cardName = v;
//System.Console.WriteLine(cardName);


#endregion


#region Iterations
//System.Console.WriteLine(1);
//System.Console.WriteLine(2);
////..........
//System.Console.WriteLine(10);
// While
//var counter = 0;
//while (counter < 10) // test first and excution
//{
//    System.Console.Write(counter + " ");
//    ++counter;
//}
//System.Console.WriteLine();
//counter = 0;
////Do While

//do // // excution first and test atleast excution 1tines
//{

//    System.Console.Write(counter + " ");
//    ++counter;
//}
//while (counter < 10);

// for Loop
//for (var counter = 0; counter < 10; ++counter)
//{
//    System.Console.Write(counter + " ");
//}
//Fibonacci [0,1,1,2,3,5,8,13,21,34]
//for (int counter = 0, prev = 0, current = 1; counter < 10; ++counter)
//{
//    System.Console.Write(prev + " ");
//    int newFib = prev + current;
//    prev = current;
//
//  current = newFib;
//}
//for (; ; )//infinit loop
//{
//    System.Console.WriteLine("infinit loop");
//}

//for each
//foreach (char c in "Full Stack Dveloper Course")
//{
//    System.Console.Write(c + " ");
//}
//var arr = new[] { 1, 2, 4 };

//foreach (var n in arr)
//{
//    System.Console.Write(n + " ");
//}

//System.Console.WriteLine();
//for (var i = 0; i < arr.Length; i++)
//{
//    System.Console.Write(arr[i] + " ");
//}
#endregion


#region Jump Statment
// Jump [break, continue, goto, return]
//break
//var i = 0;
//while (i < 10)
//{
//    if (i > 5)
//        break;// end loop
//    System.Console.WriteLine(i);
//    ++i;
//}

//continue
//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 != 0)
//        continue;
//    System.Console.Write(i + " ");
//}

//goto
//var i = 0;
//start: // lable
//if (i < +5) // as for loop
//{
//    System.Console.Write(i + " ");
//    ++i;
//    goto start;// as for loop
//    System.Console.WriteLine("Mohaned";
//}
#endregion

//return
//var input = .44m;
//var result = AsPercent(input);
//System.Console.WriteLine(result);


//static decimal AsPercent(decimal amount)
//{
//    return amount * 100;
//}

