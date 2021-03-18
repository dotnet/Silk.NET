// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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