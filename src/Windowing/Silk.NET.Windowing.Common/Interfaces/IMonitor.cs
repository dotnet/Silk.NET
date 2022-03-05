// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
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
        Rectangle<int> Bounds { get; }

        /// <summary>
        /// The current video mode of this monitor.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// This monitor's gamma correction.
        /// </summary>
        /// <remarks>
        /// Only supported by GLFW, has no effect on SDL.
        /// </remarks>
        float Gamma { get; set; }

        /// <summary>
        /// Get all video modes that this monitor supports.
        /// </summary>
        /// <returns>An array of all video modes.</returns>
        IEnumerable<VideoMode> GetAllVideoModes();
    }
}