// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Maths;

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
        public bool IsContextControlDisabled { get; set; }

        /// <inheritdoc />
        Vector2D<int> IViewProperties.Size
            => throw new InvalidOperationException("Can't get the size of a non-existent view.");

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

        /// <inheritdoc />
        public int? PreferredStencilBufferBits { get; set; }

        /// <inheritdoc />
        public Vector4D<int>? PreferredBitDepth { get; set; }

        /// <inheritdoc />
        public int? Samples { get; set; }

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
            int? preferredStencilBufferBits = null,
            Vector4D<int>? preferredBitDepth = null,
            bool isEventDriven = false,
            int? samples = null,
            bool isContextControlDisabled = false
        )
        {
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            PreferredStencilBufferBits = preferredStencilBufferBits;
            PreferredBitDepth = preferredBitDepth;
            IsEventDriven = isEventDriven;
            VSync = isVSync;
            Samples = samples;
            IsContextControlDisabled = isContextControlDisabled;
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
            PreferredStencilBufferBits = opts.PreferredStencilBufferBits;
            PreferredBitDepth = opts.PreferredBitDepth;
            ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            IsEventDriven = opts.IsEventDriven;
            VSync = opts.VSync;
            Samples = opts.Samples;
            IsContextControlDisabled = opts.IsContextControlDisabled;
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
