#region Boolean & Expression
//bool isVip = true;

//var x = 10; // assign 10 to variable x
//var y = 10;

////Console.WriteLine(x == y);// x is equal to y? => true
////performance is best
//// Expression (1+2+3) =6  اي شى اقدر استعيد عنه بقيمة واحده
//var z = x == y; //true
////Readability is best
//System.Console.WriteLine(z);
#endregion

#region Comparison Operartor
//var total = 1000;
//var vipThreshold = 900;

//var isVip = total >= vipThreshold;//>,<,<=  Evaluation for Right Expression stored in Left side

//System.Console.WriteLine(isVip);
#endregion

#region Negation

//var isVip = !true;
//System.Console.WriteLine(isVip);//false
#endregion

#region Conditional Operators

// && ||

// 1+2=3
// Logical And &&
//System.Console.WriteLine(true && true);//true
//var isFirstFive = true;
//var GPA = 3.5;//3.5/4
////var isElegibleScholarship = GPA >= 3.5 && isFirstFive;//true
//var isElegibleScholarship = GPA >= 3.5 || isFirstFive;
//System.Console.WriteLine(isElegibleScholarship);
//System.Console.WriteLine(true && false);//false
//System.Console.WriteLine(false && true);//false
//System.Console.WriteLine(false && false);//false
//System.Console.WriteLine("-----------------------------------");

//// Logical Or ||
//System.Console.WriteLine(true || true);//true
//System.Console.WriteLine(true || false);//true
//System.Console.WriteLine(false || true);//true
//System.Console.WriteLine(false || false);//false
//System.Console.WriteLine("-----------------------------------");


//// Logical XOR ^
//System.Console.WriteLine(true ^ false);//true
//System.Console.WriteLine(true ^ true);//false
//System.Console.WriteLine(false ^ true);//true
//System.Console.WriteLine(false ^ false);//false
//System.Console.WriteLine("-----------------------------------");


#endregion

#region Short Circuit
// && || short circuit
// & |

//System.Console.WriteLine(true & true);//true
//System.Console.WriteLine(true & false);//false
//System.Console.WriteLine(false & true);//false
//System.Console.WriteLine(false & false);//false

//System.Console.WriteLine((true & true) == (true & true));//true
//System.Console.WriteLine((true & false) == (true & false));//true
//System.Console.WriteLine((false & true) == (false & true));//true
//System.Console.WriteLine((false & false) == (false & false));//true

//bool value = true || Check(); // faster
//bool value = true | Check(); // slower

//static bool Check()
//{
//    System.Console.WriteLine("Checking.....");
//    return true;
//}

#endregion

#region == Reference Type

//var x = 1;
//var y = 1;
//// Compared the values (Value Type)
//var z = x == y;//true
//System.Console.WriteLine(z);

//// Compared the references (reference Type)
////equal operator overloading for string only
//var s1 = "hello";
//var s2 = "hello";
//var s3 = s1 == s2;
//System.Console.WriteLine(s3);//true

#endregion

#region Ternary Operator
//var total = 900;
//var VipThreshold = 100;
////var isVip = total >= VipThreshold;
//var isVip = total >= VipThreshold ? true : false;
//var discount = total >= VipThreshold ? 0.05m : 0.0m;


#endregion