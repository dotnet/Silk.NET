// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Input
{
    /// <summary>
    /// Controls the behavior of the double tap gesture tracking.
    /// </summary>
    [Flags]
    public enum Gesture
    {
        /// <summary>
        /// No gesture.
        /// </summary>
        None = 0,

        /// <summary>
        /// Tap gesture.
        /// </summary>
        Tap = 1,

        /// <summary>
        /// Double tap gesture.
        /// </summary>
        DoubleTap = 2,

        /// <summary>
        /// Swipe gesture.
        /// </summary>
        Swipe = 4,

        /// <summary>
        /// Long hold gesture.
        /// </summary>
        Hold = 8,

        /// <summary>
        /// Zoom gesture.
        /// </summary>
        Zoom = 16,

        /// <summary>
        /// Rotate gesture.
        /// </summary>
        Rotate = 32,

        /// <summary>
        /// All gestures.
        /// </summary>
        All = Tap | DoubleTap | Swipe | Hold | Zoom | Rotate
    }
}
