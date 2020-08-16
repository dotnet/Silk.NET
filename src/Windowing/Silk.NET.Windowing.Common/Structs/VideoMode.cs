using System.Drawing;

namespace Silk.NET.Windowing
{
    public struct VideoMode
    {
        public VideoMode(Size? resolution = null, int? refreshRate = null)
        {
            Resolution = resolution;
            RefreshRate = refreshRate;
        }

        public VideoMode(int refreshRate)
            : this(null, refreshRate)
        {
        }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Size? Resolution { get; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default => new VideoMode();
    }
}
