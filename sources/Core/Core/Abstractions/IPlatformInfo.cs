// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Base component for platform info components.
/// </summary>
public interface IPlatformInfo
{
    /// <summary>
    /// Gets any handles relevant to the next layer down from this platform in cases where wrapper APIs are used.
    /// </summary>
    IPlatformInfo? Next { get; }
}
