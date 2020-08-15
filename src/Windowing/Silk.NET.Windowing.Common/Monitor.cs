// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.Windowing
{
    public static class Monitor
    {
        /// <summary>
        /// Gets all monitors present on this window platform.
        /// </summary>
        /// <returns>All monitors present on this window platform</returns>
        public static IEnumerable<IMonitor> GetMonitors(IView? view)
        {
            foreach (var platform in Window.Platforms)
            {
                if (view is null ? platform.IsApplicable : platform.IsSourceOfView(view))
                {
                    return platform.GetMonitors();
                }
            }

            throw Window.NoPlatformException;
        }

        /// <summary>
        /// Gets the main monitor.
        /// </summary>
        /// <returns>The main monitor.</returns>
        public static IMonitor GetMainMonitor(IView? view)
        {
            foreach (var platform in Window.Platforms)
            {
                if (view is null ? platform.IsApplicable : platform.IsSourceOfView(view))
                {
                    return platform.GetMainMonitor();
                }
            }

            throw Window.NoPlatformException;
        }
    }
}
