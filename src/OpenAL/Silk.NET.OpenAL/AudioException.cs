// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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