using System;

namespace DigitsRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/payam/Code/machine-learning-projects-for-dot-net-developers/chapter-1/DigitsRecognizer/Data/trainingsample.csv";
            var training = DataReader.ReadObservations(path);
            Console.ReadLine();
        }
    }
}
