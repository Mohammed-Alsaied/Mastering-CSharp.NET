#region Data Type & Objects
//Object Base CLass
//int x;
//Int32 x1;
//Int16 s;// short s; => 16 bit
//Int32 x;// int x; => 32 bit
//Int64 l;// long l; => 64 bit
//short sh; // -32767 - 32768;
//ushort ush; // 0 - 65???;
//UInt16 uns2;
#endregion

#region Implicit Conversion
//var num = 10;
//string str = "10"; // C# Strongly Typed Language,Compile time Error
//int num2 = str;

// int 32 (int) - int 64 (long)



#endregion

#region Explist Casting
//int numberInt = 100;
//long numberLong = numberInt;

//long nL = 1000;
//if (nL <= Int32.MaxValue)
//{
//    // int n = nL;// Compiler run time
//    int n = (int)nL;
//}

//double d = 1234.8;
//int i = (int)d;
//Console.WriteLine(i);//1234

#endregion

#region Boxing & UnBoxing
// Boxing , UnBoxing
// Boxing => Conversion from Value Type to Reference Type
//int x = 10;// value type
//object obj;// reference type
//obj = x; // Conversion done Implicity
//int y = (int)obj;// UnBoxing ,Conversion from Reference Type to Value Type
#endregion

#region Convert From String to a numerical one
//string stringValue = "120";
//string stringValue = "w120"; // System.Format Exception
//string stringValue = "999999999999999999999999999990";//System.OverflowException
//int number = stringValue;

// 1)type.Parse() => int.Parse();,double.Parse()....
//int number = int.Parse(stringValue);
//System.Console.WriteLine(number);

// 2) TryParse()
//if (int.TryParse(stringValue, out int number))
//{
//    System.Console.WriteLine(number);
//}
//else
//{
//    System.Console.WriteLine("invalid number provided or doesnt fit integer");
//}

//3)Convert Class
//var i = Convert.ToInt32(stringValue);
//Console.WriteLine(i);
#endregion

#region Bit Converter & Values
///var number = 255;
//var number = 10;

//var bytes = BitConverter.GetBytes(number);
//foreach (var b in bytes)
//{
//    Console.WriteLine(b);
//}
// Convert from binary to  string
//foreach (var b in bytes)
//{
//    var binary = Convert.ToString(b, 2).PadLeft(8, '0');
//    Console.WriteLine(binary);
//}

// Convert from string to  binary or Hexadecimal
//var name = "Mohamed";
//char[] letters = name.ToCharArray();
//foreach (var l in letters)
//{
//    int ascii = Convert.ToInt32(l);
//    var output = $"'{l}'->ASCII: {ascii}, Binary: {Convert.ToString(ascii, 2).PadLeft(8, '0')},Hexadecimal: {ascii:x}";
//    Console.WriteLine(output);
//}

//string[] hexaValues = { "49", "73", "73", "61", "6D", };
//foreach (var hex in hexaValues)
//{
//    int value = Convert.ToInt32(hex, 16);
//    var stringValue = char.ConvertFromUtf32(value);//#1 Convert form int to char
//    var ch = (char)value;//#2
//    Console.WriteLine(stringValue);
//    Console.WriteLine(ch);
//}
//var hex = "8E2";
//int number = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
//Console.WriteLine(number);

#endregion

