// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents an axis on a joystick.
    /// </summary>
    public readonly struct Axis
    {
        /// <summary>
        /// The index of this axis, used to determine which axis it is.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The position of this axis.
        /// </summary>
        public float Position { get; }

        /// <summary>
        /// Creates a new instance of the Axis struct.
        /// </summary>
        /// <param name="index">The index of the new axis.</param>
        /// <param name="position">The position of the new axis.</param>
        public Axis(int index, float position)
        {
            Index = index;
            Position = position;
        }
    }
}
