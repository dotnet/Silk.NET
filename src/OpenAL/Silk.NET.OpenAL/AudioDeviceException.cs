// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to a <see cref="Device" />.
    /// </summary>
    public class AudioDeviceException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceException" /> class.
        /// </summary>
        public AudioDeviceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceException" /> class.
        /// </summary>
        /// <param name="message">The error message of the AudioDeviceException.</param>
        public AudioDeviceException(string message)
            : base(message)
        {
        }
    }
}