// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.DataStructures;

internal interface ISdlInputEventQueue<T> : IDisposable where T : struct
{
    public void Enqueue(in T item, ulong sdlTimestamp);
}
