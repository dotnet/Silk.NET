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
    SurfacePropertyChanged
}
