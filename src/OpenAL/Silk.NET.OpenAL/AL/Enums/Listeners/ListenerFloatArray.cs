// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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