using System;
using System.Collections.Generic;

namespace DigitsRecognizer
{
    public class Classifier : IClassifier
    {
		private IEnumerable<Observation> data;
		private readonly IDistance distance;

		public Classifier(IDistance distance)
		{
			this.distance = distance;
		}
	
        public string Predict(int[] Pixels)
        {
			Observation currentBest = null;
			var shortest = Double.MaxValue;
			foreach (Observation observation in data)
			{
				var dis = distance.Between(observation.Pixels, Pixels);
				if(dis < shortest)
				{
					shortest = dis;
					currentBest = observation;
				}
			}

			return currentBest.Label;
        }

        public void Train(IEnumerable<Observation> TrainingSet)
        {
			this.data = TrainingSet;
        }
    }
}
