// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IVulkanWindow
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

        // Invoke method variables
        private ConcurrentQueue<Task> _invokeQueue;
        private int _mainThread = -1;

        // Update and render period. Represents the time in seconds that each frame should take.
        private double _updatePeriod;
        private double _renderPeriod;

        private WindowOptions _initialOptions;
        private bool _running;

        /// <summary>
        /// Create a new GlfwWindow.
        /// </summary>
        /// <param name="options">The options to use for this window.</param>
        public GlfwWindow(WindowOptions options)
        {
            // Title and Size must be set before the window is created.
            _title = options.Title;
            _size = options.Size;

            _windowBorder = WindowBorder;

            FramesPerSecond = options.FramesPerSecond;
            UpdatesPerSecond = options.UpdatesPerSecond;

            RunningSlowTolerance = options.RunningSlowTolerance;
            UseSingleThreadedWindow = options.UseSingleThreadedWindow;
            ShouldSwapAutomatically = options.ShouldSwapAutomatically;
            
            _initialOptions = options;
        }

        /// <inheritdoc />
        public int RunningSlowTolerance { get; set; }

        /// <inheritdoc />
        public unsafe bool IsClosing => _glfw.WindowShouldClose(_windowPtr);

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
                _initialOptions.Position = value;
            }
        }

        /// <inheritdoc />
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
                _size = value;
            }
        }

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
                                _glfw.SetWindowMonitor
                                (
                                    _windowPtr, monitor, 0, 0, mode->Width, mode->Height,
                                    mode->RefreshRate
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
                    _vSync = value;
                }

                _initialOptions.VSync = value;
                _vSync = value;
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

            var task = new Task<object>(() => d.DynamicInvoke(args));
            _invokeQueue.Enqueue(task);
            SpinWait.SpinUntil(() => task.IsCompleted);
            return task.Result;
        }

        private bool _contextMoved;

        /// <inheritdoc />
        public unsafe void MakeCurrent()
        {
            _contextMoved = true;
            _glfw.MakeContextCurrent(_windowPtr);
        }
        
        /// <summary>
        /// Make context current on this thread if it was moved to another one.
        /// </summary>
        /// <remarks>
        /// Awaiting rewrite.
        /// </remarks>
        private void MakeCurrentInternal()
        {
            if (_contextMoved)
            {
                MakeCurrent();
                _contextMoved = false;
            }
        }

        /// <inheritdoc />
        public void Close()
        {
            unsafe
            {
                _glfw.SetWindowShouldClose(_windowPtr, true);
            }
        }

        /// <inheritdoc />
        public unsafe void Open()
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

            // Create window
            _windowPtr = _glfw.CreateWindow(_size.Width, _size.Height, _title, null, null);

            _invokeQueue = new ConcurrentQueue<Task>();
            _mainThread = Thread.CurrentThread.ManagedThreadId;

            if (API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES)
            {
                _glfw.MakeContextCurrent(_windowPtr);
                VSync = _initialOptions.VSync;
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

            // Initialize some variables
            _isRunningSlowlyTries = 0;
            _running = true;

            _renderStopwatch = new Stopwatch();
            _updateStopwatch = new Stopwatch();
            _renderStopwatch.Start();
            _updateStopwatch.Start();
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
                    if (!_invokeQueue.IsEmpty && _invokeQueue.TryDequeue(out var invokeCall))
                    {
                        invokeCall.GetAwaiter().GetResult();
                    }
                }
            }
        }

        /// <inheritdoc />
        public void DoEvents()
        {
            _glfw.PollEvents();
        }

        /// <inheritdoc />
        public unsafe void Reset()
        {
            _updateStopwatch.Stop();
            _renderStopwatch.Stop();
            _glfw.DestroyWindow(_windowPtr);
            _windowPtr = (WindowHandle*) 0;
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
        public event Action Load;

        /// <inheritdoc />
        public event Action<double> Update;

        /// <inheritdoc />
        public event Action<double> Render;

        /// <summary>
        /// Run an OnUpdate event.
        /// </summary>
        private void RaiseUpdateFrame()
        {
            // If using a capped framerate without vsync, we have to do some synchronization-related things
            // before rendering.
            if (UpdatesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly))
            {
                // Calculate the amount of time to sleep.
                var sleepTime = _updatePeriod - _updateStopwatch.Elapsed.TotalSeconds;

                // If the result is negative, that means the frame is running slowly. Mark as such and don't sleep.
                if (sleepTime < 0.0)
                {
                    _isRunningSlowlyTries += 1;
                }
                // Else, sleep for that amount of time.
                else
                {
                    _isRunningSlowlyTries = 0;
                    Thread.Sleep((int) (1000 * sleepTime));
                }
            }

            // Calculate delta and run frame.
            var delta = _updateStopwatch.Elapsed.TotalSeconds;
            Update?.Invoke(delta);

            _updateStopwatch.Restart();
        }

        /// <summary>
        /// Run an OnRender event.
        /// </summary>
        private void RaiseRenderFrame()
        {
            // Identical to RaiseUpdateFrame.
            if (FramesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly))
            {
                var sleepTime = _renderPeriod - _renderStopwatch.Elapsed.TotalSeconds;

                if (sleepTime > 0.0)
                {
                    Thread.Sleep((int) (1000 * sleepTime));
                }
            }

            var delta = _renderStopwatch.Elapsed.TotalSeconds;
            
            Render?.Invoke(delta);

            if (ShouldSwapAutomatically)
            {
                SwapBuffers();
            }

            _renderStopwatch.Restart();

            // This has to be called on the thread with the graphics context
            if (VSync == VSyncMode.Adaptive)
            {
                _glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
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

            return surface[0];
        }
        
        /// <inheritdoc />
        public unsafe char** GetRequiredExtensions(out uint count)
        {
            return (char**) _glfw.GetRequiredInstanceExtensions(out count);
        }
    }
}
