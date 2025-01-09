// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public partial class FFX
{
    [LibraryImport("kernel32.dll")]
    private static unsafe partial void* GetProcAddress(HinstanceHandle ptr, ReadOnlySpan<byte> function);
}
