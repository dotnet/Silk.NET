// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Reflection;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Contains all window properties, used for window creation.
    /// </summary>
    public struct WindowOptions : IWindowProperties
    {
        /// <summary>
        /// Creates an instance of WindowOptions from an existing ViewOptions struct.
        /// </summary>
        /// <param name="opts">The view options to copy where applicable.</param>
        public WindowOptions(ViewOptions opts)
        {
            IsVisible = true;
            Position = new Vector2D<int>(50, 50);
            Size = new Vector2D<int>(1280, 720);
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
            API = opts.API;
            Title = Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Window";
            WindowState = WindowState.Normal;
            WindowBorder = WindowBorder.Resizable;
            ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            VideoMode = opts.VideoMode;
            PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            TransparentFramebuffer = false;
            IsEventDriven = opts.IsEventDriven;
            VSync = opts.VSync;
            SharedContext = null;
            PreferredStencilBufferBits = opts.PreferredStencilBufferBits;
            PreferredBitDepth = opts.PreferredBitDepth;
            Samples = opts.Samples;
            WindowClass = null;
            IsContextControlDisabled = opts.IsContextControlDisabled;
            TopMost = false;
        }

        /// <inheritdoc />
        public bool IsVisible { get; set; }

        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }

        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        public bool IsContextControlDisabled { get; set; }

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

        /// <inheritdoc />
        public Vector2D<int> Position { get; set; }

        /// <inheritdoc />
        public Vector2D<int> Size { get; set; }

        /// <inheritdoc />
        public double FramesPerSecond { get; set; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }

        /// <inheritdoc />
        public GraphicsAPI API { get; set; }

        /// <inheritdoc />
        public bool VSync { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }

        /// <inheritdoc />
        public WindowState WindowState { get; set; }

        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }

        /// <inheritdoc />
        public bool TransparentFramebuffer { get; set; }

        /// <inheritdoc />
        public bool TopMost { get; set; }

        /// <inheritdoc />
        public IGLContext? SharedContext { get; set; }

        /// <inheritdoc />
        public string? WindowClass { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct.
        /// </summary>
        public WindowOptions
        (
            bool isVisible,
            Vector2D<int> position,
            Vector2D<int> size,
            double framesPerSecond,
            double updatesPerSecond,
            GraphicsAPI api,
            string title,
            WindowState windowState,
            WindowBorder windowBorder,
            bool isVSync,
            bool shouldSwapAutomatically,
            VideoMode videoMode,
            int? preferredDepthBufferBits = null,
            int? preferredStencilBufferBits = null,
            Vector4D<int>? preferredBitDepth = null,
            bool transparentFramebuffer = false,
            bool topMost = false,
            bool isEventDriven = false,
            IGLContext? sharedContext = null,
            int? samples = null,
            string? windowClass = null,
            bool isContextControlDisabled = false
        )
        {
            IsVisible = isVisible;
            Position = position;
            Size = size;
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            Title = title;
            WindowState = windowState;
            WindowBorder = windowBorder;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            TransparentFramebuffer = transparentFramebuffer;
            TopMost = topMost;
            IsEventDriven = isEventDriven;
            VSync = isVSync;
            SharedContext = sharedContext;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            PreferredStencilBufferBits = preferredStencilBufferBits;
            PreferredBitDepth = preferredBitDepth;
            Samples = samples;
            WindowClass = windowClass;
            IsContextControlDisabled = isContextControlDisabled;
        }

        static WindowOptions()
        {
            string name = "Silk.NET Window";
            try
            {
                var asmName = Assembly.GetEntryAssembly()?.GetName().Name;
                if (asmName is not null)
                    name = asmName;
            }
            catch { /* cannot use reflection */ }

            Default = new WindowOptions
            (
                true, new Vector2D<int>(50, 50), new Vector2D<int>(1280, 720), 0.0, 0.0, GraphicsAPI.Default,
                name, WindowState.Normal,
                WindowBorder.Resizable, true, true, VideoMode.Default
            );

            DefaultVulkan = new WindowOptions
            (
                true, new Vector2D<int>(50, 50), new Vector2D<int>(1280, 720), 0.0, 0.0, GraphicsAPI.DefaultVulkan,
                name, WindowState.Normal,
                WindowBorder.Resizable, false, false, VideoMode.Default
            );
        }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible defaults.
        /// </summary>
        public static WindowOptions Default { get; }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible values, intended for use with Vulkan.
        /// </summary>
        public static WindowOptions DefaultVulkan { get; }
    }
}
