//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents the context API, and associated configuration, that the window should use.
    /// </summary>
    /// <remarks>
    /// <para>
    /// By default, this struct uses OpenGL 3.3, core profile, forward-compatable.
    /// </para>
    /// </remarks>
    public struct GraphicsAPI
    {
        /// <summary>
        /// The rendering API to use.
        /// </summary>
        public ContextAPI API { get; set; }
        
        /// <summary>
        /// The profile to use.
        /// </summary>
        public ContextProfile Profile { get; set; }

        /// <summary>
        /// Context creation flags.
        /// </summary>
        public ContextFlags Flags { get; set; }

        /// <summary>
        /// The version of the API to use.
        /// </summary>
        public Version APIVersion { get; set; }
    }
}