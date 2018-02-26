using System;

namespace DigitsRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
			Distance distance = new Distance();
			var classifier = new Classifier(distance);

			var trainingPath = @"C:\Code\machine-learning-projects-for-dot-net-developers\chapter-1\DigitsRecognizer\Data\trainingsample.csv";

			var training = DataReader.ReadObservations(trainingPath);
			classifier.Train(training);

			var validationPath = @"C:\Code\machine-learning-projects-for-dot-net-developers\chapter-1\DigitsRecognizer\Data\validationsample.csv";
			var validation = DataReader.ReadObservations(validationPath);

	        var correct = Evaluator.Evaluator.Correct(validation, classifier);

			Console.WriteLine($"Correctly classified: {correct}");

	        Console.Read();
        }
    }
}
