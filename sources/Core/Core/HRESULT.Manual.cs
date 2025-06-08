// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

/// <summary>
/// Common error code value returned by Microsoft methods
/// </summary>
public partial struct HResult
{
    /// <summary>
    /// Has the function failed
    /// </summary>
    public bool Failed => Value < 0;

    /// <summary>
    /// Has the function succeeded
    /// </summary>
    public bool Succeeded => Value >= 0;
}
