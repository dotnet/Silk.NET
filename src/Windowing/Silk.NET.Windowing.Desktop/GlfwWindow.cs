// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Ultz.Dispatcher;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        // The number of frames that the window has been running slowly for.
        private int _isRunningSlowlyTries;

        private Point _position;

        private Size _size;

        private string _title;

        private VSyncMode _vSync;

        private WindowBorder _windowBorder;

        private WindowState _windowState;

        // Glfw stuff
        private Glfw glfw = GlfwProvider.GLFW.Value;
        private Dispatcher glfwThread = GlfwProvider.ThreadDispatcher;
        private GlfwCallbacks.WindowCloseCallback onClosing;
        private GlfwCallbacks.DropCallback onFileDrop;
        private GlfwCallbacks.WindowFocusCallback onFocusChanged;
        private GlfwCallbacks.WindowMaximizeCallback onMaximized;
        private GlfwCallbacks.WindowIconifyCallback onMinimized;

        // Callbacks

        private GlfwCallbacks.WindowPosCallback onMove;
        private GlfwCallbacks.WindowSizeCallback onResize;
        private Dispatcher RenderDispatcher;

        // The period for rendering and updating. In essence, the delay between events being fired off.
        private double renderPeriod;

        // The stopwatches. Used to calculate delta.
        private Stopwatch renderStopwatch;

        // Main loop-related things

        // Dispatcher for the update and render threads
        private Dispatcher UpdateDispatcher;
        private double updatePeriod;
        private Stopwatch updateStopwatch;
        private unsafe WindowHandle* WindowPtr;

        public GlfwWindow(WindowOptions options)
        {
            unsafe {
                // Title and Size must be set before the window is created.
                _title = options.Title;
                _size = options.Size;

                _windowBorder = WindowBorder;

                glfwThread.Invoke(() =>
                {
                    // Set window border.
                    switch (options.WindowBorder) {
                        case WindowBorder.Hidden:
                            glfw.WindowHint(WindowHintBool.Decorated, false);
                            glfw.WindowHint(WindowHintBool.Resizable, false);
                            break;

                        case WindowBorder.Resizable:
                            glfw.WindowHint(WindowHintBool.Decorated, true);
                            glfw.WindowHint(WindowHintBool.Resizable, true);
                            break;

                        case WindowBorder.Fixed:
                            glfw.WindowHint(WindowHintBool.Decorated, true);
                            glfw.WindowHint(WindowHintBool.Resizable, false);
                            break;
                    }

                    // Set window API.
                    switch (options.API.API) {
                        case ContextAPI.None:
                        case ContextAPI.Vulkan:
                            glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                            break;
                        case ContextAPI.OpenGL:
                            glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
                            break;
                        case ContextAPI.OpenGLES:
                            glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGLES);
                            break;
                    }

                    // Set API version.
                    glfw.WindowHint(WindowHintInt.ContextVersionMajor, options.API.Version.MajorVersion);
                    glfw.WindowHint(WindowHintInt.ContextVersionMinor, options.API.Version.MinorVersion);

                    // Set API flags
                    if (options.API.Flags.HasFlag(ContextFlags.ForwardCompatible)) {
                        glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
                    }

                    if (options.API.Flags.HasFlag(ContextFlags.Debug)) {
                        glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
                    }

                    // Set API profile
                    glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile,
                        options.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat);

                    // Create window
                    WindowPtr = glfw.CreateWindow(_size.Width, _size.Height, _title, null, null);
                });

                MakeCurrent();

                FramesPerSecond = options.FramesPerSecond;
                UpdatesPerSecond = options.UpdatesPerSecond;

                WindowState = options.WindowState;
                Position = options.Position;
                VSync = options.VSync;

                InitializeCallbacks();
            }
        }

        /// <inheritdoc />
        public bool IsRunningSlowly => _isRunningSlowlyTries > 5;

        /// <inheritdoc />
        public bool IsVisible
        {
            get
            {
                unsafe {
                    return glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Visible);
                }
            }
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        if (value) {
                            glfw.ShowWindow(WindowPtr);
                        }
                        else {
                            glfw.HideWindow(WindowPtr);
                        }
                    }
                });
            }
        }

        /// <inheritdoc />
        public IntPtr Handle
        {
            get
            {
                unsafe {
                    return (IntPtr) WindowPtr;
                }
            }
        }

        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; }

        /// <inheritdoc />
        public Point Position
        {
            get => _position;
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        glfw.SetWindowPos(WindowPtr, value.X, value.Y);
                    }
                });

                _position = value;
            }
        }

        /// <inheritdoc />
        public Size Size
        {
            get => _size;
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        glfw.SetWindowSize(WindowPtr, value.Width, value.Height);
                    }
                });

                _size = value;
            }
        }

        /// <inheritdoc />
        public double FramesPerSecond { get; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; }

        /// <inheritdoc />
        public GraphicsAPI API { get; }

        /// <inheritdoc />
        public string Title
        {
            get => _title;
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        glfw.SetWindowTitle(WindowPtr, value);
                    }
                });

                _title = value;
            }
        }

        /// <inheritdoc />
        public WindowState WindowState
        {
            get => _windowState;
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        switch (value) {
                            case WindowState.Normal:
                                glfw.RestoreWindow(WindowPtr);
                                break;
                            case WindowState.Minimized:
                                glfw.IconifyWindow(WindowPtr);
                                break;
                            case WindowState.Maximized:
                                glfw.MaximizeWindow(WindowPtr);
                                break;
                            case WindowState.Fullscreen:
                                var monitor = glfw.GetPrimaryMonitor();
                                var mode = glfw.GetVideoMode(monitor);
                                glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height,
                                    mode->RefreshRate);
                                break;
                        }
                    }
                });

                _windowState = value;
            }
        }

        /// <inheritdoc />
        public WindowBorder WindowBorder
        {
            get => _windowBorder;
            set
            {
                glfwThread.Invoke(() =>
                {
                    unsafe {
                        switch (value) {
                            case WindowBorder.Hidden:
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, false);
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
                                break;

                            case WindowBorder.Resizable:
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, true);
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, true);
                                break;

                            case WindowBorder.Fixed:
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, true);
                                glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
                                break;
                        }
                    }
                });

                _windowBorder = value;
            }
        }

        /// <inheritdoc />
        public VSyncMode VSync
        {
            get => _vSync;
            set
            {
                switch (value) {
                    case VSyncMode.Off:
                        glfw.SwapInterval(0);
                        break;

                    case VSyncMode.On:
                        glfw.SwapInterval(1);
                        break;

                    default:
                        glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
                        break;
                }

                _vSync = value;
            }
        }

        /// <inheritdoc />
        public object Invoke(Delegate d)
        {
            return glfwThread.Invoke(d);
        }

        /// <inheritdoc />
        public object Invoke(Delegate d, params object[] args)
        {
            return glfwThread.Invoke(d, args);
        }

        /// <inheritdoc />
        public void Run()
        {
            // Run OnLoad.
            OnLoad?.Invoke();

            // Initialize some variables
            _isRunningSlowlyTries = 0;
            renderStopwatch = new Stopwatch();
            updateStopwatch = new Stopwatch();

            // Calculate the update speed.
            if (UpdatesPerSecond <= double.Epsilon) {
                updatePeriod = 0.0;
            }
            else {
                updatePeriod = 1.0 / UpdatesPerSecond;
            }

            // Calculate the render speed.
            if (FramesPerSecond <= double.Epsilon) {
                renderPeriod = 0.0;
            }
            else {
                renderPeriod = 1.0 / FramesPerSecond;
            }

            UpdateDispatcher = new Dispatcher();
            RenderDispatcher = new Dispatcher();

            // Start the update loop.
            unsafe {
                while (!glfw.WindowShouldClose(WindowPtr)) {
                    ProcessEvents();

                    if (UseSingleThreadedWindow) {
                        RaiseUpdateFrame();
                        RaiseRenderFrame();
                    }
                    else {
                        UpdateDispatcher.Invoke(RaiseUpdateFrame);
                        RenderDispatcher.Invoke(RaiseRenderFrame);
                    }

                    if (VSync == VSyncMode.Adaptive) {
                        glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
                    }

                    SwapBuffers();
                }
            }
        }

        /// <inheritdoc />
        public void Close()
        {
            unsafe {
                glfw.SetWindowShouldClose(WindowPtr, true);
            }
        }

        /// <inheritdoc />
        public void ProcessEvents()
        {
            glfwThread.Invoke(() => { glfw.PollEvents(); });
        }

        /// <inheritdoc />
        public void SwapBuffers()
        {
            unsafe {
                glfw.SwapBuffers(WindowPtr);
            }
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            unsafe {
                glfw.MakeContextCurrent(WindowPtr);
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
        public event Action<Point> OnMove;

        /// <inheritdoc />
        public event Action<Size> OnResize;

        /// <inheritdoc />
        public event Action OnClosing;

        /// <inheritdoc />
        public event Action<WindowState> OnStateChanged;

        /// <inheritdoc />
        public event Action<bool> OnFocusChanged;

        /// <inheritdoc />
        public event Action<string[]> OnFileDrop;

        /// <inheritdoc />
        public event Action OnLoad;

        /// <inheritdoc />
        public event Action<double> OnUpdate;

        /// <inheritdoc />
        public event Action<double> OnRender;

        private void RaiseUpdateFrame()
        {
            // If using a capped framerate, we have to do some synchronization-related things before rendering.
            // This is only necessary if VSync is disabled.
            if (UpdatesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly)) {
                // Calculate the amount of time to sleep.
                var sleepTime = updatePeriod - updateStopwatch.Elapsed.TotalSeconds;

                // If the result is negative, that means the frame is running slowly. Mark as such and don't sleep.
                if (sleepTime < 0.0) {
                    _isRunningSlowlyTries += 1;
                }
                // Else, sleep for that amount of time.
                else {
                    _isRunningSlowlyTries = 0;
                    Thread.Sleep((int) (1000 * sleepTime));
                }
            }

            // Calculate delta and run frame.
            var delta = updateStopwatch.Elapsed.TotalSeconds;
            OnUpdate?.Invoke(delta);
            updateStopwatch.Restart();
        }

        private void RaiseRenderFrame()
        {
            // If using a capped framerate, we have to do some synchronization-related things before rendering.
            if (FramesPerSecond > double.Epsilon
                && (VSync == VSyncMode.Off || VSync == VSyncMode.Adaptive && IsRunningSlowly)) {
                // Calculate the amount of time to sleep.
                var sleepTime = renderPeriod - renderStopwatch.Elapsed.TotalSeconds;

                // If the result is negative, that means the frame is running slowly, so don't sleep.
                if (sleepTime > 0.0) {
                    // Else, sleep for that amount of time.
                    var timeBefore = renderStopwatch.Elapsed.TotalSeconds;
                    Thread.Sleep((int) (1000 * sleepTime));
                    var timeAfter = renderStopwatch.Elapsed.TotalSeconds;

                    Console.WriteLine($"Tried sleeping for {sleepTime}, slept for {timeAfter - timeBefore}," +
                                      $"variance of {timeAfter - timeBefore - sleepTime}\n");
                }
            }

            // Calculate delta and run frame.
            var delta = renderStopwatch.Elapsed.TotalSeconds;
            OnRender?.Invoke(delta);
            renderStopwatch.Restart();
        }

        /// <summary>
        /// Setup all window callbacks
        /// </summary>
        private unsafe void InitializeCallbacks()
        {
            onMove = (window, x, y) =>
            {
                var point = new Point(x, y);
                _position = point;
                OnMove?.Invoke(point);
            };

            onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                _size = size;
                OnResize?.Invoke(size);
            };

            onClosing = window => OnClosing?.Invoke();

            onFocusChanged = (window, isFocused) => OnFocusChanged?.Invoke(isFocused);

            onMinimized = (window, isMinimized) =>
            {
                WindowState state;
                // If minimized, we immediately know what value the new WindowState is.
                if (isMinimized) {
                    state = WindowState.Minimized;
                }
                else {
                    // Otherwise, we have to querry a few things to figure out out.
                    if (glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Maximized)) {
                        state = WindowState.Maximized;
                    }
                    else if (glfw.GetWindowMonitor(WindowPtr) != null) {
                        state = WindowState.Fullscreen;
                    }
                    else {
                        state = WindowState.Normal;
                    }
                }

                _windowState = state;
                OnStateChanged?.Invoke(state);
            };

            onMaximized = (window, isMaximized) =>
            {
                // Same here as in onMinimized.
                WindowState state;
                if (isMaximized) {
                    state = WindowState.Maximized;
                }
                else {
                    if (glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Iconified)) {
                        state = WindowState.Minimized;
                    }
                    else if (glfw.GetWindowMonitor(WindowPtr) != null) {
                        state = WindowState.Fullscreen;
                    }
                    else {
                        state = WindowState.Normal;
                    }
                }

                _windowState = state;
                OnStateChanged?.Invoke(state);
            };

            onFileDrop = (window, count, paths) =>
            {
                var arrayOfPaths = new string[count];

                if (count == 0 || paths == IntPtr.Zero) {
                    return;
                }

                for (var i = 0; i < count; i++) {
                    var p = Marshal.ReadIntPtr(paths, i * IntPtr.Size);
                    arrayOfPaths[i] = Marshal.PtrToStringAnsi(p);
                }

                OnFileDrop?.Invoke(arrayOfPaths);
            };

            glfwThread.Invoke(() =>
            {
                glfw.SetWindowPosCallback(WindowPtr, onMove);
                glfw.SetWindowSizeCallback(WindowPtr, onResize);
                glfw.SetWindowCloseCallback(WindowPtr, onClosing);
                glfw.SetWindowFocusCallback(WindowPtr, onFocusChanged);
                glfw.SetWindowIconifyCallback(WindowPtr, onMinimized);
                glfw.SetWindowMaximizeCallback(WindowPtr, onMaximized);
                glfw.SetDropCallback(WindowPtr, onFileDrop);
            });
        }
    }
}