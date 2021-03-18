// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to an <see cref="AudioContext" />.
    /// </summary>
    public class AudioContextException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContextException" /> class.
        /// </summary>
        public AudioContextException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContextException" /> class.
        /// </summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioContextException(string message)
            : base(message)
        {
        }
    }
}