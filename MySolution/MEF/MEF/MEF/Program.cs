using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//System.ComponentModel.Composition.dll

/*
 *
 *  to use this program, start the debugger
 *  Then enter some kind of text, like: "output" hit enter
 *  Then type in "pdf" all lower case.
 *
 *
 *
 *
 * */

namespace MEF
{
    public class Car
    {
        [Import]
        private Engine Engine;
        [Import]
        private door Door;

        public void Drive()
        {
            this.Engine.Start();
        }

    }
    [Export]
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Start");
        }
    }
    [Export]
    public class door
    {
        public void Open()
        {
            Console.WriteLine("Open");
        }
    }

    class PrintOperations
    {
        [Export]
        [ExportMetadata("Op","print")]
        public string PrintMessage(string input, string method)
        {
            //return "white";
            return input;
        }
        [Export]
        [ExportMetadata("Op", "csv")]
        public string PrintCSV(string input, string method)
        {
            //return "white";
            return "Outputting to a csv" + input;
        }
        [Export]
        [ExportMetadata("Op", "pdf")]
        public string PrintPDF(string input, string method)
        {
            //return "white";
            return "Outputting to a PDF" + input;
        }
    }
    [Export]
    class Print
    {
        [ImportMany]
        IEnumerable<Lazy<Func<string, string, string>, Dictionary<string, object>>> computationMethods;

        public string printer(string input, string method)
        {
           // var calculation = parseCar(input);
            var actionToRun = computationMethods.First(c => c.Metadata["Op"].ToString().Equals(method));
            string result = actionToRun.Value(input, method);

            return result;
        }
    }

    #region old

    //class CalculationModel
    //{
    //    public int Input1 { get; set; }
    //    public int Input2 { get; set; }
    //    public string Operation { get; set; }
    //}
    //class HelperMethods
    //{
    //    [Export("CalculationParser")]
    //    public CalculationModel Parse(string input)
    //    {
    //        Regex regex = new Regex(@"(\d+)(.)(\d+)");
    //        Match match = regex.Match(input);

    //        CalculationModel calculation = new CalculationModel()
    //        {
    //            Input1 = int.Parse(match.Groups[1].Value),
    //            Input2 = int.Parse(match.Groups[3].Value),
    //            Operation = match.Groups[2].Value
    //        };

    //        return calculation;
    //    }
    //}
    //class CalculatorOperations
    //{
    //    [Export]
    //    [ExportMetadata("Op", "+")]
    //    public int Add(int input1, int input2)
    //    {
    //        return input1 + input2;
    //    }

    //    [Export]
    //    [ExportMetadata("Op", "-")]
    //    public int Subtract(int input1, int input2)
    //    {
    //        return input1 - input2;
    //    }

    //    [Export]
    //    [ExportMetadata("Op", "*")]
    //    public int Multiply(int input1, int input2)
    //    {
    //        return input1 * input2;
    //    }

    //    [Export]
    //    [ExportMetadata("Op", "/")]
    //    public int Divide(int input1, int input2)
    //    {
    //        return input1 / input2;
    //    }
    //    [Export]
    //    [ExportMetadata("Op", "%")]
    //    public int Modulus(int input1, int input2)
    //    {
    //        return input1 % input2;
    //    }
    //}
    //[Export]
    //class Calculator
    //{
    //    [ImportMany]
    //    IEnumerable<Lazy<Func<int, int, int>, Dictionary<string, object>>> computationMethods;

    //    [Import("CalculationParser")]
    //    Func<string, CalculationModel> parseCalculation;

    //    public int Calculate(string input)
    //    {
    //        var calculation = parseCalculation(input);
    //        var actionToRun = computationMethods.First(c => c.Metadata["Op"].ToString().Equals(calculation.Operation));
    //        int result = actionToRun.Value(calculation.Input1, calculation.Input2);

    //        return result;
    //    }
    //}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);

            #region old
            //Possibility1
            //Car car = new Car();
            //container.ComposeParts(car);

            //car.Drive();
            //Console.Read();

            //POssibility2
            //foreach(ComposablePartDefinition p in container.Catalog.Parts)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            //var engine = container.GetExportedValue<Engine>();
            //var door = container.GetExportedValue<door>();


            //engine.Start();
            //door.Open();

            //var calculator = container.GetExportedValue<Calculator>();

            //while (true)
            //{
            //    Console.Write("Enter calculation: ");
            //    string input = Console.ReadLine();

            //    Console.WriteLine("Result: {0}", calculator.Calculate(input));
            //}
            #endregion
            var print = container.GetExportedValue<Print>();

            while (true)
            {
                Console.Write("Enter something to Print: ");
                string input = Console.ReadLine();
                Console.WriteLine("Which method:");
                string method = Console.ReadLine();

                Console.WriteLine("Result: {0}", print.printer(input, method));
            }



          //  Console.Read();

        }
    }
}
