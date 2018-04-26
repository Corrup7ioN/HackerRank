using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.Emulation
{
    public static class Console
    {
        private static StringReader _inputReader;
        private static StringWriter _outputWriter = new StringWriter();

        public static void SetInput(string input)
        {
            _inputReader = new StringReader(input);
        }

        public static void Clear() 
            => _outputWriter = new StringWriter();

        public static string ReadLine() 
            => _inputReader.ReadLine();

        public static void WriteLine(string s) 
            => new List<Action<string>> { _outputWriter.WriteLine, System.Console.WriteLine }.ForEach(writeLine => writeLine(s));

        public static void Write(string s) 
            => new List<Action<string>> { _outputWriter.Write, System.Console.Write }.ForEach(write => write(s));

        public static string Output 
            => _outputWriter.ToString().TrimEnd();
    }
}
