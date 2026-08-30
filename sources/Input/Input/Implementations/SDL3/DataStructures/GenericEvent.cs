// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.DataStructures;

internal readonly record struct GenericEvent(nint EventPtr, SdlEventDiscriminator Type)
{
    public unsafe ref T Value<T>() => ref Unsafe.AsRef<T>((void*)EventPtr);
}
