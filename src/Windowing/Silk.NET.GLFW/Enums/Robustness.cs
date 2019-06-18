// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// OpenGL context robustness strategy.
    /// </summary>
    public enum Robustness
    {
        /// <summary>
        /// No context robustness strategy.
        /// </summary>
        NoRobustness = 0,

        /// <summary>
        /// Robust context without a reset notification.
        /// </summary>
        NoResetNotification = 0x00031001,

        /// <summary>
        /// Lose context on reset.
        /// </summary>
        LoseContextOnReset = 0x00031002
    }
}