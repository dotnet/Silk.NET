// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.DataStructures;

internal readonly record struct GenericEvent(object Queue, int Index, SdlEventDiscriminator Type)
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref readonly T Value<T>() where T : struct => ref ((SdlInputEventQueue<T>)Queue).UnsafeGetRef(Index);
}
