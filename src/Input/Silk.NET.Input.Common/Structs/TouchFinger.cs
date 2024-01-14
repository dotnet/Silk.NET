// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a touch finger.
    /// </summary>
    public readonly struct TouchFinger
    {
        /// <summary>
        /// The index of the finger.
        /// </summary>
        public long Index { get; }

        /// <summary>
        /// The last known position of the finger.
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        /// The last known normalized position of the finger.
        /// </summary>
        public Vector2 NormalizedPosition { get; }

        /// <summary>
        /// The last known speed of the finger.
        /// </summary>
        public Vector2 Speed { get; }

        /// <summary>
        /// The last known normalized speed of the finger.
        /// </summary>
        public Vector2 NormalizedSpeed { get; }

        /// <summary>
        /// Finger down on the touch surface.
        /// </summary>
        public bool Down { get; }

        /// <summary>
        /// Creates a new instance of the touch finger struct.
        /// </summary>
        /// <param name="index">The index of the finger.</param>
        /// <param name="position">The position of the finger.</param>
        /// <param name="normalizedPosition">The normalized position of the finger.</param>
        /// <param name="speed">The speed of the finger.</param>
        /// <param name="normalizedSpeed">The normalized speed of the finger.</param>
        /// <param name="down">Boolean which is true if the finger is down.</param>
        public TouchFinger(long index, Vector2 position, Vector2 normalizedPosition, Vector2 speed, Vector2 normalizedSpeed, bool down)
        {
            Index = index;
            Position = position;
            NormalizedPosition = normalizedPosition;
            Speed = speed;
            NormalizedSpeed = normalizedSpeed;
            Down = down;
        }
    }
}
