//
// AudioException.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to the OpenToolkit.Audio subsystem.
    /// </summary>
    public class AudioException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioException"/> class.
        /// </summary>
        public AudioException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioException"/> class.
        /// </summary>
        /// <param name="message">The error message of the AudioException.</param>
        public AudioException(string message)
            : base(message)
        {
        }
    }
}
