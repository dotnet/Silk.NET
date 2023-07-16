// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
public static partial class XAUDIO2D
{
    [NativeTypeName("#define XAUDIO2D_DLL_A \"xaudio2_9d.dll\"")]
    public static ReadOnlySpan<byte> XAUDIO2D_DLL_A => "xaudio2_9d.dll"u8;

    [NativeTypeName("#define XAUDIO2D_DLL_W L\"xaudio2_9d.dll\"")]
    public const string XAUDIO2D_DLL_W = "xaudio2_9d.dll";
    [NativeTypeName("#define XAUDIO2D_DLL XAUDIO2D_DLL_W")]
    public const string XAUDIO2D_DLL = "xaudio2_9d.dll";
}