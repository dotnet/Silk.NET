// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface representing a monitor.
    /// </summary>
    public interface IMonitor : IWindowHost
    {
        /// <summary>
        /// The name of this monitor.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The index of this monitor.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// The bounds of this monitor.
        /// </summary>
        Rectangle Bounds { get; }

        /// <summary>
        /// The current video mode of this monitor.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// This monitor's gamma correction.
        /// </summary>
        float Gamma { get; set; }

        /// <summary>
        /// Get all video modes that this monitor supports.
        /// </summary>
        /// <returns>An array of all video modes.</returns>
        IEnumerable<VideoMode> GetAllVideoModes();
    }
}
