// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable once CheckNamespace

using Silk.NET.SDL;

namespace Silk.NET.Windowing;

public partial interface ISurfaceApplication
{
    public static sealed partial void Run<T>()
        where T : ISurfaceApplication { }
}
