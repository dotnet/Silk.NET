// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// Status for various <see cref="ISurfaceHost"/> functions.
/// </summary>
public enum HostStatus
{
    /// <summary>
    /// The operation failed and is unrecoverable.
    /// </summary>
    Failure,

    /// <summary>
    /// The operation has concluded successfully.
    /// </summary>
    Success,

    /// <summary>
    /// The operation is still executing.
    /// </summary>
    Continuing
}
