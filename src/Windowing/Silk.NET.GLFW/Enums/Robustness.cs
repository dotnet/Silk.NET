// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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