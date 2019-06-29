// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Timer = System.Timers.Timer;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        private Glfw glfw = GlfwProvider.GLFW.Value;
        private unsafe WindowHandle* WindowPtr;

        private Timer renderTimer;
        private Timer updateTimer;

        private double renderPeriod;
        private double updatePeriod;
        
        public bool IsRunningSlowly { get; private set; }

        private bool _isVisible;

        /// <inheritdoc />
        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                unsafe {
                    if (value) {
                        glfw.ShowWindow(WindowPtr);
                    }
                    else {
                        glfw.HideWindow(WindowPtr);
                    }
                }

                _isVisible = value;
            }
        }

        /// <inheritdoc />
        public IntPtr Handle
        {
            get
            {
                unsafe {
                    return new IntPtr(WindowPtr);
                }
            }
        }

        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; }

        private Point _position;

        /// <inheritdoc />
        public Point Position
        {
            get => _position;
            set
            {
                unsafe {
                    glfw.SetWindowPos(WindowPtr, value.X, value.Y);
                }

                _position = value;
            }
        }

        private Size _size;

        /// <inheritdoc />
        public Size Size
        {
            get => _size;
            set
            {
                unsafe {
                    glfw.SetWindowSize(WindowPtr, value.Width, value.Height);
                }

                _size = value;
            }
        }

        /// <inheritdoc />
        public double FramesPerSecond { get; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; }

        /// <inheritdoc />
        public GraphicsAPI API { get; }

        private string _title;

        /// <inheritdoc />
        public string Title
        {
            get => _title;
            set
            {
                unsafe {
                    glfw.SetWindowTitle(WindowPtr, value);
                }

                _title = value;
            }
        }

        private WindowState _windowState;

        /// <inheritdoc />
        public WindowState WindowState
        {
            get => _windowState;
            set
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
                            var monitor = glfw.GetWindowMonitor(WindowPtr);
                            var mode = glfw.GetVideoMode(monitor);
                            glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height,
                                mode->RefreshRate);
                            break;
                    }
                }

                _windowState = value;
            }
        }

        private WindowBorder _windowBorder;

        /// <inheritdoc />
        public WindowBorder WindowBorder
        {
            get => _windowBorder;
            set
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

                _windowBorder = value;
            }
        }

        private VSyncMode _vSync;

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

        public GlfwWindow(WindowOptions options)
        {
            unsafe {
                // Title and Size must be set before the window is created.
                _title = options.Title;
                _size = options.Size;

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

                _windowBorder = WindowBorder;

                // Set window API.
                switch (options.API.API) {
                    case ContextAPI.None:
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

                MakeCurrent();

                WindowState = options.WindowState;
                Position = options.Position;
                VSync = options.VSync;

                InitializeCallbacks();
            }
        }

        /// <inheritdoc />
        public void Run()
        {
            OnLoad?.Invoke();
            
            IsRunningSlowly = false;
            
            // Calculate the update speed.
            if (UpdatesPerSecond < double.Epsilon) {
                updatePeriod = 0.0;
            }
            else {
                updatePeriod = 1.0 / UpdatesPerSecond;
            }
            
            // Calculate the render speed.
            if (FramesPerSecond < double.Epsilon) {
                renderPeriod = 0.0;
            }
            else {
                renderPeriod = 1.0 / FramesPerSecond;
            }

            if (updatePeriod > double.Epsilon) {
                updateTimer = new Timer(updatePeriod);
                updateTimer.Elapsed += RaiseUpdateFrame;
                updateTimer.Start();
            }

            if (renderPeriod > double.Epsilon) {
                renderTimer = new Timer(renderPeriod);
                renderTimer.Elapsed += RaiseRenderFrame;
                renderTimer.Start();
            }

            // Start the update loop.
            unsafe {
                while (!glfw.WindowShouldClose(WindowPtr)) {
                    ProcessEvents();
                    
                    if (updatePeriod <= double.Epsilon) {
                        OnUpdate?.Invoke(0.0);
                    }

                    if (renderPeriod <= double.Epsilon) {
                        OnRender?.Invoke(0.0);
                    }

                    if (VSync == VSyncMode.Adaptive) {
                        glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
                    }
                }
            }
        }
        
        private void RaiseUpdateFrame(object _o, EventArgs _e)
        {
            OnUpdate?.Invoke(updatePeriod);
        }
        
        public void RaiseRenderFrame(object _o, EventArgs _e)
        {
            OnRender?.Invoke(renderPeriod);
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
            glfw.PollEvents();
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

        // Callbacks

        private GlfwCallbacks.WindowPosCallback onMove;
        private GlfwCallbacks.WindowSizeCallback onResize;
        private GlfwCallbacks.WindowCloseCallback onClosing;
        private GlfwCallbacks.WindowFocusCallback onFocusChanged;
        private GlfwCallbacks.WindowIconifyCallback onMinimized;
        private GlfwCallbacks.WindowMaximizeCallback onMaximized;
        private GlfwCallbacks.DropCallback onFileDrop;

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
            glfw.SetWindowPosCallback(WindowPtr, onMove);
            
            onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                _size = size;
                OnResize?.Invoke(size);
            };
            glfw.SetWindowSizeCallback(WindowPtr, onResize);
            
            onClosing = (window) => OnClosing?.Invoke();
            glfw.SetWindowCloseCallback(WindowPtr, onClosing);
            
            onFocusChanged = (window, isFocused) => OnFocusChanged?.Invoke(isFocused);
            glfw.SetWindowFocusCallback(WindowPtr, onFocusChanged);

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
            glfw.SetWindowIconifyCallback(WindowPtr, onMinimized);

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
            glfw.SetWindowMaximizeCallback(WindowPtr, onMaximized);

            onFileDrop = (window, count, paths) =>
            {
                var arrayOfPaths = new string[count];

                if (count == 0 || paths == IntPtr.Zero) {
                    return;
                }
                
                for (var i = 0; i < count; i++)
                {
                    var p = Marshal.ReadIntPtr(paths, i * IntPtr.Size);
                    arrayOfPaths[i] = Marshal.PtrToStringAnsi(p);
                }

                OnFileDrop?.Invoke(arrayOfPaths);
                
            };
            glfw.SetDropCallback(WindowPtr, onFileDrop);
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
    }
}