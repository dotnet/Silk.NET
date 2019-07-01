// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to set the OpenGlProfile attribute.
    /// </summary>
    /// <seealso cref="IGlfw.WindowHint(WindowHintOpenGlProfile,OpenGlProfile)" />
    public enum WindowHintOpenGlProfile
    {
        /// <summary>
        /// Indicates the OpenGL profile used by the context.
        /// This is <see cref="NET.GLFW.OpenGlProfile.Core" />
        /// or <see cref="NET.GLFW.OpenGlProfile.Compat" />
        /// if the context uses a known profile, or <see cref="NET.GLFW.OpenGlProfile.Any" />
        /// if the OpenGL profile is unknown or the context is an OpenGL ES context.
        /// Note that the returned profile may not match the profile bits of the context flags,
        /// as GLFW will try other means of detecting the profile when no bits are set. TODO: enum for missing crefs
        /// </summary>
        OpenGlProfile = 0x00022008
    }
}