using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    public struct VideoMode
    {
        public const int DONT_CARE = -1;

        public VideoMode(Size resolution, int refreshRate = DONT_CARE)
        {
            Resolution = resolution;
            RefreshRate = refreshRate;
        }

        public VideoMode(int refreshRate = DONT_CARE)
            : this(new Size(DONT_CARE, DONT_CARE), refreshRate)
        {

        }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Size Resolution { get; }
        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int RefreshRate { get; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default => new VideoMode();
    }
}
