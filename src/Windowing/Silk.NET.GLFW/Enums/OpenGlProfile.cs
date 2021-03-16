// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// The OpenGL context profiles.
    /// </summary>
    public enum OpenGlProfile
    {
        /// <summary>
        /// Used for unknown OpenGL profile or OpenGL ES.
        /// </summary>
        Any = 0,

        /// <summary>
        /// Known OpenGL Core profile.
        /// </summary>
        Core = 0x00032001,

        /// <summary>
        /// Known OpenGL compatibility profile.
        /// </summary>
        Compat = 0x00032002
    }
}