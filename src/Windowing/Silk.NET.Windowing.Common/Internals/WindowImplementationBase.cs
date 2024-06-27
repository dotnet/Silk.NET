// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;


namespace Silk.NET.Windowing.Internals
{
    /// <summary>
    /// Abstracts away common window functions to ease implementation of the windowing API.
    /// </summary>
    internal abstract class WindowImplementationBase : ViewImplementationBase, IWindow
    {
        protected WindowOptions ExtendedOptionsCache;

        /// <summary>
        /// Creates a base window with the given options.
        /// </summary>
        /// <param name="optionsCache">The options, used to configure the view.</param>
        protected WindowImplementationBase(WindowOptions optionsCache) : base(new ViewOptions(optionsCache))
        {
            ExtendedOptionsCache = optionsCache;
        }

        // Property bases - these have extra functionality baked into their getters and setters
        protected abstract bool CoreIsVisible { get; set; }
        protected abstract Vector2D<int> CorePosition { get; set; }
        protected abstract string CoreTitle { get; set; }
        protected abstract WindowState CoreWindowState { get; set; }
        protected abstract WindowBorder CoreWindowBorder { get; set; }
        protected abstract bool CoreTopMost { get; set; }
        protected abstract bool IsClosingSettable { set; }
        protected abstract Vector2D<int> SizeSettable { set; }
        protected abstract Rectangle<int> CoreBorderSize { get; }

        // Function bases - again extra functionality on top
        protected abstract void CoreInitialize(WindowOptions opts);

        // Events
        public abstract event Action<Vector2D<int>>? Move;
        public abstract event Action<WindowState>? StateChanged;
        public abstract event Action<string[]>? FileDrop;

        // Other APIs implemented abstractly
        public abstract IWindow CreateWindow(WindowOptions opts);
        public abstract IWindowHost? Parent { get; }
        public abstract IGLContext? SharedContext { get; }
        public abstract IMonitor? Monitor { get; set; }
        public abstract string? WindowClass { get; }
        public abstract void SetWindowIcon(ReadOnlySpan<RawImage> icons);

        // Cache updates for dervied classes
        protected void UpdatePosition(Vector2D<int> point) => ExtendedOptionsCache.Position = point;
        protected void UpdateSize(Vector2D<int> size) => ExtendedOptionsCache.Size = size;
        protected void UpdateState(WindowState state) => ExtendedOptionsCache.WindowState = state;

        // Lifetime controls
        protected override void CoreInitialize(ViewOptions opts)
        {
            _swapIntervalChanged = true;
            ExtendedOptionsCache.ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            ExtendedOptionsCache.IsEventDriven = opts.IsEventDriven;
            ExtendedOptionsCache.FramesPerSecond = opts.FramesPerSecond;
            ExtendedOptionsCache.UpdatesPerSecond = opts.UpdatesPerSecond;
            ExtendedOptionsCache.VSync = opts.VSync;
            ExtendedOptionsCache.API = opts.API;
            ExtendedOptionsCache.VideoMode = opts.VideoMode;
            ExtendedOptionsCache.PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            CoreInitialize(ExtendedOptionsCache);
        }

        // Point transformations
        public override Vector2D<int> PointToClient(Vector2D<int> point)
        {
            return new Vector2D<int>(point.X - Position.X, point.Y - Position.Y);
        }

        public override Vector2D<int> PointToScreen(Vector2D<int> point)
        {
            return new Vector2D<int>(point.X + Position.X, point.Y + Position.Y);
        }

        // Properties with different accessors on IWindow than on IView
        Vector2D<int> IWindowProperties.Size
        {
            get => IsInitialized ? ExtendedOptionsCache.Size = CoreSize : ExtendedOptionsCache.Size;
            set
            {
                if (IsInitialized)
                {
                    SizeSettable = value;
                }

                ExtendedOptionsCache.Size = value;
            }
        }

        bool IWindow.IsClosing
        {
            get => CoreIsClosing;
            set => IsClosingSettable = value;
        }

        public bool IsVisible
        {
            get => IsInitialized ? ExtendedOptionsCache.IsVisible = CoreIsVisible : ExtendedOptionsCache.IsVisible;
            set
            {
                if (IsInitialized)
                {
                    CoreIsVisible = value;
                }

                ExtendedOptionsCache.IsVisible = value;
            }
        }

        public Vector2D<int> Position
        {
            get => IsInitialized ? ExtendedOptionsCache.Position = CorePosition : ExtendedOptionsCache.Position;
            set
            {
                if (IsInitialized)
                {
                    CorePosition = value;
                }

                ExtendedOptionsCache.Position = value;
            }
        }

        public string Title
        {
            get => IsInitialized ? ExtendedOptionsCache.Title = CoreTitle : ExtendedOptionsCache.Title;
            set
            {
                if (IsInitialized)
                {
                    CoreTitle = value;
                }

                ExtendedOptionsCache.Title = value;
            }
        }

        public WindowState WindowState
        {
            get => IsInitialized
                ? ExtendedOptionsCache.WindowState = CoreWindowState
                : ExtendedOptionsCache.WindowState;
            set
            {
                if (IsInitialized)
                {
                    CoreWindowState = value;
                }

                _swapIntervalChanged = true;
                ExtendedOptionsCache.WindowState = value;
            }
        }

        public WindowBorder WindowBorder
        {
            get => IsInitialized
                ? ExtendedOptionsCache.WindowBorder = CoreWindowBorder
                : ExtendedOptionsCache.WindowBorder;
            set
            {
                if (IsInitialized)
                {
                    CoreWindowBorder = value;
                }

                ExtendedOptionsCache.WindowBorder = value;
            }
        }

        // Other property implementations
        public bool TransparentFramebuffer => ExtendedOptionsCache.TransparentFramebuffer;

        public bool TopMost
        {
            get => IsInitialized ? ExtendedOptionsCache.TopMost = CoreTopMost : ExtendedOptionsCache.TopMost;
            set
            {
                if (IsInitialized)
                {
                    CoreTopMost = value;
                }

                ExtendedOptionsCache.TopMost = value;
            }
        }

        public Rectangle<int> BorderSize => IsInitialized ? CoreBorderSize : default;
    }
}
