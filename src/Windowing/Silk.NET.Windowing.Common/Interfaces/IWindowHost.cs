// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents a host on which windows can be created.
    /// </summary>
    public interface IWindowHost
    {
        /// <summary>
        /// Creates a window on this host.
        /// </summary>
        /// <remarks>
        /// If the window host is a monitor, the window will be created on the given monitor.
        /// If the window host is another window, if the underlying API supports it a child window will be created
        /// with the current window as the parent.
        /// If the window host is a window platform, the window may be created on any monitor (usually the main monitor)
        /// and will have no parent window. Note that the GLFW backend does not support child windows.
        /// </remarks>
        /// <returns>The created window.</returns>
        IWindow CreateWindow(WindowOptions opts);
    }
}
