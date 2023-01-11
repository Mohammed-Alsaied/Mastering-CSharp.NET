using System;

namespace _027__XML_Documentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("First Name: ");
                var fname = Console.ReadLine();

                Console.Write("Last Name: ");
                var lname = Console.ReadLine();

                Console.Write("Hire Date: ");
                DateTime? hiredate = null;
                if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
                {
                    hiredate = hDate;
                }
                var empId = Generator.GenerateId(fname, lname, hiredate);
                var randomPassword = Generator.GenerateRandomPassword(8);

                Console.WriteLine($"{{\n Id: {empId},\n FName: {fname},\n hore date: {hiredate},\n Password {randomPassword}}}");
            } while (1 == 1);
        }
        /// <summary>
        /// The main Generator Class
        /// </summary>
        /// <remarks>
        /// This class can generate employe Ids and randome password
        /// </remarks>>
        public class Generator
        {
            /// <value>
            /// value of last Id sequence
            /// </value>
            public static int LastIdSequence { get; private set; } = 1;


            /// <summary>
            /// Genrates Employee Id by Processing <paramref name="fname"/>,<paramref name="lname"/>,<paramref name="hireDate"/>
            /// <list type="bullet">
            /// <item>
            /// <term>II</term>
            /// <description>Emplyee Initials (first letter of <paramref name="fname"/> and first letter of <paramref name="lname"/>)</description>
            /// </item>
            /// </list>
            /// </summary>
            /// <param name="fname"></param>
            /// <param name="lname"></param>
            /// <param name="hireDate"></param>
            /// <example>
            /// <code>
            /// var id = Generator.Generator("John,"Smith,new DateTime(2023,01,11,0,0,0)")
            /// Console.WriteLine(id);
            /// </code>
            /// </example>
            /// <returns>
            /// employee as string
            /// </returns>
            /// <exception cref="InvalidOperationException">Thrown when <paramref name="fname"/> is null</exception>
            /// <exception cref="InvalidOperationException">Thrown when <paramref name="lname"/> is null</exception>
            /// <exception cref="InvalidOperationException">Thrown when <paramref name="hireDate"/> is in the past</exception>
            /// See <see cref="Generator.GenerateRandomPassword(int)"/> to Generate Randome password
            public static string GenerateId(string fname, string lname, DateTime? hireDate)
            {
                // II YY MM DD 01

                if (fname is null)
                    throw new InvalidOperationException($"{nameof(fname)} can not be null");

                if (lname is null)
                    throw new InvalidOperationException($"{nameof(lname)} can not be null");
                if (hireDate is null)
                {
                    hireDate = DateTime.Now;
                }
                else
                {
                    if (hireDate.Value.Date < DateTime.Now.Date) // yyyy-MM-dd hh:mm:ss
                        throw new InvalidOperationException($"{nameof(hireDate)} can not be in the past ");
                }

                var yearOfHireDate = hireDate.Value.ToString("yy");
                var monthOfHireDate = hireDate.Value.ToString("MM");
                var dayOfHireDate = hireDate.Value.ToString("dd");

                var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]}" +
                    $"{yearOfHireDate}{monthOfHireDate}{dayOfHireDate}{(LastIdSequence++).ToString().PadLeft(2, '0')}";
                return code;
            }

            public static string GenerateRandomPassword(int length)
            {
                const string ValidScope = "nldlksnoasdnjsbcbefhdiKSJFLKNJNVJXNCSDJFLKJOIRLNVMV0123456789*#@$%^&!";
                var result = "";
                Random rnd = new Random();

                while (0 < length--)
                {
                    result += (ValidScope[rnd.Next(ValidScope.Length)]);
                }
                return result;
            }
        }
    }
}
