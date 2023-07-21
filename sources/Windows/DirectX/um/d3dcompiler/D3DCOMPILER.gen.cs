// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

public static partial class D3DCOMPILER
{
    [NativeTypeName("#define D3DCOMPILER_DLL_W L\"d3dcompiler_47.dll\"")]
    public const string D3DCOMPILER_DLL_W = "d3dcompiler_47.dll";

    [NativeTypeName("#define D3DCOMPILER_DLL_A \"d3dcompiler_47.dll\"")]
    public static ReadOnlySpan<byte> D3DCOMPILER_DLL_A => "d3dcompiler_47.dll"u8;

    [NativeTypeName("#define D3DCOMPILER_DLL D3DCOMPILER_DLL_W")]
    public const string D3DCOMPILER_DLL = "d3dcompiler_47.dll";
}
