// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to set context robustness attribute.
    /// </summary>
    /// <seealso cref="IGlfw.WindowHint(WindowHintRobustness,Robustness)" />
    public enum WindowHintRobustness
    {
        /// <summary>
        /// Indicates the robustness strategy used by the context.
        /// This is <see cref="Robustness.LoseContextOnReset" /> or <see cref="Robustness.NoResetNotification" />
        /// if the window's context supports robustness, or <see cref="Robustness.NoRobustness" /> otherwise.
        /// </summary>
        ContextRobustness = 0x00022005
    }
}