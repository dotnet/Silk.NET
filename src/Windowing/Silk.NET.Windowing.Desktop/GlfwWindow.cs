// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        private Glfw glfw = Glfw.GetAPI();
        private unsafe WindowHandle* WindowPtr;

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
            set {
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
                    switch (value)
                    {
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
                            glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height, mode->RefreshRate);
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
                        throw new NotImplementedException();
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
                if (options.API.Flags.HasFlag(ContextFlags.ForwardCompatible))
                {
                    glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
                }

                if (options.API.Flags.HasFlag(ContextFlags.Debug))
                {
                    glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
                }

                // Set API profile
                glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile,
                    options.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat);

                // Create window
                WindowPtr = glfw.CreateWindow(_size.Width, _size.Height, _title, null, null);

                WindowState = options.WindowState;
                Position = options.Position;
                VSync = options.VSync;
            }
        }

        /// <inheritdoc />
        public void Run()
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc />
        public void Close()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ProcessEvents()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SwapBuffers()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }
    }
}