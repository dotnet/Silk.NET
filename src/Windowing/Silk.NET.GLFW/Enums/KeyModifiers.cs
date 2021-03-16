// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Key modifiers, such as Shift or CTRL.
    /// </summary>
    public enum KeyModifiers
    {
        /// <summary>
        /// if one or more Shift keys were held down.
        /// </summary>
        Shift = 0x0001,

        /// <summary>
        /// If one or more Control keys were held down.
        /// </summary>
        Control = 0x0002,

        /// <summary>
        /// If one or more Alt keys were held down.
        /// </summary>
        Alt = 0x0004,

        /// <summary>
        /// If one or more Super keys were held down.
        /// </summary>
        Super = 0x0008
    }
}