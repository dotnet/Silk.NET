// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a joystick hat.
    /// </summary>
    public struct Hat
    {
        /// <summary>
        /// The index of this hat.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The position of this hat.
        /// </summary>
        public Position2D Position { get; }

        /// <summary>
        /// Creates a new instance of the Hat struct.
        /// </summary>
        /// <param name="index">The index of the hat.</param>
        /// <param name="position">The position of the hat.</param>
        public Hat(int index, Position2D position)
        {
            Index = index;
            Position = position;
        }
    }
}
