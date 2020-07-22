// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Contains all view properties, used for view creation.
    /// </summary>
    public struct ViewOptions : IViewProperties
    {
        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }
        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        Size IViewProperties.Size => throw new InvalidOperationException("Can't get the size of a non-existent view.");
        /// <inheritdoc />
        public double FramesPerSecond { get; set; }
        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }
        /// <inheritdoc />
        public GraphicsAPI API { get; set; }

        /// <inheritdoc />
        public bool VSync { get; set; }

        /// <inheritdoc />
        public VideoMode VideoMode { get; set; }
        /// <inheritdoc />
        public int? PreferredDepthBufferBits { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct.
        /// </summary>
        public ViewOptions
        (
            double framesPerSecond,
            double updatesPerSecond,
            GraphicsAPI api,
            bool isVSync,
            bool shouldSwapAutomatically,
            VideoMode videoMode,
            int? preferredDepthBufferBits = null,
            bool isEventDriven = false
        )
        {
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            IsEventDriven = isEventDriven;
            VSync = isVSync;
        }

        /// <summary>
        /// Creates a ViewOptions struct from the given WindowOptions.
        /// </summary>
        /// <param name="opts">The window options to trim down.</param>
        public ViewOptions(WindowOptions opts)
        {
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
            API = opts.API;
            VideoMode = opts.VideoMode;
            PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            IsEventDriven = opts.IsEventDriven;
            VSync = opts.VSync;
        }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible defaults.
        /// </summary>
        public static ViewOptions Default { get; } = new ViewOptions
        (
            0.0, 0.0, GraphicsAPI.Default, true, true, VideoMode.Default
        );

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible values, intended for use with Vulkan.
        /// </summary>
        public static ViewOptions DefaultVulkan { get; } = new ViewOptions
        (
            0.0, 0.0, GraphicsAPI.DefaultVulkan, false, false, VideoMode.Default
        );
    }
}
