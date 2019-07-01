//
// AudioDeviceException.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to an OpenToolkit.Audio device.
    /// </summary>
    public class AudioDeviceException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceException"/> class.
        /// </summary>
        public AudioDeviceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDeviceException"/> class.
        /// </summary>
        /// <param name="message">The error message of the AudioDeviceException.</param>
        public AudioDeviceException(string message)
            : base(message)
        {
        }
    }
}
