// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    public interface IViewProperties
    {
        /// <summary>
        /// If true, both updates and rendering will happen on the same thread. If false, both updating and rendering
        /// will be run on their own threads.
        /// </summary>
        bool UseSingleThreadedWindow { get; }

        /// <summary>
        /// If true, SwapBuffers will be called automatically at the end of each Render event.
        /// </summary>
        bool ShouldSwapAutomatically { get; }

        /// <summary>
        /// If true, instead of executing the Update and Render events at a fixed interval, they will only be executed
        /// once there are events waiting to be processed.
        /// </summary>
        /// <remarks>
        /// The <see cref="UpdatesPerSecond"/> and <see cref="FramesPerSecond"/> will still be respected and treated as
        /// the "maximum" number of frames per second. Typically, the time between events is greater than the frame
        /// period, however.
        /// </remarks>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Size Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// The graphics API to use, and associated configurations.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// The VSync mode.
        /// </summary>
        VSyncMode VSync { get; set; }

        /// <summary>
        /// The number of frames the window needs to be running slowly for before <see cref="IWindow.IsRunningSlowly"/>
        /// is set to true.
        /// </summary>
        int RunningSlowTolerance { get; set; }

        /// <summary>
        /// The video mode.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// Preferred depth buffer bits of the window's framebuffer.
        /// </summary>
        int? PreferredDepthBufferBits { get; }
    }
}
