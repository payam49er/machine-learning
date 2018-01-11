using System;
namespace DigitsRecognizer
{
    public interface IDistance
    {
        double Between(int[] pixel1, int[] pixel2);
    }
}
