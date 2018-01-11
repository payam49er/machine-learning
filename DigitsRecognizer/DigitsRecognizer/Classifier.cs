using System;
using System.Collections.Generic;

namespace DigitsRecognizer
{
    public class Classifier : IClassifier
    {
        public string Predict(int[] Pixels)
        {
            throw new NotImplementedException();
        }

        public void Train(IEnumerable<Observation> TrainingSet)
        {
            throw new NotImplementedException();
        }
    }
}
