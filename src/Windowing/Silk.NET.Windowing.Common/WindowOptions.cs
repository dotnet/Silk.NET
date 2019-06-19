using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all window properties, used for window creation.
    /// </summary>
    public class WindowOptions : IWindowProperties
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
        public WindowOptions()
        {
            UseSingleThreadedWindow = true;
            Position = new Point(-1, -1);
            Size = new Size(1280, 720);
            FramesPerSecond = 0.0;
            UpdatesPerSecond = 0.0;
            API = GraphicsAPI.Default;
            WindowState = WindowState.Normal;
            WindowBorder = WindowBorder.Resizable;
            VSync = VSyncMode.On;
        }

        /// <summary>
        /// Convinience wrapper around creating a new WindowProperties with the default values.
        /// </summary>
        public static WindowOptions Default { get; }
    }
}