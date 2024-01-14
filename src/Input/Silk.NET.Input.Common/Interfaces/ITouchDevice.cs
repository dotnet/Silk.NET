// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Silk.NET.Input
{
    /// <summary>
    /// An interface representing a touch device.
    /// </summary>
    public interface ITouchDevice : IInputDevice
    {
        /// <summary>
        /// The known fingers this touch device has tracked.
        /// </summary>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Global
        IReadOnlyDictionary<long, TouchFinger> Fingers { get; }

        /// <summary>
        /// A recognizer for gestures.
        /// </summary>
        TouchGestureRecognizer GestureRecognizer { get; }

        /// <summary>
        /// Checks if a specific finger is currently down on the touch surface.
        /// </summary>
        /// <param name="index">The finger index to check.</param>
        /// <returns>Whether or not the finger is pressed down.</returns>
        bool IsFingerDown(long index);

        /// <summary>
        /// Called when a finger touches the surface.
        /// </summary>
        event Action<ITouchDevice, TouchFinger>? FingerDown;

        /// <summary>
        /// Called when a finger is lifted from the surface.
        /// </summary>
        event Action<ITouchDevice, TouchFinger>? FingerUp;

        /// <summary>
        /// Called when the finger is moved while on the surface.
        /// </summary>
        event Action<ITouchDevice, TouchFinger, Vector2>? FingerMove;
    }
}
