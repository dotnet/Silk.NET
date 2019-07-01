//
// ListenerFloatArray.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

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
        Orientation = 0x100F,
    }
}
