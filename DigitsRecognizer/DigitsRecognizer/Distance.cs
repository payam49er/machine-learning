using System;
namespace DigitsRecognizer
{
    public class Distance : IDistance
    {
        public double Between(int[] pixel1, int[] pixel2)
        {
            if (pixel1.Length != pixel2.Length)
            {
                throw new ArgumentException("Arrays are not of the same size");
            }

            var length = pixel1.Length;
            var distance = 0.0;
            for (int i = 0; i < length; i++)
            {
                distance += Math.Abs(pixel1[i] - pixel2[i]);
            }

            return distance;
        }
    }
}
