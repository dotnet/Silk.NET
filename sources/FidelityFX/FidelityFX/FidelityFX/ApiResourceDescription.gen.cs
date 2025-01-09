// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public partial struct ApiResourceDescription
{
    [NativeTypeName("uint32_t")]
    public uint Type;

    [NativeTypeName("uint32_t")]
    public uint Format;

    [NativeTypeName("__AnonymousRecord_ffx_api_types_L162_C5")]
    public ApiResourceDescriptionAnonymous1 Anonymous1;

    [NativeTypeName("__AnonymousRecord_ffx_api_types_L167_C5")]
    public ApiResourceDescriptionAnonymous2 Anonymous2;

    [NativeTypeName("__AnonymousRecord_ffx_api_types_L172_C5")]
    public ApiResourceDescriptionAnonymous3 Anonymous3;

    [NativeTypeName("uint32_t")]
    public uint MipCount;

    [NativeTypeName("uint32_t")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    public uint Usage;

    [UnscopedRef]
    public ref uint width
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Width; }
    }

    [UnscopedRef]
    public ref uint size
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Size; }
    }

    [UnscopedRef]
    public ref uint height
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Height; }
    }

    [UnscopedRef]
    public ref uint stride
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Stride; }
    }

    [UnscopedRef]
    public ref uint depth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.Depth; }
    }

    [UnscopedRef]
    public ref uint alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.Alignment; }
    }
}
