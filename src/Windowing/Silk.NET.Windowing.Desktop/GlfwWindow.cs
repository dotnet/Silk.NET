// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Silk.NET.Core.Contexts;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Common.Structs;
using VideoMode = Silk.NET.Windowing.Common.VideoMode;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    internal class GlfwWindow : IVulkanWindow
    {
        // The number of frames that the window has been running slowly for.
        private int _isRunningSlowlyTries;

        // Cache variables
        private Point _position;
        private Size _size;
        private string _title;
        private VSyncMode _vSync;
        private WindowBorder _windowBorder;
        private WindowState _windowState;
        private Point _nonFullscreenPosition;
        private Size _nonFullscreenSize;

        // Glfw stuff
        private readonly Glfw _glfw = GlfwProvider.GLFW.Value;
        private unsafe WindowHandle* _windowPtr;

        // Callbacks
        private GlfwCallbacks.WindowCloseCallback _onClosing;
        private GlfwCallbacks.DropCallback _onFileDrop;
        private GlfwCallbacks.WindowFocusCallback _onFocusChanged;
        private GlfwCallbacks.WindowMaximizeCallback _onMaximized;
        private GlfwCallbacks.WindowIconifyCallback _onMinimized;
        private GlfwCallbacks.WindowPosCallback _onMove;
        private GlfwCallbacks.WindowSizeCallback _onResize;

        // Main loop-related things

        // The stopwatches. Used to calculate delta.
        private Stopwatch _renderStopwatch;
        private Stopwatch _updateStopwatch;
        // The stopwatch used to determine how long the window has been alive
        private Stopwatch _lifetimeStopwatch;

        // Invoke method variables
        private ConcurrentQueue<Invocation> _pendingInvocations;
        private int _mainThread = -1;

        // Update and render period. Represents the time in seconds that each frame should take.
        private double _updatePeriod;
        private double _renderPeriod;
        private bool _updatedWithinPeriod;
        private bool _renderedWithinPeriod;

        // TODO i want to merge all fields into this one OR split this field up as keeping it in sync is annoying
        private WindowOptions _initialOptions;
        private bool _running;
        private readonly IMonitor _initialMonitor;

        /// <summary>
        /// Create a new GlfwWindow.
        /// </summary>
        /// <param name="options">The options to use for this window.</param>
        public GlfwWindow(WindowOptions options, GlfwWindow parent, GlfwMonitor monitor)
        {
            // Title and Size must be set before the window is created.
            _title = options.Title;
            _size = options.Size;

            _windowBorder = WindowBorder;
            _vSync = options.VSync;

            FramesPerSecond = options.FramesPerSecond;
            UpdatesPerSecond = options.UpdatesPerSecond;

            RunningSlowTolerance = options.RunningSlowTolerance;
            UseSingleThreadedWindow = options.UseSingleThreadedWindow;
            ShouldSwapAutomatically = options.ShouldSwapAutomatically;

            _initialOptions = options;
            _initialMonitor = monitor;
            Parent = (IWindowHost) parent ?? _initialMonitor;
            IsEventDriven = options.IsEventDriven;

            GlfwProvider.GLFW.Value.GetVersion(out var major, out var minor, out _);
            if (new Version(major, minor) < new Version(3, 3))
            {
                throw new NotSupportedException("GLFW 3.3 or later is required for Silk.NET.Windowing.Desktop.");
            }

            if (options.API.API == ContextAPI.Vulkan)
            {
                VkSurface = new Surface(this);
            }
            else if (options.API.API == ContextAPI.OpenGL || options.API.API == ContextAPI.OpenGLES)
            {
                GLContext = new Context(this);
            }

            Glfw.ThrowExceptions();
        }

        /// <inheritdoc />
        public int RunningSlowTolerance { get; set; }

        /// <inheritdoc cref="IWindow" />
        public unsafe bool IsClosing
        {
            get => _glfw.WindowShouldClose(_windowPtr);
            set => _glfw.SetWindowShouldClose(_windowPtr, value);
        }

        /// <inheritdoc />
        public unsafe Rectangle BorderSize
        {
            get
            {
                _glfw.GetWindowFrameSize(_windowPtr, out var l, out var t, out var r, out var b);
                return Rectangle.FromLTRB(l, t, r, b);
            }
        }

        /// <inheritdoc />
        public bool IsRunningSlowly => _isRunningSlowlyTries > RunningSlowTolerance;

        /// <inheritdoc />
        public bool IsVisible
        {
            get
            {
                unsafe
                {
                    return _running
                        ? _glfw.GetWindowAttrib(_windowPtr, WindowAttributeGetter.Visible)
                        : _initialOptions.IsVisible;
                }
            }
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        if (value)
                        {
                            _glfw.ShowWindow(_windowPtr);
                        }
                        else
                        {
                            _glfw.HideWindow(_windowPtr);
                        }
                    }
                }

                _initialOptions.IsVisible = value;
            }
        }

        /// <inheritdoc />
        public unsafe IntPtr Handle => (IntPtr) _windowPtr;

        public unsafe bool IsCurrentContext => _glfw.GetCurrentContext() == _windowPtr;

        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; }

        /// <summary>
        /// Whether or not this window should swap buffers automatically.
        /// </summary>
        /// <remarks>
        /// If this is false, you'll have to call <see cref="GlfwWindow.SwapBuffers"/> manually.
        /// </remarks>
        public bool ShouldSwapAutomatically { get; }

        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        public VideoMode VideoMode => Monitor?.VideoMode ?? _initialOptions.VideoMode;

        /// <inheritdoc />
        public int? PreferredDepthBufferBits => _initialOptions.PreferredDepthBufferBits;

        /// <inheritdoc />
        public Point Position
        {
            get => _position;
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        _glfw.SetWindowPos(_windowPtr, value.X, value.Y);
                    }
                }

                _position = value;
                _nonFullscreenPosition = value;
                _initialOptions.Position = value;
            }
        }

        /// <inheritdoc cref="Size" />
        public Size Size
        {
            get => _size;
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        _glfw.SetWindowSize(_windowPtr, value.Width, value.Height);
                    }
                }

                _initialOptions.Size = value;
                _nonFullscreenSize = value;
                _size = value;
            }
        }

        public double Time => _lifetimeStopwatch.Elapsed.TotalSeconds;

        /// <inheritdoc />
        public double FramesPerSecond
        {
            get => 1.0 / _renderPeriod;
            set
            {
                if (value <= double.Epsilon)
                {
                    _renderPeriod = 0.0;
                    return;
                }

                _renderPeriod = 1.0 / value;
            }
        }

        /// <inheritdoc />
        public double UpdatesPerSecond
        {
            get => 1.0 / _updatePeriod;
            set
            {
                if (value <= double.Epsilon)
                {
                    _updatePeriod = 0.0;
                    return;
                }

                _updatePeriod = 1.0 / value;
            }
        }

        /// <inheritdoc />
        public GraphicsAPI API => _initialOptions.API;

        /// <inheritdoc />
        public string Title
        {
            get => _title;
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        _glfw.SetWindowTitle(_windowPtr, value);
                    }
                }

                _initialOptions.Title = value;
                _title = value;
            }
        }

        /// <inheritdoc />
        public WindowState WindowState
        {
            get => _windowState;
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        if (_windowState == WindowState.Normal)
                        {
                            _nonFullscreenPosition = _position;
                            _nonFullscreenSize = _size;
                        }
                        else if (_windowState == WindowState.Fullscreen &&
                                 value != WindowState.Fullscreen)
                        {
                            _glfw.SetWindowMonitor
                            (
                                _windowPtr, null,
                                _nonFullscreenPosition.X,
                                _nonFullscreenPosition.Y,
                                _nonFullscreenSize.Width,
                                _nonFullscreenSize.Height,
                                0
                            );
                        }

                        switch (value)
                        {
                            case WindowState.Normal:
                                _glfw.RestoreWindow(_windowPtr);
                                break;
                            case WindowState.Minimized:
                                _glfw.IconifyWindow(_windowPtr);
                                break;
                            case WindowState.Maximized:
                                _glfw.MaximizeWindow(_windowPtr);
                                break;
                            case WindowState.Fullscreen:
                                var monitor = _glfw.GetPrimaryMonitor();
                                var mode = _glfw.GetVideoMode(monitor);
                                var videoMode = _initialOptions.VideoMode;
                                var resolution = videoMode.Resolution;
                                _glfw.SetWindowMonitor
                                (
                                    _windowPtr, monitor, 0, 0,
                                    resolution?.Width ?? mode->Width,
                                    resolution?.Height ?? mode->Height,
                                    videoMode.RefreshRate ?? mode->RefreshRate
                                );
                                break;
                        }
                    }
                }

                _initialOptions.WindowState = value;
                _windowState = value;
            }
        }

        /// <inheritdoc />
        public WindowBorder WindowBorder
        {
            get => _windowBorder;
            set
            {
                if (_running)
                {
                    unsafe
                    {
                        switch (value)
                        {
                            case WindowBorder.Hidden:
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Decorated, false);
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Resizable, false);
                                break;

                            case WindowBorder.Resizable:
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Decorated, true);
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Resizable, true);
                                break;

                            case WindowBorder.Fixed:
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Decorated, true);
                                _glfw.SetWindowAttrib(_windowPtr, WindowAttributeSetter.Resizable, false);
                                break;
                        }
                    }
                }

                _initialOptions.WindowBorder = value;
                _windowBorder = value;
            }
        }

        /// <inheritdoc />
        public VSyncMode VSync
        {
            get => _vSync;
            set
            {
                if (_running)
                {
                    switch (value)
                    {
                        case VSyncMode.Off:
                            _glfw.SwapInterval(0);
                            break;

                        case VSyncMode.On:
                            _glfw.SwapInterval(1);
                            break;

                        default:
                            _glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
                            break;
                    }
                }

                _initialOptions.VSync = value;
                _vSync = value;
            }
        }

        /// <inheritdoc />
        public bool TransparentFramebuffer
        {
            get
            {
                unsafe
                {
                    return _glfw.GetWindowAttrib(_windowPtr, WindowAttributeGetter.TransparentFramebuffer);
                }
            }
        }

        /// <inheritdoc />
        public object Invoke(Delegate d)
        {
            return Invoke(d, new object[0]);
        }

        /// <inheritdoc />
        public object Invoke(Delegate d, params object[] args)
        {
            if (UseSingleThreadedWindow)
            {
                throw new NotSupportedException("Window is single-threaded.");
            }

            if (Thread.CurrentThread.ManagedThreadId == _mainThread)
            {
                return d.DynamicInvoke(args);
            }

            // TODO make this less allocate-y, delegates are a son of a
            object ret = null;
            using var invocation = new Invocation(d, args, SetReturnValue);
            invocation.Source.WaitOne();
            return ret;

            //var task = new Task<object>(() => d.DynamicInvoke(args));
            //_invokeQueue.Enqueue(task);
            //SpinWait.SpinUntil(() => task.IsCompleted);
            //return task.Result;

            void SetReturnValue(object o) => ret = o;
        }

        public unsafe void ClearContext()
        {
            if (IsCurrentContext)
            {
                _glfw.MakeContextCurrent(null);
                Glfw.ThrowExceptions();
            }
        }

        /// <inheritdoc />
        public void Run(Action onFrame)
        {
            while (!IsClosing)
            {
                onFrame();
            }
        }

        /// <inheritdoc />
        public unsafe void MakeCurrent()
        {
            _glfw.MakeContextCurrent(_windowPtr);
            Glfw.ThrowExceptions();
        }

        /// <summary>
        /// Make context current on this thread if it was moved to another one.
        /// </summary>
        private void MakeCurrentInternal()
        {
            if ((API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES) && !IsCurrentContext)
            {
                MakeCurrent();
            }
        }

        /// <inheritdoc />
        public void Close()
        {
            unsafe
            {
                Closing?.Invoke();
                _glfw.SetWindowShouldClose(_windowPtr, true);
                Glfw.ThrowExceptions();
            }
        }

        /// <inheritdoc />
        public unsafe void Initialize()
        {
            if (_windowPtr != default)
            {
                return;
            }

            // Set window border.
            switch (_initialOptions.WindowBorder)
            {
                case WindowBorder.Hidden:
                    _glfw.WindowHint(WindowHintBool.Decorated, false);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;

                case WindowBorder.Resizable:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, true);
                    break;

                case WindowBorder.Fixed:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;
            }

            // Set window API.
            switch (_initialOptions.API.API)
            {
                case ContextAPI.None:
                case ContextAPI.Vulkan:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                    break;
                case ContextAPI.OpenGL:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
                    break;
                case ContextAPI.OpenGLES:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGLES);
                    break;
            }

            _glfw.WindowHint(WindowHintBool.Visible, _initialOptions.IsVisible);

            // Set API version.
            _glfw.WindowHint(WindowHintInt.ContextVersionMajor, _initialOptions.API.Version.MajorVersion);
            _glfw.WindowHint(WindowHintInt.ContextVersionMinor, _initialOptions.API.Version.MinorVersion);

            // Set API flags
            if (_initialOptions.API.Flags.HasFlag(ContextFlags.ForwardCompatible))
            {
                _glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
            }

            if (_initialOptions.API.Flags.HasFlag(ContextFlags.Debug))
            {
                _glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
            }

            // Set API profile
            _glfw.WindowHint
            (
                WindowHintOpenGlProfile.OpenGlProfile,
                _initialOptions.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat
            );

            // Set video mode (-1 = don't care)
            _glfw.WindowHint(WindowHintInt.RefreshRate, _initialOptions.VideoMode.RefreshRate ?? -1);
            _glfw.WindowHint(WindowHintInt.DepthBits, _initialOptions.PreferredDepthBufferBits ?? -1);

            // Set transparent framebuffer
            _glfw.WindowHint(WindowHintBool.TransparentFramebuffer, _initialOptions.TransparentFramebuffer);

            // Create window
            _windowPtr = _glfw.CreateWindow
            (
                _size.Width, _size.Height, _title, _initialMonitor is GlfwMonitor x ? x.Handle : null, null
            );

            // Initialize some variables
            _isRunningSlowlyTries = 0;
            _running = true;

            _pendingInvocations = new ConcurrentQueue<Invocation>();
            _mainThread = Thread.CurrentThread.ManagedThreadId;

            if (API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES)
            {
                _glfw.MakeContextCurrent(_windowPtr);
            }

            WindowState = _initialOptions.WindowState;
            Position = _initialOptions.Position;

            InitializeCallbacks();

            if ((API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES) &&
                _glfw.GetCurrentContext() != _windowPtr)
            {
                _glfw.MakeContextCurrent(_windowPtr);
            }

            // Run OnLoad.
            Load?.Invoke();

            _lifetimeStopwatch = new Stopwatch();
            _renderStopwatch = new Stopwatch();
            _updateStopwatch = new Stopwatch();
            _lifetimeStopwatch.Start();
            _renderStopwatch.Start();
            _updateStopwatch.Start();
            Glfw.ThrowExceptions();
        }

        /// <inheritdoc />
        public void DoRender()
        {
            MakeCurrentInternal();
            RaiseRenderFrame();
        }

        /// <inheritdoc />
        public void DoUpdate()
        {
            if (UseSingleThreadedWindow)
            {
                RaiseUpdateFrame();
            }
            else
            {
                // Raise UpdateFrame, but don't await it yet.
                var task = Task.Run(RaiseUpdateFrame); // cast to action, ambiguous call

                // Loop while we're still updating - the Update thread might be calling the main thread
                while (!task.IsCompleted)
                {
                    if (!_pendingInvocations.IsEmpty && _pendingInvocations.TryDequeue(out var invokeCall))
                    {
                        invokeCall.Return(invokeCall.Target.DynamicInvoke(invokeCall.Args));
                        invokeCall.Source.Set();
                    }
                }
            }
        }

        /// <inheritdoc />
        public void DoEvents()
        {
            if (IsEventDriven)
            {
                _glfw.WaitEvents();
            }
            else
            {
                _glfw.PollEvents();
            }

            Glfw.ThrowExceptions();
        }

        /// <inheritdoc />
        public void ContinueEvents()
        {
            _glfw.PostEmptyEvent();
        }

        /// <inheritdoc />
        public unsafe void Reset()
        {
            _updateTimeDeficit = 0;
            _renderTimeDeficit = 0;

            _lifetimeStopwatch.Stop();
            _updateStopwatch.Stop();
            _renderStopwatch.Stop();

            try
            {
                _glfw.DestroyWindow(_windowPtr);
                Glfw.ThrowExceptions();
            }
#pragma warning disable 168
            catch (GlfwException e)
#pragma warning restore 168
            {
                // If the window is already destroyed, it throws an exception,
                // but we want the window destroyed anyways, so just ignore it
            }

            _windowPtr = (WindowHandle*) 0;
        }

        // Disable parameter because
        // ReSharper disable once UnusedParameter.Local
        private void Dispose(bool disposing)
        {
            Reset();

            // All callbacks are initialized at the same time,
            // so checking each one individually shouldn't be
            // necessary.
            if (_onClosing != null)
            {
                _glfw.GcUtility.Unpin(_onClosing);
                _glfw.GcUtility.Unpin(_onMaximized);
                _glfw.GcUtility.Unpin(_onMinimized);
                _glfw.GcUtility.Unpin(_onMove);
                _glfw.GcUtility.Unpin(_onResize);
                _glfw.GcUtility.Unpin(_onFileDrop);
                _glfw.GcUtility.Unpin(_onFocusChanged);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~GlfwWindow()
        {
            Dispose(false);
        }

        /// <inheritdoc />
        public void SwapBuffers()
        {
            unsafe
            {
                _glfw.SwapBuffers(_windowPtr);
            }
        }

        /// <inheritdoc />
        public Point PointToClient(Point point)
        {
            return new Point(point.X - _position.X, point.Y - _position.Y);
        }

        /// <inheritdoc />
        public Point PointToScreen(Point point)
        {
            return new Point(point.X + _position.X, point.Y + _position.Y);
        }

        // Events

        /// <inheritdoc />
        public event Action<Point> Move;

        /// <inheritdoc />
        public event Action<Size> Resize;

        /// <inheritdoc />
        public event Action Closing;

        /// <inheritdoc />
        public event Action<WindowState> StateChanged;

        /// <inheritdoc />
        public event Action<bool> FocusChanged;

        /// <inheritdoc />
        public event Action<string[]> FileDrop;

        /// <inheritdoc />
        public unsafe void SetWindowIcon(Span<WindowIcon> icons)
        {
            if (!_running)
            {
                throw new InvalidOperationException("Window should be initialized.");
            }

            if (icons == null)
            {
                _glfw.SetWindowIcon(_windowPtr, 0, null);
            }
            else
            {
                var images = stackalloc Image[icons.Length];
                var hglobals = stackalloc byte*[icons.Length];
                for (var i = 0; i < icons.Length; i++)
                {
                    var icon = icons[i];
                    images[i] = new Image
                    {
                        Width = icon.Width, Height = icon.Height,
                        Pixels = hglobals[i] = (byte*) Marshal.AllocHGlobal(icon.Pixels.Length)
                    };

                    for (var j = 0; j < icon.Pixels.Length; j++)
                    {
                        hglobals[i][j] = icon.Pixels[j];
                    }
                }

                _glfw.SetWindowIcon(_windowPtr, icons.Length, images);
                Glfw.ThrowExceptions();

                for (var i = 0; i < icons.Length; i++)
                {
                    Marshal.FreeHGlobal((IntPtr) hglobals[i]);
                }
            }
        }

        /// <inheritdoc />
        public event Action Load;

        /// <inheritdoc />
        public event Action<double> Update;

        /// <inheritdoc />
        public event Action<double> Render;

        private double _updateTimeDeficit = 0;

        /// <summary>
        /// Run an OnUpdate event.
        /// </summary>
        private void RaiseUpdateFrame()
        {
            // If using a capped framerate without vsync, we have to do some synchronization-related things.
            // before rendering.
            if (UpdatesPerSecond >= double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive))
            {
                // Calculate the amount of remaining time till next update.
                var remainingTime = _updatePeriod - _updateStopwatch.Elapsed.TotalSeconds - _updateTimeDeficit;

                // If the result is negative, and no call was within period that means the frame is running slowly.
                if (remainingTime < 0.0)
                {
                    if (!_updatedWithinPeriod)
                        ++_isRunningSlowlyTries;
                }
                // Else return if the remaining time is > 0.
                else
                {
                    _updatedWithinPeriod = true; // Remember we weren't too late.
                    _isRunningSlowlyTries = 0;

                    if (remainingTime > 0.0 && VSync != VSyncMode.Adaptive)
                        return; // Not the time for update yet.
                }
            }

            // Calculate delta and run frame.
            var delta = _updateStopwatch.Elapsed.TotalSeconds;

            // Calculate how much the delta differs from the desired updatePeriod.
            _updateTimeDeficit += delta - _updatePeriod;

            // Reset
            _updateStopwatch.Restart();
            _updatedWithinPeriod = false;

            if (IsClosing)
            {
                return;
            }

            Update?.Invoke(delta);
        }

        private int? _lastVs;
        private double _renderTimeDeficit = 0;

        /// <summary>
        /// Run an OnRender event.
        /// </summary>
        private void RaiseRenderFrame()
        {
            // Identical to RaiseUpdateFrame.
            if (FramesPerSecond >= double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive))
            {
                // Calculate the amount of remaining time till next rendering..
                var remainingTime = _renderPeriod - _renderStopwatch.Elapsed.TotalSeconds - _renderTimeDeficit;

                // If no update frame rate is given we have to check for slow running here.
                if (UpdatesPerSecond < double.Epsilon)
                {
                    // If the result is negative, and no call was within period that means the frame is running slowly.
                    if (remainingTime < 0.0)
                    {
                        if (!_renderedWithinPeriod)
                            ++_isRunningSlowlyTries;
                    }
                    // Else return if the remaining time is > 0.
                    else
                    {
                        _renderedWithinPeriod = true; // Remember we weren't too late.
                        _isRunningSlowlyTries = 0;

                        if (remainingTime > 0.0 && VSync != VSyncMode.Adaptive)
                            return; // Not the time for update yet.
                    }
                }
                else if (remainingTime > 0.0)
                    return; // Not the time for rendering yet.
            }

            var delta = _renderStopwatch.Elapsed.TotalSeconds;

            _renderTimeDeficit += delta - _renderPeriod;

            //Reset
            _renderStopwatch.Restart();
            _renderedWithinPeriod = false;

            // This has to be called on the thread with the graphics context
            var vs = VSync switch
            {
                VSyncMode.Off => 0,
                VSyncMode.On => 1,
                VSyncMode.Adaptive => IsRunningSlowly ? 0 : 1,
                _ => 0
            };

            if ((API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES) &&
                (_lastVs is null || _lastVs.Value != vs))
            {
                _lastVs = vs;
                _glfw.SwapInterval(vs);
                Glfw.ThrowExceptions();
            }

            if (IsClosing)
            {
                return;
            }

            Render?.Invoke(delta);

            if (ShouldSwapAutomatically)
            {
                SwapBuffers();
            }
        }

        /// <summary>
        /// Setup all window callbacks
        /// </summary>
        private unsafe void InitializeCallbacks()
        {
            _onMove = (window, x, y) =>
            {
                var point = new Point(x, y);
                _position = point;
                Move?.Invoke(point);
            };

            _onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                _size = size;
                Resize?.Invoke(size);
            };

            _onClosing = window => Closing?.Invoke();

            _onFocusChanged = (window, isFocused) => FocusChanged?.Invoke(isFocused);

            _onMinimized = (window, isMinimized) =>
            {
                WindowState state;
                // If minimized, we immediately know what value the new WindowState is.
                if (isMinimized)
                {
                    state = WindowState.Minimized;
                }
                else
                {
                    // Otherwise, we have to querry a few things to figure out out.
                    if (_glfw.GetWindowAttrib(_windowPtr, WindowAttributeGetter.Maximized))
                    {
                        state = WindowState.Maximized;
                    }
                    else if (_glfw.GetWindowMonitor(_windowPtr) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                _windowState = state;
                StateChanged?.Invoke(state);
            };

            _onMaximized = (window, isMaximized) =>
            {
                // Same here as in onMinimized.
                WindowState state;
                if (isMaximized)
                {
                    state = WindowState.Maximized;
                }
                else
                {
                    if (_glfw.GetWindowAttrib(_windowPtr, WindowAttributeGetter.Iconified))
                    {
                        state = WindowState.Minimized;
                    }
                    else if (_glfw.GetWindowMonitor(_windowPtr) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                _windowState = state;
                StateChanged?.Invoke(state);
            };

            _onFileDrop = (window, count, paths) =>
            {
                var arrayOfPaths = new string[count];

                if (count == 0 || paths == IntPtr.Zero)
                {
                    return;
                }

                for (var i = 0; i < count; i++)
                {
                    var p = Marshal.ReadIntPtr(paths, i * IntPtr.Size);
                    arrayOfPaths[i] = Marshal.PtrToStringAnsi(p);
                }

                FileDrop?.Invoke(arrayOfPaths);
            };

            _glfw.SetWindowPosCallback(_windowPtr, _onMove);
            _glfw.SetWindowSizeCallback(_windowPtr, _onResize);
            _glfw.SetWindowCloseCallback(_windowPtr, _onClosing);
            _glfw.SetWindowFocusCallback(_windowPtr, _onFocusChanged);
            _glfw.SetWindowIconifyCallback(_windowPtr, _onMinimized);
            _glfw.SetWindowMaximizeCallback(_windowPtr, _onMaximized);
            _glfw.SetDropCallback(_windowPtr, _onFileDrop);
            Glfw.ThrowExceptions();
        }

        /// <inheritdoc />
        public bool IsVulkanSupported => _glfw.VulkanSupported();

        /// <inheritdoc />
        public unsafe VkHandle CreateSurface<T>(VkHandle instance, T* allocator)
            where T : unmanaged
        {
            var surface = stackalloc VkHandle[1];
            int ec;
            if ((ec = _glfw.CreateWindowSurface(instance, _windowPtr, allocator, surface)) != 0)
            {
                throw new GlfwException("Failed to create surface, error code " + ec);
            }

            Glfw.ThrowExceptions();
            return surface[0];
        }

        /// <inheritdoc />
        public unsafe char** GetRequiredExtensions(out uint count)
        {
            return (char**) _glfw.GetRequiredInstanceExtensions(out count);
        }

        /// <summary>
        /// Creates a subwindow with the given options.
        /// </summary>
        /// <param name="opts">The window options to use.</param>
        /// <returns>A subwindow.</returns>
        public IWindow CreateWindow(WindowOptions opts)
        {
            // GLFW doesn't support child windows yet, so just create a window as normal.
            return GlfwPlatform.Instance.CreateWindow(opts);
        }

        public IWindowHost Parent { get; }

        public unsafe IMonitor Monitor
        {
            get
            {
                if (!_running)
                {
                    return _initialMonitor;
                }

                var monitor = _glfw.GetWindowMonitor(_windowPtr);
                if (monitor == null)
                {
                    if (_windowState != WindowState.Fullscreen)
                    {
                        var monitors = new GlfwMonitorEnumerable();
                        // Determine which monitor this window is on. [6 marks]
                        foreach (var m in monitors)
                        {
                            var pos = Position;
                            var size = Size;
                            if (m.Bounds.Contains(new Point(pos.X + size.Width / 2, pos.Y + size.Height / 2)))
                            {
                                return m;
                            }
                        }
                    }

                    monitor = _glfw.GetPrimaryMonitor();
                }

                return monitor == null
                    ? null
                    : new GlfwMonitor
                    (
                        monitor,
                        IndexOf(_glfw.GetMonitors(out var count), monitor, count)
                    );
            }
            set
            {
                if (!_running)
                {
                    throw new InvalidOperationException("Window is not running.");
                }

                if (value is null)
                {
                    throw new ArgumentNullException();
                }

                if (_windowState == WindowState.Fullscreen)
                {
                    var h = ((GlfwMonitor) value).Handle;
                    var vidMode = value.VideoMode;
                    var resolution = vidMode.Resolution;
                    if (!resolution.HasValue)
                    {
                        throw new InvalidOperationException("Monitor resolution not found.");
                    }

                    if (!vidMode.RefreshRate.HasValue)
                    {
                        throw new InvalidOperationException("Monitor refresh rate not found.");
                    }

                    _glfw.SetWindowMonitor
                    (
                        _windowPtr, h, 0, 0, resolution.Value.Width, resolution.Value.Height, vidMode.RefreshRate.Value
                    );
                    Glfw.ThrowExceptions();
                }
                else
                {
                    Position = value.Bounds.Location;
                }
            }
        }

        private unsafe int IndexOf<T>(T** array, T* target, int count)
            where T : unmanaged
        {
            for (var i = 0; i < count; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

#pragma warning disable 8632
        public IGLContext? GLContext { get; }
        public IVkSurface? VkSurface { get; }
#pragma warning restore 8632

        private readonly struct Context : IGLContext
        {
            private readonly GlfwWindow _window;

            public Context(GlfwWindow window)
            {
                _window = window;
            }

            public IntPtr GetProcAddress(string proc) => _window._glfw.GetProcAddress(proc);
            public IntPtr Handle => _window.Handle;
            public unsafe bool IsCurrent => _window._glfw.GetCurrentContext() == _window._windowPtr;
            public void SwapInterval(int interval) => _window._glfw.SwapInterval(interval);

            public unsafe void SwapBuffers() => _window._glfw.SwapBuffers(_window._windowPtr);

            public unsafe void MakeCurrent() => _window._glfw.MakeContextCurrent(_window._windowPtr);

            public unsafe void Clear()
            {
                if (IsCurrent)
                {
                    _window._glfw.MakeContextCurrent(null);
                }
            }

            public void Dispose()
            {
            }
        }

        private readonly struct Surface : IVkSurface
        {
            private readonly GlfwWindow _window;

            public Surface(GlfwWindow window)
            {
                _window = window;
            }

            public unsafe VkHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged
            {
                var surface = stackalloc VkHandle[1];
                int ec;
                if ((ec = _window._glfw.CreateWindowSurface(instance, _window._windowPtr, allocator, surface)) != 0)
                {
                    throw new GlfwException("Failed to create surface, error code " + ec);
                }

                return surface[0];
            }

            public unsafe char** GetRequiredExtensions(out uint count)
                => (char**) _window._glfw.GetRequiredInstanceExtensions(out count);
        }

        private readonly struct Invocation : IDisposable
        {
            public Invocation(Delegate target, object[] args, Action<object> ret)
            {
                Source = new AutoResetEvent(false);
                Target = target;
                Args = args;
                Return = ret;
            }

            public AutoResetEvent Source { get; }
            public Delegate Target { get; }
            public object[] Args { get; }
            public Action<object> Return { get; }

            public void Dispose()
            {
                Source?.Dispose();
            }
        }
    }
}
