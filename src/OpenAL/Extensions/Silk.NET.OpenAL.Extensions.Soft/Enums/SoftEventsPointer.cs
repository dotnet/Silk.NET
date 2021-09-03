// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="IntPtr" /> <see cref="IStateSoft.GetPointer" /> parameters.
    /// </summary>
    public enum SoftEventsPointer
    {
        /// <summary>
        /// Gets a pointer to the set event callback function.
        /// </summary>
        EventCallbackFunction = 0x1220,

        /// <summary>
        /// Gets a pointer to the set event callback user parameter.
        /// </summary>
        EventCallbackUserParameter = 0x1221
    }
}