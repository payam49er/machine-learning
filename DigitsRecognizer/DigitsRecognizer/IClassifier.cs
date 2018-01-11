using System.Collections.Generic;

namespace DigitsRecognizer
{
    public interface IClassifier
    {
        void Train(IEnumerable<Observation> TrainingSet);
        string Predict(int[] Pixels);
    }
}
