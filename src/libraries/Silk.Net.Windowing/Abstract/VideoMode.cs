using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public readonly struct VideoMode
    {
        public VideoMode(Vector2D<int>? resolution = null, int? refreshRate = null)
        {
            throw new NotImplementedException();
        }

        public VideoMode(int? refreshRate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Vector2D<int>? Resolution { get; init; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; init; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default { get; }
    }
}