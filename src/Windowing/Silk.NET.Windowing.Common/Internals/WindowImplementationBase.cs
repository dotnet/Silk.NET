// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;


namespace Silk.NET.Windowing.Internals
{
    /// <summary>
    /// Abstracts away common window functions to ease implementation of the windowing API.
    /// </summary>
    internal abstract class WindowImplementationBase : ViewImplementationBase, IWindow
    {
        private WindowOptions _optionsCache;

        /// <summary>
        /// Creates a base window with the given options.
        /// </summary>
        /// <param name="optionsCache">The options, used to configure the view.</param>
        protected WindowImplementationBase(WindowOptions optionsCache) : base(new ViewOptions(optionsCache))
        {
            _optionsCache = optionsCache;
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
        public abstract event Action<Point> Move;
        public abstract event Action<WindowState> StateChanged;
        public abstract event Action<string[]> FileDrop;
        
        // Other APIs implemented abstractly
        public abstract IWindow CreateWindow(WindowOptions opts);
        public abstract IWindowHost Parent { get; }
        public abstract IMonitor Monitor { get; set; }
        public abstract void SetWindowIcon(Span<WindowIcon> icons);
        
        // Cache updates for dervied classes
        protected void UpdatePosition(Point point) => _optionsCache.Position = point;
        protected void UpdateSize(Size size) => _optionsCache.Size = size;
        protected void UpdateState(WindowState state) => _optionsCache.WindowState = state;
        
        // Lifetime controls
        protected override void CoreInitialize(ViewOptions opts)
        {
            _optionsCache.ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            _optionsCache.IsEventDriven = opts.IsEventDriven;
            _optionsCache.FramesPerSecond = opts.FramesPerSecond;
            _optionsCache.UpdatesPerSecond = opts.UpdatesPerSecond;
            _optionsCache.VSync = opts.VSync;
            _optionsCache.API = opts.API;
            _optionsCache.VideoMode = opts.VideoMode;
            _optionsCache.PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            CoreInitialize(_optionsCache);
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
            get => IsInitialized ? _optionsCache.Size = CoreSize : _optionsCache.Size;
            set
            {
                if (IsInitialized)
                {
                    SizeSettable = value;
                }

                _optionsCache.Size = value;
            }
        }
        bool IWindow.IsClosing
        {
            get => IsClosing;
            set => IsClosingSettable = value;
        }
        
        public bool IsVisible
        {
            get => IsInitialized ? _optionsCache.IsVisible = CoreIsVisible : _optionsCache.IsVisible;
            set
            {
                if (IsInitialized)
                {
                    CoreIsVisible = value;
                }

                _optionsCache.IsVisible = value;
            }
        }

        public Point Position
        {
            get => IsInitialized ? _optionsCache.Position = CorePosition : _optionsCache.Position;
            set
            {
                if (IsInitialized)
                {
                    CorePosition = value;
                }

                _optionsCache.Position = value;
            }
        }

        public string Title
        {
            get => IsInitialized ? _optionsCache.Title = CoreTitle : _optionsCache.Title;
            set
            {
                if (IsInitialized)
                {
                    CoreTitle = value;
                }

                _optionsCache.Title = value;
            }
        }

        public WindowState WindowState
        {
            get => IsInitialized ? _optionsCache.WindowState = CoreWindowState : _optionsCache.WindowState;
            set
            {
                if (IsInitialized)
                {
                    CoreWindowState = value;
                }

                _optionsCache.WindowState = value;
            }
        }

        public WindowBorder WindowBorder
        {
            get => IsInitialized ? _optionsCache.WindowBorder = CoreWindowBorder : _optionsCache.WindowBorder;
            set
            {
                if (IsInitialized)
                {
                    CoreWindowBorder = value;
                }

                _optionsCache.WindowBorder = value;
            }
        }

        public bool TransparentFramebuffer => _optionsCache.TransparentFramebuffer;
    }
}
