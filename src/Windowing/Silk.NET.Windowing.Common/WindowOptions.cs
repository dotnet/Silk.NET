// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all window properties, used for window creation.
    /// </summary>
    public struct WindowOptions : IWindowProperties
    {
        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; set; }
        
        /// <inheritdoc />
        public Point Position { get; set; }
        
        /// <inheritdoc />
        public Size Size { get; set; }
        
        /// <inheritdoc />
        public double FramesPerSecond { get; set; }
        
        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }
        
        /// <inheritdoc />
        public GraphicsAPI API { get; set; }
        
        /// <inheritdoc />
        public WindowState WindowState { get; set; }
        
        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }
        
        /// <inheritdoc />
        public VSyncMode VSync { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct, with sensible defaults.
        /// </summary>
        public WindowOptions(bool useSingleThreadedWindow, Point position, Size size, double framesPerSecond,
            double updatesPerSecond, GraphicsAPI api, WindowState windowState, WindowBorder windowBorder, VSyncMode vSync)
        {
            UseSingleThreadedWindow = useSingleThreadedWindow;
            Position = position;
            Size = size;
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            WindowState = windowState;
            WindowBorder = windowBorder;
            VSync = vSync;
        }

        /// <summary>
        /// Convinience wrapper around creating a new WindowProperties with the default values.
        /// </summary>
        public static WindowOptions Default => new WindowOptions(true, new Point(-1, -1),
            new Size(1280, 720), 0.0, 0.0, GraphicsAPI.Default,
            WindowState.Normal, WindowBorder.Resizable, VSyncMode.On);
    }
}