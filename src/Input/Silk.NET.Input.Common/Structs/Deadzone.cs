// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Input
{
    /// <summary>
    /// The deadzone to use for a joystick/gamepad's sticks.
    /// </summary>
    public readonly struct Deadzone
    {
        /// <summary>
        /// The size of the deadzone to use.
        /// </summary>
        public float Value { get; }

        /// <summary>
        /// The deadzone method to use.
        /// </summary>
        public DeadzoneMethod Method { get; }

        /// <summary>
        /// Creates a new instance of the Deadzone struct.
        /// </summary>
        /// <param name="value">The deadzone size.</param>
        /// <param name="method">The deadzone method.</param>
        public Deadzone(float value, DeadzoneMethod method)
        {
            Value = value;
            Method = method;
        }

        /// <summary>
        /// Applies this deadzone to a raw input value.
        /// </summary>
        /// <param name="raw">The raw input value to apply the deadzone to.</param>
        /// <returns>The input with deadzone applied.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the deadzone method isn't part of
        /// <see cref="DeadzoneMethod"/></exception>
        public float Apply(float raw)
        {
            return Method switch
            {
                DeadzoneMethod.Traditional => (Math.Abs(raw) < Value ? 0 : raw),
                DeadzoneMethod.AdaptiveGradient => ((1 - Value) * raw + Value * Math.Sign(raw)),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
