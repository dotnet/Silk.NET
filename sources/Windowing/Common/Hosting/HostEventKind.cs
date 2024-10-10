// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// The types of events received on a surface host.
/// </summary>
public enum HostEventKind
{
    /// <summary>
    /// No event was retrieved from the event pump.
    /// </summary>
    None,

    /// <summary>
    /// A property changed on one of the hosted surfaces.
    /// </summary>
    SurfacePropertyChanged,

    /// <summary>
    /// The user has requested termination.
    /// </summary>
    AppLifecycleTerminationRequested,

    /// <summary>
    /// The application is quitting irrevocably.
    /// </summary>
    AppLifecycleTerminating,

    /// <summary>
    /// The application has received a low memory warning from the OS.
    /// </summary>
    AppLifecycleLowMemoryWarning,

    /// <summary>
    /// The application is going into the background.
    /// </summary>
    AppLifecyclePausing,

    /// <summary>
    /// The application has gone into the background.
    /// </summary>
    AppLifecyclePaused,

    /// <summary>
    /// The application is going into the foreground.
    /// </summary>
    AppLifecycleResuming,

    /// <summary>
    /// The application ahs gone into the foreground.
    /// </summary>
    AppLifecycleResumed
}
