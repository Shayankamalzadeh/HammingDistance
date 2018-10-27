using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamming
{

    /// <summary>
    /// the Hamming distance between two strings of equal length is the number of
    /// positions at which the corresponding symbols are different. In other words,
    /// it measures the minimum number of substitutions required to change one string
    /// into the other, or the minimum number of errors that could have transformed
    /// one string into the other. In a more general context, the Hamming distance
    /// is one of several string metrics for measuring the edit distance between
    /// two sequences. It is named after the American mathematician
    /// Richard Hamming (1915-1998).
    /// 
    /// 
    /// </summary>
    public class Hamming
    {
        private int _count = 0;
        /// <summary>
        ///Calculate Hamming Distance between two string parameters.
        ///Two parameters must have same Lenght
        /// </summary>
        /// <param name="s1"> First parameter must be string</param>
        /// <param name="s2">Second parameter must be string</param>
        /// <returns></returns>
        public int HamingSpace(string s1, string s2)
        {

            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                throw new Exception("arguments are null or Empty");
            }
            if (s1.Length != s2.Length)
            {
                throw new Exception("arguments length are not same");
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (!s1.ToUpper()[i].Equals(s2.ToUpper()[i]))
                {
                    _count++;
                }

            }

            return _count;
        }
    }
}
