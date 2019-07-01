//
// AudioContextException.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Represents exceptions related to an OpenToolkit.Audio.AudioContext.
    /// </summary>
    public class AudioContextException : AudioException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContextException"/> class.
        /// </summary>
        public AudioContextException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContextException"/> class.
        /// </summary>
        /// <param name="message">The error message of the AudioContextException.</param>
        public AudioContextException(string message)
            : base(message)
        {
        }
    }
}
