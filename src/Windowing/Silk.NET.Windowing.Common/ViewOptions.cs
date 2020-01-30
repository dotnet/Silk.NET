// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all view properties, used for view creation.
    /// </summary>
    public struct ViewOptions : IViewProperties
    {
        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; set; }
        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }
        /// <inheritdoc />
        Size IViewProperties.Size => throw new InvalidOperationException("Can't get the size of a non-existent view.");
        /// <inheritdoc />
        public double FramesPerSecond { get; set; }
        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }
        /// <inheritdoc />
        public GraphicsAPI API { get; set; }
        /// <inheritdoc />
        public VSyncMode VSync { get; set; }
        /// <inheritdoc />
        public int RunningSlowTolerance { get; set; }
        /// <inheritdoc />
        public VideoMode VideoMode { get; set; }
        /// <inheritdoc />
        public int? PreferredDepthBufferBits { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct.
        /// </summary>
        public ViewOptions
        (
            bool useSingleThreadedWindow,
            double framesPerSecond,
            double updatesPerSecond,
            GraphicsAPI api,
            VSyncMode vSync,
            int isRunningSlowlyThreshold,
            bool shouldSwapAutomatically,
            VideoMode videoMode,
            int? preferredDepthBufferBits = null
        )
        {
            UseSingleThreadedWindow = useSingleThreadedWindow;
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            VSync = vSync;
            RunningSlowTolerance = isRunningSlowlyThreshold;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
        }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible defaults.
        /// </summary>
        public static ViewOptions Default { get; } = new ViewOptions
        (
            true, 0.0, 0.0, GraphicsAPI.Default, VSyncMode.On, 5, true, VideoMode.Default
        );

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible values, intended for use with Vulkan.
        /// </summary>
        public static ViewOptions DefaultVulkan { get; } = new ViewOptions
        (
            true, 0.0, 0.0, GraphicsAPI.DefaultVulkan, VSyncMode.On, 5, true, VideoMode.Default
        );
    }
}
