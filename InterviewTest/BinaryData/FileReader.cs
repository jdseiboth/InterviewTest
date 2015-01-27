using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace InterviewTest.BinaryData
{
    public class FileReader
    {
        private readonly Regex _idPart1;
        private readonly Regex _idPart2;

        public FileReader()
        {
            _idPart1 = new Regex(@"^\/ID \[<[A-F0-9]+>$");
            _idPart2 = new Regex(@"^<[A-F0-9]+>\]$");
        }

        public BinFile Read(string filename)
        {
            BinFile bin = null;

            try
            {
                // read file
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    // set stream position to 0 to begin reading
                    stream.Flush();
                    stream.Position = 0;

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        // represents the non-id data of a file
                        StringBuilder data = new StringBuilder();

                        // represents the first half of a file's id
                        string idLine1 = string.Empty;

                        // represents the second half a file's id
                        string idLine2 = string.Empty;

                        Console.WriteLine("Reading file: {0}", Path.GetFileName(stream.Name));
                        string line = reader.ReadLine();
                        
                        while (line != null)
                        {
                            // if the line matches the first half of an id assign it to idLine1
                            if (_idPart1.IsMatch(line))
                            {
                                idLine1 = line;
                            }
                            // if the line matches the second half of an id assign it to idLine2
                            else if (_idPart2.IsMatch(line))
                            {
                                idLine2 = line;
                            }
                            else
                            {
                                data.AppendLine(line);
                            }

                            line = reader.ReadLine();
                        }

                        bin = new BinFile
                            {
                                Id = idLine1 + idLine2,
                                Data = data.ToString()
                            };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return bin;
        }
    }
}
