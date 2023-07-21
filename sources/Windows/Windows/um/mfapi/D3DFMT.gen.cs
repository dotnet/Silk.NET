// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

public static partial class D3DFMT
{
    [NativeTypeName("#define D3DFMT_R8G8B8 20")]
    public const int D3DFMT_R8G8B8 = 20;

    [NativeTypeName("#define D3DFMT_A8R8G8B8 21")]
    public const int D3DFMT_A8R8G8B8 = 21;

    [NativeTypeName("#define D3DFMT_X8R8G8B8 22")]
    public const int D3DFMT_X8R8G8B8 = 22;

    [NativeTypeName("#define D3DFMT_R5G6B5 23")]
    public const int D3DFMT_R5G6B5 = 23;

    [NativeTypeName("#define D3DFMT_X1R5G5B5 24")]
    public const int D3DFMT_X1R5G5B5 = 24;

    [NativeTypeName("#define D3DFMT_A2B10G10R10 31")]
    public const int D3DFMT_A2B10G10R10 = 31;

    [NativeTypeName("#define D3DFMT_P8 41")]
    public const int D3DFMT_P8 = 41;

    [NativeTypeName("#define D3DFMT_L8 50")]
    public const int D3DFMT_L8 = 50;

    [NativeTypeName("#define D3DFMT_D16 80")]
    public const int D3DFMT_D16 = 80;

    [NativeTypeName("#define D3DFMT_L16 81")]
    public const int D3DFMT_L16 = 81;

    [NativeTypeName("#define D3DFMT_A16B16G16R16F 113")]
    public const int D3DFMT_A16B16G16R16F = 113;
}
