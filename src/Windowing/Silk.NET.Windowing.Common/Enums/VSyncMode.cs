//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

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
        /// VSync will be disabled. Otherwise, it will be enabled. If the framerate is uncapped, this is the same as <see cref="On"/>. 
        /// </summary>
        Adaptive,
    }
}
