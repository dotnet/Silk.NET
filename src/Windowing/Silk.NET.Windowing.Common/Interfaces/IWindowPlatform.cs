// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface that provides windowing for its respective native backend.
    /// </summary>
    public interface IWindowPlatform : IWindowHost
    {
        bool IsViewOnly { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="IWindowPlatform"/> should be used, based on the
        /// current runtime/environment.
        /// </summary>
        bool IsApplicable { get; }

        /// <summary>
        /// Gets or creates a window view.
        /// On desktop platforms, this mimics GetWindow unless you pass null to the opts parameter. In which case,
        /// this will return the last created window.
        /// On mobile platforms, this will create a view for the given platform if one doesn't exist, or 
        /// </summary>
        /// <param name="opts"></param>
        /// <returns></returns>
        IView GetView(ViewOptions? opts = null);

        /// <summary>
        /// Clears all current contexts on this thread.
        /// </summary>
        void ClearContexts();

        /// <summary>
        /// Gets all monitors present on this window platform.
        /// </summary>
        /// <returns>All monitors present on this window platform</returns>
        IEnumerable<IMonitor> GetMonitors();
        /// <summary>
        /// Gets the main monitor.
        /// </summary>
        /// <returns>The main monitor.</returns>
        IMonitor GetMainMonitor();
    }
}
