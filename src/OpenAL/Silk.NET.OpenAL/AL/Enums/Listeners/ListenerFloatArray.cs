// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid float[] Listener/GetListener parameters.
    /// </summary>
    public enum ListenerFloatArray
    {
        /// <summary>
        /// Indicate Listener orientation. Expects two Vector3, At followed by Up.
        /// </summary>
        Orientation = 0x100F
    }
}