// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_COLOR.xml' path='doc/member[@name="D3D11_VIDEO_COLOR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_COLOR
{
    /// <include file='D3D11_VIDEO_COLOR.xml' path='doc/member[@name="D3D11_VIDEO_COLOR.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d11_L10762_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.YCbCr"]/*'/>
    [UnscopedRef]
    public ref D3D11_VIDEO_COLOR_YCbCrA YCbCr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.YCbCr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RGBA"]/*'/>
    [UnscopedRef]
    public ref D3D11_VIDEO_COLOR_RGBA RGBA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RGBA;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.YCbCr"]/*'/>
        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RGBA"]/*'/>
        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_RGBA RGBA;
    }
}