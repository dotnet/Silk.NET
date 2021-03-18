// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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