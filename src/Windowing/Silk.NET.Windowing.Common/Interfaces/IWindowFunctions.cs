//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all windowing functions.
    /// </summary>
    public interface IWindowFunctions
    {
        /// <summary>
        /// Close this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Process all pending window events.
        /// </summary>
        void ProcessEvents();

        /// <summary>
        /// Swap between rendering buffers.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Makes this window's rendering API current for the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Converts this point to client coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns></returns>
        Point PointToClient(Point point);

        /// <summary>
        /// Converts this point to screen coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns></returns>
        Point PointToScreen(Point point);
    }
}
