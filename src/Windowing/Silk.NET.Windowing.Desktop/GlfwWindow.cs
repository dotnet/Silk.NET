// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        private Glfw glfw = GlfwProvider.GLFW.Value;
        private unsafe WindowHandle* WindowPtr;
        
        private Thread renderThread;
        private Stopwatch renderClock;
        private Stopwatch updateClock;

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
            OnLoad();
            
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

            // Start the render thread if using multiple threads.
            if (!UseSingleThreadedWindow) {
                renderThread = new Thread(StartRenderThread);
                renderThread.Start();
            }
            
            // Initialize update clock.
            updateClock = new Stopwatch();
            updateClock.Start();

            // If using a single thread, clock must be initialized here.
            // Otherwise, it needs to go in StartRenderThread.
            if (UseSingleThreadedWindow) {
                renderClock = new Stopwatch();
                renderClock.Start();
            }

            // Start the update loop.
            unsafe {
                while (!glfw.WindowShouldClose(WindowPtr)) {
                    ProcessEvents();
                    
                    RaiseUpdateFrame();

                    if (UseSingleThreadedWindow) {
                        RaiseRenderFrame();
                    }

                    if (VSync == VSyncMode.Adaptive) {
                        glfw.SwapInterval(IsRunningSlowly ? 0 : 1);
                    }
                }
            }
        }

        private double updateEpsilon = 0.0;
        
        private void RaiseUpdateFrame()
        {
            var elapsed = updateClock.Elapsed.TotalMilliseconds;

            while (elapsed > 0 && elapsed + updateEpsilon >= updatePeriod) {
                OnUpdate(elapsed);
                
                updateEpsilon += elapsed - updatePeriod;
                
                updateClock.Restart();

                if (UpdatesPerSecond <= double.Epsilon) {
                    break;
                }
            }
        }

        private void StartRenderThread()
        {
            renderClock = new Stopwatch();
            renderClock.Start();
            
            unsafe {
                while (!glfw.WindowShouldClose(WindowPtr)) {
                    RaiseRenderFrame();
                }
            }
        }
        
        public void RaiseRenderFrame()
        {
            OnRender(renderClock.Elapsed.TotalMilliseconds);
            renderClock.Restart();
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
                OnMove(point);
            };
            glfw.SetWindowPosCallback(WindowPtr, onMove);
            
            onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                _size = size;
                OnResize(size);
            };
            glfw.SetWindowSizeCallback(WindowPtr, onResize);
            
            onClosing = (window) => OnClosing();
            glfw.SetWindowCloseCallback(WindowPtr, onClosing);
            
            onFocusChanged = (window, isFocused) => OnFocusChanged(isFocused);
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
                OnWindowStateChanged(state);
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
                OnWindowStateChanged(state);
            };
            glfw.SetWindowMaximizeCallback(WindowPtr, onMaximized);

            onFileDrop = (window, count, paths) =>
            {
                var pathsStrings = (char**)paths;

                var arrayOfPaths = new string[count];

                for (var i = 0; i < count; i++)
                {
                    if (pathsStrings != null)
                    {
                        arrayOfPaths[i] = new string(pathsStrings[i]);
                    }
                }

                OnFileDrop(arrayOfPaths);
                
            };
            glfw.SetDropCallback(WindowPtr, onFileDrop);
        }

        /// <inheritdoc />
        public virtual void OnMove(Point newPosition)
        {
        }

        /// <inheritdoc />
        public virtual void OnResize(Size newSize)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnClosing()
        {
            
        }

        /// <inheritdoc />
        public virtual void OnWindowStateChanged(WindowState newState)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnFocusChanged(bool isFocused)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnVisibilityChanged(bool isVisible)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnFileDrop(string[] files)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnLoad()
        {
            
        }

        /// <inheritdoc />
        public virtual void OnUpdate(double delta)
        {
            
        }

        /// <inheritdoc />
        public virtual void OnRender(double delta)
        {
            
        }
    }
}