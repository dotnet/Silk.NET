// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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