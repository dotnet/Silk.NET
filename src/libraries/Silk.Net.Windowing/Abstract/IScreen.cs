using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// An interface representing a screen.
    /// </summary>
    public interface IScreen
    {
        /// <summary>
        /// The name of this screen.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The index of this screen.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// The workarea of this screen.
        /// </summary>
        Rectangle<int> WorkArea { get; }

        /// <summary>
        /// The current video mode of this monitor.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// This screen's gamma correction.
        /// </summary>
        float Gamma { get; set; }

        /// <summary>
        /// Get all video modes that this screen supports.
        /// </summary>
        /// <returns>An array of all video modes.</returns>
        IEnumerable<VideoMode> GetAllVideoModes()
        {
            throw new NotImplementedException();
        }
    }
}