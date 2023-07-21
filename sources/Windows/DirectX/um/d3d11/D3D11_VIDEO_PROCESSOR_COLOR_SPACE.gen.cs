// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
{
    public uint _bitfield;

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Usage"]/*' />
    [NativeTypeName("uint : 1")]
    public uint Usage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
        }
    }

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.RGB_Range"]/*' />
    [NativeTypeName("uint : 1")]
    public uint RGB_Range
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 1) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
        }
    }

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.YCbCr_Matrix"]/*' />
    [NativeTypeName("uint : 1")]
    public uint YCbCr_Matrix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
        }
    }

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.YCbCr_xvYCC"]/*' />
    [NativeTypeName("uint : 1")]
    public uint YCbCr_xvYCC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 3) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
        }
    }

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Nominal_Range"]/*' />
    [NativeTypeName("uint : 2")]
    public uint Nominal_Range
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 4) & 0x3u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3u << 4)) | ((value & 0x3u) << 4);
        }
    }

    /// <include file='D3D11_VIDEO_PROCESSOR_COLOR_SPACE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_COLOR_SPACE.Reserved"]/*' />
    [NativeTypeName("uint : 26")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 6) & 0x3FFFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3FFFFFFu << 6)) | ((value & 0x3FFFFFFu) << 6);
        }
    }
}
