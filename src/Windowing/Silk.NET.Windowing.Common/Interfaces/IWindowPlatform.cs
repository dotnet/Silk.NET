// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// An interface that provides windowing for its respective native backend.
    /// </summary>
    public interface IWindowPlatform : IWindowHost
    {
#if NETSTANDARD2_1
        /// <summary>
        /// Gets the name of this window platform.
        /// </summary>
        string Name => GetType().Name;
#endif

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

        /// <summary>
        /// Gets whether the given view is sourced from this platform.
        /// </summary>
        /// <param name="view">The view to check.</param>
        /// <returns>Whether the view is sourced from this platform.</returns>
        bool IsSourceOfView(IView view);
    }
}
