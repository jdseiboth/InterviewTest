using System;
using InterviewTest.BinaryData;

namespace InterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string file0 = "file_0.bin";
            const string file1 = "file_1.bin";
            const string file2 = "file_2.bin";

            FileReader reader = new FileReader();
            BinFile bin0 = reader.Read("../../" + file0);
            BinFile bin1 = reader.Read("../../" + file1);
            BinFile bin2 = reader.Read("../../" + file2);

            const string comparisonString = "Comparing equality of {0} against {1}";
            const string resultString = "Result: {0}\n";

            Console.WriteLine("\n" + comparisonString, file0, file1);
            Console.WriteLine(resultString, bin0.Equals(bin1));

            Console.WriteLine(comparisonString, file0, file2);
            Console.WriteLine(resultString, bin0.Equals(bin2));

            Console.WriteLine(comparisonString, file1, file2);
            Console.WriteLine(resultString, bin1.Equals(bin2));

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
