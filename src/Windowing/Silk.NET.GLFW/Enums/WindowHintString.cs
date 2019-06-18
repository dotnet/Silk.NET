// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Window hints for the WindowHintString function.
    /// </summary>
    public enum WindowHintString
    {
        /// <summary>
        /// Sets the frame name on Cocoa. On any other platform, this does nothing.
        /// </summary>
        CocoaFrameName = 0x00023002,

        /// <summary>
        /// Sets the class name on X11. On any other platform, this does nothing.
        /// </summary>
        X11ClassName = 0x00024001,

        /// <summary>
        /// Sets the instance name on X11. on any other platform, this does nothing.
        /// </summary>
        X11InstanceName = 0x00024002
    }
}