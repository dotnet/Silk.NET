//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to set context robustness attribute.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(WindowHintRobustness,Robustness)"/>
    public enum WindowHintRobustness
    {
        /// <summary>
        /// Indicates the robustness strategy used by the context.
        /// This is <see cref="Robustness.LoseContextOnReset"/> or <see cref="Robustness.NoResetNotification"/>
        /// if the window's context supports robustness, or <see cref="Robustness.NoRobustness"/> otherwise.
        /// </summary>
        ContextRobustness = 0x00022005,
    }
}
