// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// A rumble motor inside of a gamepad.
    /// </summary>
    public interface IMotor
    {
        /// <summary>
        /// The index of this vibration motor.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// The motor's vibration intensity, between 0f and 1f.
        /// </summary>
        /// <remarks>
        /// Some backends may truncate this value if variable intensity is not supported.
        /// </remarks>
        float Speed { get; set; }
    }
}
