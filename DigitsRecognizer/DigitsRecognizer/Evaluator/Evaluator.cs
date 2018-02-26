using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitsRecognizer.Evaluator
{
	public class Evaluator
    {
		public static double Correct(IEnumerable<Observation> validationSet, IClassifier classifier)
		{
			return validationSet.Select(x => Score(x, classifier)).Average();
		}

		private static Double Score(Observation observation, IClassifier classifier)
		{
			return classifier.Predict(observation.Pixels) == observation.Label ? 1.0 : 0.0;
		}
	}
}
