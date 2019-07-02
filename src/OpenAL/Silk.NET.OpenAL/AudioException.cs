// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to the audio subsystem.
    /// </summary>
    public class AudioException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioException" /> class.
        /// </summary>
        public AudioException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioException" /> class.
        /// </summary>
        /// <param name="message">The error message of the AudioException.</param>
        public AudioException(string message)
            : base(message)
        {
        }
    }
}