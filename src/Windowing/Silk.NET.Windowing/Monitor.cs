// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.Core.Platform;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing
{
    public static class Monitor
    {
        /// <summary>
        /// Gets all monitors present on this window platform.
        /// </summary>
        /// <returns>All monitors present on this window platform</returns>
        public static IEnumerable<IMonitor> GetMonitors()
        {
            if (Window.Platform is null)
            {
                Window.Init();
            }

            return Window.Platform.GetMonitors();
        }

        /// <summary>
        /// Gets the main monitor.
        /// </summary>
        /// <returns>The main monitor.</returns>
        public static IMonitor GetMainMonitor()
        {
            if (Window.Platform is null)
            {
                Window.Init();
            }

            return Window.Platform.GetMainMonitor();
        }
    }
}
