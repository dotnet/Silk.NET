// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core
{
    /// <summary>
    /// An exception thrown when an underlying native platform fails to complete an operation due to an error.
    /// </summary>
    public class PlatformException : Exception
    {
        private const string DefaultMessage =
            "The operation could not be completed due to an error in an underlying native platform.";
        /// <summary>
        /// Creates an instance of this exception with the default message.
        /// </summary>
        public PlatformException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates an instance of this exception with the given message.
        /// </summary>
        /// <param name="msg">The message.</param>
        public PlatformException(string msg) : base(msg)
        {
        }

        /// <summary>
        /// Creates an instance of this exception with the given inner exception.
        /// </summary>
        /// <param name="innerException">The inner exception.</param>
        public PlatformException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        /// <summary>
        /// Creates an instance of this exception with the given message and inner exception.
        /// </summary>
        /// <param name="msg">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public PlatformException(string msg, Exception innerException) : base(msg, innerException)
        {
        }

        /// <summary>
        /// Creates an instance of this exception with the given message and inner exceptions.
        /// </summary>
        /// <param name="msg">The message.</param>
        /// <param name="inner">The inner exceptions.</param>
        public PlatformException(string msg, params Exception[] inner) : base(msg, new AggregateException(inner))
        {
        }
    }
}
