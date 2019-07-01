// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to invalid values.
    /// </summary>
    public class AudioValueException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioValueException" /> class.
        /// </summary>
        public AudioValueException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioValueException" /> class.
        /// </summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioValueException(string message)
            : base(message)
        {
        }
    }
}