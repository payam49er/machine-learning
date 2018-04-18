using System;
using System.Runtime.InteropServices;

namespace DigitsRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var trainingPath = Paths.TrainingPath;
                var validationPath = Paths.ValidationPath;
           
                Distance distance = new Distance();
                var classifier = new Classifier(distance);


                var training = DataReader.ReadObservations(trainingPath);
                classifier.Train(training);

            
                var validation = DataReader.ReadObservations(validationPath);

                var correct = Evaluator.Evaluator.Correct(validation, classifier);

                Console.WriteLine($"Correctly classified: {correct}");

                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        private static (string TrainingPath, string ValidationPath) Paths
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return (trainingPath: Constants.OsxTrainingPath, validationPath: Constants.OsxValidationPath);
                }
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return (trainingPath: Constants.WindowsTrainingPath, validationPath: Constants.WindowsValidationPath);
                }
                return (first: string.Empty, second: string.Empty);
            }
        }
    }
}
