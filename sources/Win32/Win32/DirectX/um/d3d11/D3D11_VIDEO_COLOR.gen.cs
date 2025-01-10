// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_COLOR
{
    [NativeTypeName("__AnonymousRecord_d3d11_L10795_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D11_VIDEO_COLOR_YCbCrA YCbCr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.YCbCr; }
    }

    [UnscopedRef]
    public ref D3D11_VIDEO_COLOR_RGBA RGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.RGBA; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr;

        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_RGBA RGBA;
    }
}
