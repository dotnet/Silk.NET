// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        /// <inheritdoc />
        public IntPtr Handle { get; }
        
        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; }
        
        /// <inheritdoc />
        public Point Position { get; set; }
        
        /// <inheritdoc />
        public Size Size { get; set; }
        
        /// <inheritdoc />
        public double FramesPerSecond { get; }
        
        /// <inheritdoc />
        public double UpdatesPerSecond { get; }
        
        /// <inheritdoc />
        public GraphicsAPI API { get; }
        
        /// <inheritdoc />
        public WindowState WindowState { get; set; }
        
        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }
        
        /// <inheritdoc />
        public VSyncMode VSync { get; set; }

        public GlfwWindow(WindowOptions options)
        {
            
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