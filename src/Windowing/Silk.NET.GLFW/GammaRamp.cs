// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Gamma ramp for a <see cref="Monitor" />.
    /// </summary>
    public unsafe struct GammaRamp
    {
        /// <summary>
        /// Red components of the gamma ramp.
        /// </summary>
        public short* Red;

        /// <summary>
        /// Green components of the gamma ramp.
        /// </summary>
        public short* Green;

        /// <summary>
        /// Blue components of the gamma ramp.
        /// </summary>
        public short* Blue;

        /// <summary>
        /// Length of the arrays.
        /// </summary>
        public uint Size;
    }
}