// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
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
