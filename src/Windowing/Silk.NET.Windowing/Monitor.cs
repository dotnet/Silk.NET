// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.Windowing.Common;
using static Silk.NET.Windowing.Window;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Contains methods for accessing monitors.
    /// </summary>
    public static class Monitor
    {
        /// <summary>
        /// Gets all monitors present on this window platform.
        /// </summary>
        /// <returns>All monitors present on this window platform</returns>
        public static IEnumerable<IMonitor> GetMonitors()
            => Platform?.GetMonitors() ?? FirstPartyPlatform?.GetMonitors() ?? throw NoPlatformException;

        /// <summary>
        /// Gets the main monitor.
        /// </summary>
        /// <returns>The main monitor.</returns>
        public static IMonitor GetMainMonitor()
            => Platform?.GetMainMonitor() ?? FirstPartyPlatform?.GetMainMonitor() ?? throw NoPlatformException;
    }
}
