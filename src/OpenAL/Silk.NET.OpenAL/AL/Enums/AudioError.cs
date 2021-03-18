// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Returned by AL.GetError.
    /// </summary>
    public enum AudioError
    {
        /// <summary>
        /// No OpenAL Error.
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Invalid Name paramater passed to OpenAL call.
        /// </summary>
        InvalidName = 0xA001,

        /// <summary>
        /// Invalid parameter passed to OpenAL call.
        /// </summary>
        IllegalEnum = 0xA002,

        /// <summary>
        /// Invalid parameter passed to OpenAL call.
        /// </summary>
        InvalidEnum = 0xA002,

        /// <summary>
        /// Invalid OpenAL enum parameter value.
        /// </summary>
        InvalidValue = 0xA003,

        /// <summary>
        /// Illegal OpenAL call.
        /// </summary>
        IllegalCommand = 0xA004,

        /// <summary>
        /// Illegal OpenAL call.
        /// </summary>
        InvalidOperation = 0xA004,

        /// <summary>
        /// No OpenAL memory left.
        /// </summary>
        OutOfMemory = 0xA005
    }
}