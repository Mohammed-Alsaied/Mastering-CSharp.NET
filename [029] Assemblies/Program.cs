Console.WriteLine("Assemplies");
//C#/VB code=>Metadata(dll,exe) and IL(Intermidiate Language)=>JIT(Just in Time) to Machine Code

//var type = typeof(Employee);
//var assemply = type.Assembly;
//var assemply1 = Assembly.GetExecutingAssembly();
//Console.WriteLine(assemply.FullName);
//Console.WriteLine(assemply1.FullName);
//Console.WriteLine(typeof(DateTime).Assembly.FullName);
//Demo.Trace();
var type = typeof(Program);
var assemply = type.Assembly;
//Console.WriteLine($"Full Name :{assemply.FullName}");
//Console.WriteLine($"Location :{assemply.Location}");
//var assemblyName = assemply.GetName();
//Console.WriteLine($"Name : {assemblyName.Name}");
//Console.WriteLine($"Version : {assemblyName.Version}");
//Console.WriteLine($"Total Key Token Length : {assemblyName.GetPublicKeyToken().Length}");
//Console.WriteLine($"Code : {assemblyName.CodeBase}");
//Console.WriteLine($"DateTime Assembly Time : {typeof(DateTime).Assembly.GetName().Name}");
var stream = assemply.GetManifestResourceStream(type, "data.CountryCodes.json");
var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine((char)data[i]);
}
stream.Close();
namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Employee
    {

    }
}
