// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// The vertical synchronization mode to use.
    /// </summary>
    public enum VSyncMode
    {
        /// <summary>
        /// VSync is disabled.
        /// </summary>
        Off = 0,

        /// <summary>
        /// VSync is enabled.
        /// </summary>
        On,

        /// <summary>
        /// Use adaptive VSync. If the window has failed to reach the target framerate for five consecutive frames,
        /// VSync will be disabled. Otherwise, it will be enabled. If the framerate is uncapped, this is the same as
        /// <see cref="On" />.
        /// </summary>
        [Obsolete
        (
            "Adaptive VSync has been deprecated and usage is not recommended. If you need this sort " +
            "of behaviour, we recommend implementing your own synchronization systems. " +
            "This feature will be removed in 2.0 and the VSync property replaced with a boolean."
        )]
        Adaptive
    }
}
