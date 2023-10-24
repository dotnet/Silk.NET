// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Versioning;

namespace Silk.NET.Windowing;

#if NET6_0_OR_GREATER
/// <summary>
/// A view that receives canvas drop notifications.
/// </summary>
public interface INotifyCanvasDropped : IView
{
    /// <summary>
    /// The canvas has been dropped.
    /// </summary>
    [SupportedOSPlatform("browser")]
    void CanvasDropped();
}
#endif
