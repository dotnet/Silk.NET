// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Core;


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
        protected abstract Point CorePosition { get; set; }
        protected abstract string CoreTitle { get; set; }
        protected abstract WindowState CoreWindowState { get; set; }
        protected abstract WindowBorder CoreWindowBorder { get; set; }
        protected abstract bool IsClosingSettable { set; }
        protected abstract Size SizeSettable { set; }

        // Function bases - again extra functionality on top
        protected abstract void CoreInitialize(WindowOptions opts);

        // Events
        public abstract event Action<Point>? Move;
        public abstract event Action<WindowState>? StateChanged;
        public abstract event Action<string[]>? FileDrop;

        // Other APIs implemented abstractly
        public abstract IWindow CreateWindow(WindowOptions opts);
        public abstract IWindowHost? Parent { get; }
        public abstract IMonitor? Monitor { get; set; }
        public abstract void SetWindowIcon(ReadOnlySpan<RawImage> icons);

        // Cache updates for dervied classes
        protected void UpdatePosition(Point point) => ExtendedOptionsCache.Position = point;
        protected void UpdateSize(Size size) => ExtendedOptionsCache.Size = size;
        protected void UpdateState(WindowState state) => ExtendedOptionsCache.WindowState = state;

        // Lifetime controls
        protected override void CoreInitialize(ViewOptions opts)
        {
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
        public override Point PointToClient(Point point)
        {
            return new Point(point.X - Position.X, point.Y - Position.Y);
        }

        public override Point PointToScreen(Point point)
        {
            return new Point(point.X + Position.X, point.Y + Position.Y);
        }

        // Properties with different accessors on IWindow than on IView
        Size IWindowProperties.Size
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
            get => IsClosing;
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

        public Point Position
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

        public bool TransparentFramebuffer => ExtendedOptionsCache.TransparentFramebuffer;
    }
}
